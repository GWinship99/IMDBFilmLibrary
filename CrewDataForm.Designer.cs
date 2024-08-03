namespace IMDBFilmLibrary
{
    partial class CrewDataForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            retrieveDataBtn = new Button();
            storeDataBtn = new Button();
            filmList = new TextBox();
            textBox2 = new TextBox();
            searchBtn = new Button();
            SuspendLayout();
            // 
            // retrieveDataBtn
            // 
            retrieveDataBtn.Location = new Point(1043, 117);
            retrieveDataBtn.Name = "retrieveDataBtn";
            retrieveDataBtn.Size = new Size(256, 46);
            retrieveDataBtn.TabIndex = 0;
            retrieveDataBtn.Text = "Retrieve Data";
            retrieveDataBtn.UseVisualStyleBackColor = true;
            // 
            // storeDataBtn
            // 
            storeDataBtn.Location = new Point(1043, 47);
            storeDataBtn.Name = "storeDataBtn";
            storeDataBtn.Size = new Size(262, 46);
            storeDataBtn.TabIndex = 1;
            storeDataBtn.Text = "Store Data";
            storeDataBtn.UseVisualStyleBackColor = true;
            // 
            // filmList
            // 
            filmList.Location = new Point(31, 49);
            filmList.Name = "filmList";
            filmList.Size = new Size(907, 39);
            filmList.TabIndex = 2;
            filmList.Text = "Retrieved crew data goes here...";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(950, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 39);
            textBox2.TabIndex = 3;
            textBox2.Text = "Search for data here!";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(950, 232);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(355, 46);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // CrewDataForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 963);
            Controls.Add(searchBtn);
            Controls.Add(textBox2);
            Controls.Add(filmList);
            Controls.Add(storeDataBtn);
            Controls.Add(retrieveDataBtn);
            Name = "CrewDataForm";
            Text = "Crew Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button retrieveDataBtn;
        private Button storeDataBtn;
        private TextBox filmList;
        private TextBox textBox2;
        private Button searchBtn;
    }
}
