namespace IMDBProject.UI
{
    partial class MoviePage
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
            this.gbxMovies = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxKnowledgeMovie = new System.Windows.Forms.GroupBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblProductıonDate = new System.Windows.Forms.Label();
            this.lblMovieReview = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxKnowledgeMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMovies
            // 
            this.gbxMovies.Controls.Add(this.dataGridView1);
            this.gbxMovies.Location = new System.Drawing.Point(12, 12);
            this.gbxMovies.Name = "gbxMovies";
            this.gbxMovies.Size = new System.Drawing.Size(828, 178);
            this.gbxMovies.TabIndex = 0;
            this.gbxMovies.TabStop = false;
            this.gbxMovies.Text = "List Of Moveis";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 312);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gbxKnowledgeMovie
            // 
            this.gbxKnowledgeMovie.Controls.Add(this.label4);
            this.gbxKnowledgeMovie.Controls.Add(this.label3);
            this.gbxKnowledgeMovie.Controls.Add(this.label2);
            this.gbxKnowledgeMovie.Controls.Add(this.label1);
            this.gbxKnowledgeMovie.Controls.Add(this.lblMovieReview);
            this.gbxKnowledgeMovie.Controls.Add(this.lblProductıonDate);
            this.gbxKnowledgeMovie.Controls.Add(this.lblContent);
            this.gbxKnowledgeMovie.Controls.Add(this.lblMovieName);
            this.gbxKnowledgeMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKnowledgeMovie.Location = new System.Drawing.Point(387, 214);
            this.gbxKnowledgeMovie.Name = "gbxKnowledgeMovie";
            this.gbxKnowledgeMovie.Size = new System.Drawing.Size(447, 312);
            this.gbxKnowledgeMovie.TabIndex = 2;
            this.gbxKnowledgeMovie.TabStop = false;
            this.gbxKnowledgeMovie.Text = "Knowledge Of Movie";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(139, 36);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(58, 16);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "----------";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(139, 82);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(58, 16);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "----------";
            // 
            // lblProductıonDate
            // 
            this.lblProductıonDate.AutoSize = true;
            this.lblProductıonDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductıonDate.Location = new System.Drawing.Point(139, 130);
            this.lblProductıonDate.Name = "lblProductıonDate";
            this.lblProductıonDate.Size = new System.Drawing.Size(58, 16);
            this.lblProductıonDate.TabIndex = 2;
            this.lblProductıonDate.Text = "----------";
            // 
            // lblMovieReview
            // 
            this.lblMovieReview.AutoSize = true;
            this.lblMovieReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieReview.Location = new System.Drawing.Point(139, 180);
            this.lblMovieReview.Name = "lblMovieReview";
            this.lblMovieReview.Size = new System.Drawing.Size(58, 16);
            this.lblMovieReview.TabIndex = 3;
            this.lblMovieReview.Text = "----------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movie Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Production Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Movie Review";
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 558);
            this.Controls.Add(this.gbxKnowledgeMovie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxMovies);
            this.Name = "MoviePage";
            this.Text = "MoviePage";
            this.gbxMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxKnowledgeMovie.ResumeLayout(false);
            this.gbxKnowledgeMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMovies;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxKnowledgeMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMovieReview;
        private System.Windows.Forms.Label lblProductıonDate;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblMovieName;
    }
}