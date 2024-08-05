
namespace IMDBFilmLibrary
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            crewDataBtn = new Button();
            episodeDataBtn = new Button();
            ratingsDataBtn = new Button();
            SuspendLayout();
            // 
            // crewDataBtn
            // 
            crewDataBtn.Location = new Point(12, 28);
            crewDataBtn.Name = "crewDataBtn";
            crewDataBtn.Size = new Size(150, 46);
            crewDataBtn.TabIndex = 0;
            crewDataBtn.Text = "Crew Data";
            crewDataBtn.UseVisualStyleBackColor = true;
            crewDataBtn.Click += crewDataBtn_Click;
            // 
            // episodeDataBtn
            // 
            episodeDataBtn.Location = new Point(181, 28);
            episodeDataBtn.Name = "episodeDataBtn";
            episodeDataBtn.Size = new Size(210, 46);
            episodeDataBtn.TabIndex = 1;
            episodeDataBtn.Text = "Episode Data";
            episodeDataBtn.UseVisualStyleBackColor = true;
            episodeDataBtn.Click += episodeDataBtn_Click;
            // 
            // ratingsDataBtn
            // 
            ratingsDataBtn.Location = new Point(408, 28);
            ratingsDataBtn.Name = "ratingsDataBtn";
            ratingsDataBtn.Size = new Size(218, 46);
            ratingsDataBtn.TabIndex = 2;
            ratingsDataBtn.Text = "Ratings Data";
            ratingsDataBtn.UseVisualStyleBackColor = true;
            ratingsDataBtn.Click += ratingsDataBtn_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ratingsDataBtn);
            Controls.Add(episodeDataBtn);
            Controls.Add(crewDataBtn);
            Name = "MainMenuForm";
            Text = "IMDB Film Library Menu";
            ResumeLayout(false);
        }



        #endregion

        private Button crewDataBtn;
        private Button episodeDataBtn;
        private Button ratingsDataBtn;
    }
}