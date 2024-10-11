using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodySort
{
    public class ProgressDialog
    {
        private Form progressForm;
        private Label progressLabel;
        private ProgressBar progressBar;

        public ProgressDialog()
        {
            progressForm = new Form();
            progressForm.Text = "Progress";
            progressForm.Size = new Size(300, 100);
            progressForm.TopMost = true; // Set to topmost

            progressBar = new ProgressBar();
            progressBar.Dock = DockStyle.Top;
            progressBar.Height = 20;
            progressForm.Controls.Add(progressBar);

            progressLabel = new Label();
            progressLabel.Dock = DockStyle.Fill;
            progressLabel.TextAlign = ContentAlignment.MiddleCenter;
            progressLabel.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            progressForm.Controls.Add(progressLabel);

            progressForm.Show();
        }

        public void UpdateProgress(int currentProgress, int totalProgress)
        {
            if (totalProgress > 0)
            {
                int percentage = (currentProgress * 100) / totalProgress;
                progressBar.Value = Math.Min(percentage, 100);
            }
            progressLabel.Text = $"Converting of selection. Body {currentProgress} from {totalProgress}";
            
            progressForm.Refresh();
        }

        public void Close()
        {
            progressForm.Close();
        }
    }
}
