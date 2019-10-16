namespace Laberint2D
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.button_start = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.Box_sound = new System.Windows.Forms.CheckBox();
            this.buttonlevel2 = new System.Windows.Forms.Button();
            this.AVTOR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Transparent;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_start.Location = new System.Drawing.Point(12, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(134, 55);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Уровень 1";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(12, 394);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(134, 55);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Box_sound
            // 
            this.Box_sound.AutoSize = true;
            this.Box_sound.BackColor = System.Drawing.Color.Transparent;
            this.Box_sound.Checked = true;
            this.Box_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box_sound.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_sound.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Box_sound.Location = new System.Drawing.Point(680, 410);
            this.Box_sound.Name = "Box_sound";
            this.Box_sound.Size = new System.Drawing.Size(98, 26);
            this.Box_sound.TabIndex = 2;
            this.Box_sound.Text = "Звук: Вкл";
            this.Box_sound.UseVisualStyleBackColor = false;
            this.Box_sound.CheckedChanged += new System.EventHandler(this.Box_sound_CheckedChanged);
            // 
            // buttonlevel2
            // 
            this.buttonlevel2.BackColor = System.Drawing.Color.Transparent;
            this.buttonlevel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlevel2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlevel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonlevel2.Location = new System.Drawing.Point(168, 12);
            this.buttonlevel2.Name = "buttonlevel2";
            this.buttonlevel2.Size = new System.Drawing.Size(134, 55);
            this.buttonlevel2.TabIndex = 3;
            this.buttonlevel2.Text = "Уровень 2";
            this.buttonlevel2.UseVisualStyleBackColor = false;
            this.buttonlevel2.Click += new System.EventHandler(this.buttonlevel2_Click);
            // 
            // AVTOR
            // 
            this.AVTOR.BackColor = System.Drawing.Color.Transparent;
            this.AVTOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AVTOR.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVTOR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AVTOR.Location = new System.Drawing.Point(12, 73);
            this.AVTOR.Name = "AVTOR";
            this.AVTOR.Size = new System.Drawing.Size(134, 55);
            this.AVTOR.TabIndex = 4;
            this.AVTOR.Text = "Автор";
            this.AVTOR.UseVisualStyleBackColor = false;
            this.AVTOR.Click += new System.EventHandler(this.AVTOR_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(790, 461);
            this.Controls.Add(this.AVTOR);
            this.Controls.Add(this.buttonlevel2);
            this.Controls.Add(this.Box_sound);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laberint 2D";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.CheckBox Box_sound;
        private System.Windows.Forms.Button buttonlevel2;
        private System.Windows.Forms.Button AVTOR;
    }
}

