using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TempCleaner
{
    public partial class TempCleaner : Form
    {
        String Route = @"C:\Windows\Temp";

        public TempCleaner()
        {
            InitializeComponent();

            TxtRoute.Text = Route;
        }

        private void BtProcess_Click(object sender, EventArgs e)
        {
            try
            {
                String[] TotalFiles = Directory.GetFiles(Route);
                String[] TotalFolders = Directory.GetDirectories(Route);

                int CountFiles = TotalFiles.Count() + TotalFolders.Count();
                int CurrentProgress = 0;

                PBProgress.Minimum = 0;
                PBProgress.Maximum = CountFiles;
                PBProgress.Value = 0;

                int FilesDelete = 0;
                int FoldersDelete = 0;

                if (TotalFiles.Count() > 0)
                {
                    foreach (var file in TotalFiles)
                    {
                        try
                        {
                            File.Delete(file);
                            FilesDelete++;
                        }
                        catch
                        {
                            // Ignore if cannot be deleted.
                        }

                    }

                    CurrentProgress++;
                    PBProgress.Value = CurrentProgress;
                }

                if (TotalFolders.Count() > 0)
                {
                    foreach (var folder in TotalFolders)
                    {
                        try
                        {
                            // Delete if empty.
                            if (Directory.GetFiles(folder).Length == 0 && Directory.GetDirectories(folder).Length == 0)
                            {
                                Directory.Delete(folder);
                                FoldersDelete++;
                            }
                        }
                        catch
                        {
                            // Ignore if cannot be deleted.
                        }
                    }

                    CurrentProgress++;
                    PBProgress.Value = CurrentProgress;
                }

                MessageBox.Show(
                $"Cleaning completed.\n\nDeleted files: {FilesDelete}\nDeleted folders: {FoldersDelete}",
                "Cleaning completed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during cleaning: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
