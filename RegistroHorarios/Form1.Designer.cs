namespace RegistroHorarios
{
    partial class Form1
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
            this.Inicio = new System.Windows.Forms.Label();
            this.Fim = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.InputData = new System.Windows.Forms.TextBox();
            this.InputInicio = new System.Windows.Forms.TextBox();
            this.InputFim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.Location = new System.Drawing.Point(322, 167);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(36, 15);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Inicio";
            this.Inicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fim
            // 
            this.Fim.AutoSize = true;
            this.Fim.Location = new System.Drawing.Point(321, 220);
            this.Fim.Name = "Fim";
            this.Fim.Size = new System.Drawing.Size(27, 15);
            this.Fim.TabIndex = 1;
            this.Fim.Text = "Fim";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(321, 95);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(31, 15);
            this.Data.TabIndex = 2;
            this.Data.Text = "Data";
            // 
            // InputData
            // 
            this.InputData.Location = new System.Drawing.Point(321, 123);
            this.InputData.Name = "InputData";
            this.InputData.Size = new System.Drawing.Size(100, 23);
            this.InputData.TabIndex = 3;
            // 
            // InputInicio
            // 
            this.InputInicio.Location = new System.Drawing.Point(322, 194);
            this.InputInicio.Name = "InputInicio";
            this.InputInicio.Size = new System.Drawing.Size(100, 23);
            this.InputInicio.TabIndex = 4;
            // 
            // InputFim
            // 
            this.InputFim.Location = new System.Drawing.Point(322, 238);
            this.InputFim.Name = "InputFim";
            this.InputFim.Size = new System.Drawing.Size(100, 23);
            this.InputFim.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputFim);
            this.Controls.Add(this.InputInicio);
            this.Controls.Add(this.InputData);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Fim);
            this.Controls.Add(this.Inicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Inicio;
        private Label Fim;
        private Label Data;
        private TextBox InputData;
        private TextBox InputInicio;
        private TextBox InputFim;
    }
}