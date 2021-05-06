
namespace Шоколадка2
{
    partial class gameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.gameView = new System.Windows.Forms.DataGridView();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.btnPlayerAndComputer = new System.Windows.Forms.Button();
            this.aboutMe = new System.Windows.Forms.Button();
            this.gameRules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameView)).BeginInit();
            this.SuspendLayout();
            // 
            // gameView
            // 
            this.gameView.AllowUserToAddRows = false;
            this.gameView.AllowUserToDeleteRows = false;
            this.gameView.AllowUserToResizeColumns = false;
            this.gameView.AllowUserToResizeRows = false;
            this.gameView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gameView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameView.ColumnHeadersVisible = false;
            this.gameView.Location = new System.Drawing.Point(12, 12);
            this.gameView.Name = "gameView";
            this.gameView.ReadOnly = true;
            this.gameView.RowHeadersVisible = false;
            this.gameView.RowHeadersWidth = 30;
            this.gameView.Size = new System.Drawing.Size(175, 178);
            this.gameView.TabIndex = 0;
            this.gameView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameView_CellClick);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.BackColor = System.Drawing.Color.Teal;
            this.btnTwoPlayer.Location = new System.Drawing.Point(193, 12);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(107, 40);
            this.btnTwoPlayer.TabIndex = 1;
            this.btnTwoPlayer.Text = "Игрок против игрока";
            this.btnTwoPlayer.UseVisualStyleBackColor = false;
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
            // 
            // btnPlayerAndComputer
            // 
            this.btnPlayerAndComputer.BackColor = System.Drawing.Color.BlueViolet;
            this.btnPlayerAndComputer.Location = new System.Drawing.Point(193, 58);
            this.btnPlayerAndComputer.Name = "btnPlayerAndComputer";
            this.btnPlayerAndComputer.Size = new System.Drawing.Size(107, 40);
            this.btnPlayerAndComputer.TabIndex = 2;
            this.btnPlayerAndComputer.Text = "Игрок против Компьютера";
            this.btnPlayerAndComputer.UseVisualStyleBackColor = false;
            this.btnPlayerAndComputer.Click += new System.EventHandler(this.btnPlayerAndComputer_Click);
            // 
            // aboutMe
            // 
            this.aboutMe.Location = new System.Drawing.Point(193, 150);
            this.aboutMe.Name = "aboutMe";
            this.aboutMe.Size = new System.Drawing.Size(107, 40);
            this.aboutMe.TabIndex = 3;
            this.aboutMe.Text = "Об Авторе";
            this.aboutMe.UseVisualStyleBackColor = true;
            this.aboutMe.Click += new System.EventHandler(this.aboutMe_Click);
            // 
            // gameRules
            // 
            this.gameRules.BackColor = System.Drawing.Color.LightGreen;
            this.gameRules.Location = new System.Drawing.Point(193, 104);
            this.gameRules.Name = "gameRules";
            this.gameRules.Size = new System.Drawing.Size(107, 40);
            this.gameRules.TabIndex = 4;
            this.gameRules.Text = "Правила игры";
            this.gameRules.UseVisualStyleBackColor = false;
            this.gameRules.Click += new System.EventHandler(this.gameRules_Click);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(331, 227);
            this.Controls.Add(this.gameRules);
            this.Controls.Add(this.aboutMe);
            this.Controls.Add(this.btnPlayerAndComputer);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.gameView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра Шоколадка";
            ((System.ComponentModel.ISupportInitialize)(this.gameView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gameView;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Button btnPlayerAndComputer;
        private System.Windows.Forms.Button aboutMe;
        private System.Windows.Forms.Button gameRules;
    }
}

