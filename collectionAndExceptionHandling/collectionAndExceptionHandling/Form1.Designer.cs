namespace collectionAndExceptionHandling
{
    partial class Form1
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
            this.butAddMovie = new System.Windows.Forms.Button();
            this.butDelMovie = new System.Windows.Forms.Button();
            this.butSearchYear = new System.Windows.Forms.Button();
            this.butPrintAllMov = new System.Windows.Forms.Button();
            this.listBoxPrintMoviesResults = new System.Windows.Forms.ListBox();
            this.textBoxYearSearchInput = new System.Windows.Forms.TextBox();
            this.textBoxDeleteByYearMovieInput = new System.Windows.Forms.TextBox();
            this.textBoxInputMovieYear = new System.Windows.Forms.TextBox();
            this.labelMovieInputYear = new System.Windows.Forms.Label();
            this.labelMovieTitleInput = new System.Windows.Forms.Label();
            this.textBoxMovieTitleInput = new System.Windows.Forms.TextBox();
            this.textBoxMovieDirectorInput = new System.Windows.Forms.TextBox();
            this.labelMovieDirectorInput = new System.Windows.Forms.Label();
            this.labelSearchByYear = new System.Windows.Forms.Label();
            this.labelDeleteByYear = new System.Windows.Forms.Label();
            this.labelIAddYearError = new System.Windows.Forms.Label();
            this.labelTitleInputError = new System.Windows.Forms.Label();
            this.labelDirectorInputError = new System.Windows.Forms.Label();
            this.labelDeleteMovieError = new System.Windows.Forms.Label();
            this.labelSearchErrorInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butAddMovie
            // 
            this.butAddMovie.Location = new System.Drawing.Point(17, 44);
            this.butAddMovie.Name = "butAddMovie";
            this.butAddMovie.Size = new System.Drawing.Size(75, 23);
            this.butAddMovie.TabIndex = 0;
            this.butAddMovie.Text = "Add Movie";
            this.butAddMovie.UseVisualStyleBackColor = true;
            this.butAddMovie.Click += new System.EventHandler(this.butAddMovie_Click);
            // 
            // butDelMovie
            // 
            this.butDelMovie.Location = new System.Drawing.Point(17, 213);
            this.butDelMovie.Name = "butDelMovie";
            this.butDelMovie.Size = new System.Drawing.Size(75, 23);
            this.butDelMovie.TabIndex = 1;
            this.butDelMovie.Text = "Delete Movie";
            this.butDelMovie.UseVisualStyleBackColor = true;
            this.butDelMovie.Click += new System.EventHandler(this.butDelMovie_Click);
            // 
            // butSearchYear
            // 
            this.butSearchYear.Location = new System.Drawing.Point(17, 295);
            this.butSearchYear.Name = "butSearchYear";
            this.butSearchYear.Size = new System.Drawing.Size(75, 23);
            this.butSearchYear.TabIndex = 2;
            this.butSearchYear.Text = "Search";
            this.butSearchYear.UseVisualStyleBackColor = true;
            this.butSearchYear.Click += new System.EventHandler(this.butSearchYear_Click);
            // 
            // butPrintAllMov
            // 
            this.butPrintAllMov.Location = new System.Drawing.Point(17, 342);
            this.butPrintAllMov.Name = "butPrintAllMov";
            this.butPrintAllMov.Size = new System.Drawing.Size(75, 23);
            this.butPrintAllMov.TabIndex = 3;
            this.butPrintAllMov.Text = "Print All";
            this.butPrintAllMov.UseVisualStyleBackColor = true;
            this.butPrintAllMov.Click += new System.EventHandler(this.butPrintAllMov_Click);
            // 
            // listBoxPrintMoviesResults
            // 
            this.listBoxPrintMoviesResults.FormattingEnabled = true;
            this.listBoxPrintMoviesResults.Location = new System.Drawing.Point(122, 342);
            this.listBoxPrintMoviesResults.Name = "listBoxPrintMoviesResults";
            this.listBoxPrintMoviesResults.Size = new System.Drawing.Size(442, 173);
            this.listBoxPrintMoviesResults.TabIndex = 4;
            // 
            // textBoxYearSearchInput
            // 
            this.textBoxYearSearchInput.Location = new System.Drawing.Point(185, 298);
            this.textBoxYearSearchInput.Name = "textBoxYearSearchInput";
            this.textBoxYearSearchInput.Size = new System.Drawing.Size(379, 20);
            this.textBoxYearSearchInput.TabIndex = 5;
            // 
            // textBoxDeleteByYearMovieInput
            // 
            this.textBoxDeleteByYearMovieInput.Location = new System.Drawing.Point(185, 211);
            this.textBoxDeleteByYearMovieInput.Name = "textBoxDeleteByYearMovieInput";
            this.textBoxDeleteByYearMovieInput.Size = new System.Drawing.Size(379, 20);
            this.textBoxDeleteByYearMovieInput.TabIndex = 6;
            // 
            // textBoxInputMovieYear
            // 
            this.textBoxInputMovieYear.Location = new System.Drawing.Point(185, 47);
            this.textBoxInputMovieYear.Name = "textBoxInputMovieYear";
            this.textBoxInputMovieYear.Size = new System.Drawing.Size(379, 20);
            this.textBoxInputMovieYear.TabIndex = 7;
            // 
            // labelMovieInputYear
            // 
            this.labelMovieInputYear.AutoSize = true;
            this.labelMovieInputYear.Location = new System.Drawing.Point(119, 50);
            this.labelMovieInputYear.Name = "labelMovieInputYear";
            this.labelMovieInputYear.Size = new System.Drawing.Size(29, 13);
            this.labelMovieInputYear.TabIndex = 8;
            this.labelMovieInputYear.Text = "Year";
            // 
            // labelMovieTitleInput
            // 
            this.labelMovieTitleInput.AutoSize = true;
            this.labelMovieTitleInput.Location = new System.Drawing.Point(119, 95);
            this.labelMovieTitleInput.Name = "labelMovieTitleInput";
            this.labelMovieTitleInput.Size = new System.Drawing.Size(27, 13);
            this.labelMovieTitleInput.TabIndex = 9;
            this.labelMovieTitleInput.Text = "Title";
            // 
            // textBoxMovieTitleInput
            // 
            this.textBoxMovieTitleInput.Location = new System.Drawing.Point(185, 92);
            this.textBoxMovieTitleInput.Name = "textBoxMovieTitleInput";
            this.textBoxMovieTitleInput.Size = new System.Drawing.Size(379, 20);
            this.textBoxMovieTitleInput.TabIndex = 10;
            // 
            // textBoxMovieDirectorInput
            // 
            this.textBoxMovieDirectorInput.Location = new System.Drawing.Point(185, 136);
            this.textBoxMovieDirectorInput.Name = "textBoxMovieDirectorInput";
            this.textBoxMovieDirectorInput.Size = new System.Drawing.Size(379, 20);
            this.textBoxMovieDirectorInput.TabIndex = 11;
            // 
            // labelMovieDirectorInput
            // 
            this.labelMovieDirectorInput.AutoSize = true;
            this.labelMovieDirectorInput.Location = new System.Drawing.Point(119, 139);
            this.labelMovieDirectorInput.Name = "labelMovieDirectorInput";
            this.labelMovieDirectorInput.Size = new System.Drawing.Size(44, 13);
            this.labelMovieDirectorInput.TabIndex = 12;
            this.labelMovieDirectorInput.Text = "Director";
            // 
            // labelSearchByYear
            // 
            this.labelSearchByYear.AutoSize = true;
            this.labelSearchByYear.Location = new System.Drawing.Point(128, 301);
            this.labelSearchByYear.Name = "labelSearchByYear";
            this.labelSearchByYear.Size = new System.Drawing.Size(29, 13);
            this.labelSearchByYear.TabIndex = 13;
            this.labelSearchByYear.Text = "Year";
            // 
            // labelDeleteByYear
            // 
            this.labelDeleteByYear.AutoSize = true;
            this.labelDeleteByYear.Location = new System.Drawing.Point(119, 218);
            this.labelDeleteByYear.Name = "labelDeleteByYear";
            this.labelDeleteByYear.Size = new System.Drawing.Size(29, 13);
            this.labelDeleteByYear.TabIndex = 14;
            this.labelDeleteByYear.Text = "Year";
            // 
            // labelIAddYearError
            // 
            this.labelIAddYearError.AutoSize = true;
            this.labelIAddYearError.Location = new System.Drawing.Point(185, 73);
            this.labelIAddYearError.Name = "labelIAddYearError";
            this.labelIAddYearError.Size = new System.Drawing.Size(0, 13);
            this.labelIAddYearError.TabIndex = 15;
            // 
            // labelTitleInputError
            // 
            this.labelTitleInputError.AutoSize = true;
            this.labelTitleInputError.Location = new System.Drawing.Point(185, 120);
            this.labelTitleInputError.Name = "labelTitleInputError";
            this.labelTitleInputError.Size = new System.Drawing.Size(0, 13);
            this.labelTitleInputError.TabIndex = 16;
            // 
            // labelDirectorInputError
            // 
            this.labelDirectorInputError.AutoSize = true;
            this.labelDirectorInputError.Location = new System.Drawing.Point(185, 159);
            this.labelDirectorInputError.Name = "labelDirectorInputError";
            this.labelDirectorInputError.Size = new System.Drawing.Size(0, 13);
            this.labelDirectorInputError.TabIndex = 17;
            // 
            // labelDeleteMovieError
            // 
            this.labelDeleteMovieError.AutoSize = true;
            this.labelDeleteMovieError.Location = new System.Drawing.Point(185, 234);
            this.labelDeleteMovieError.Name = "labelDeleteMovieError";
            this.labelDeleteMovieError.Size = new System.Drawing.Size(0, 13);
            this.labelDeleteMovieError.TabIndex = 18;
            // 
            // labelSearchErrorInput
            // 
            this.labelSearchErrorInput.AutoSize = true;
            this.labelSearchErrorInput.Location = new System.Drawing.Point(185, 321);
            this.labelSearchErrorInput.Name = "labelSearchErrorInput";
            this.labelSearchErrorInput.Size = new System.Drawing.Size(0, 13);
            this.labelSearchErrorInput.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 533);
            this.Controls.Add(this.labelSearchErrorInput);
            this.Controls.Add(this.labelDeleteMovieError);
            this.Controls.Add(this.labelDirectorInputError);
            this.Controls.Add(this.labelTitleInputError);
            this.Controls.Add(this.labelIAddYearError);
            this.Controls.Add(this.labelDeleteByYear);
            this.Controls.Add(this.labelSearchByYear);
            this.Controls.Add(this.labelMovieDirectorInput);
            this.Controls.Add(this.textBoxMovieDirectorInput);
            this.Controls.Add(this.textBoxMovieTitleInput);
            this.Controls.Add(this.labelMovieTitleInput);
            this.Controls.Add(this.labelMovieInputYear);
            this.Controls.Add(this.textBoxInputMovieYear);
            this.Controls.Add(this.textBoxDeleteByYearMovieInput);
            this.Controls.Add(this.textBoxYearSearchInput);
            this.Controls.Add(this.listBoxPrintMoviesResults);
            this.Controls.Add(this.butPrintAllMov);
            this.Controls.Add(this.butSearchYear);
            this.Controls.Add(this.butDelMovie);
            this.Controls.Add(this.butAddMovie);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddMovie;
        private System.Windows.Forms.Button butDelMovie;
        private System.Windows.Forms.Button butSearchYear;
        private System.Windows.Forms.Button butPrintAllMov;
        private System.Windows.Forms.ListBox listBoxPrintMoviesResults;
        private System.Windows.Forms.TextBox textBoxYearSearchInput;
        private System.Windows.Forms.TextBox textBoxDeleteByYearMovieInput;
        private System.Windows.Forms.TextBox textBoxInputMovieYear;
        private System.Windows.Forms.Label labelMovieInputYear;
        private System.Windows.Forms.Label labelMovieTitleInput;
        private System.Windows.Forms.TextBox textBoxMovieTitleInput;
        private System.Windows.Forms.TextBox textBoxMovieDirectorInput;
        private System.Windows.Forms.Label labelMovieDirectorInput;
        private System.Windows.Forms.Label labelSearchByYear;
        private System.Windows.Forms.Label labelDeleteByYear;
        private System.Windows.Forms.Label labelIAddYearError;
        private System.Windows.Forms.Label labelTitleInputError;
        private System.Windows.Forms.Label labelDirectorInputError;
        private System.Windows.Forms.Label labelDeleteMovieError;
        private System.Windows.Forms.Label labelSearchErrorInput;
    }
}

