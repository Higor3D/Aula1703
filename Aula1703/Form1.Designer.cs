
namespace Aula1703
{
    partial class FormPrincipal
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
            this.labelPergunta = new System.Windows.Forms.Label();
            this.buttonNao = new System.Windows.Forms.Button();
            this.buttonSim = new System.Windows.Forms.Button();
            this.buttonCor = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPergunta
            // 
            this.labelPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPergunta.Location = new System.Drawing.Point(206, -11);
            this.labelPergunta.Name = "labelPergunta";
            this.labelPergunta.Size = new System.Drawing.Size(440, 464);
            this.labelPergunta.TabIndex = 0;
            this.labelPergunta.Text = "Gostaria do conceito Atendido para esta Unidade Curricular (UC10)?";
            // 
            // buttonNao
            // 
            this.buttonNao.BackColor = System.Drawing.Color.Salmon;
            this.buttonNao.Location = new System.Drawing.Point(71, 475);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(125, 57);
            this.buttonNao.TabIndex = 1;
            this.buttonNao.Text = "NÃO";
            this.buttonNao.UseVisualStyleBackColor = false;
            this.buttonNao.Click += new System.EventHandler(this.buttonNao_Click);
            this.buttonNao.Enter += new System.EventHandler(this.buttonNao_Enter);
            this.buttonNao.MouseEnter += new System.EventHandler(this.buttonNao_MouseEnter);
            this.buttonNao.MouseLeave += new System.EventHandler(this.buttonNao_MouseLeave);
            // 
            // buttonSim
            // 
            this.buttonSim.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSim.Location = new System.Drawing.Point(534, 475);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(125, 58);
            this.buttonSim.TabIndex = 2;
            this.buttonSim.Text = "SIM";
            this.buttonSim.UseVisualStyleBackColor = false;
            this.buttonSim.Click += new System.EventHandler(this.buttonSim_Click);
            this.buttonSim.MouseEnter += new System.EventHandler(this.buttonSim_MouseEnter);
            // 
            // buttonCor
            // 
            this.buttonCor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCor.Location = new System.Drawing.Point(304, 547);
            this.buttonCor.Name = "buttonCor";
            this.buttonCor.Size = new System.Drawing.Size(119, 52);
            this.buttonCor.TabIndex = 3;
            this.buttonCor.Text = "Cor";
            this.buttonCor.UseVisualStyleBackColor = false;
            this.buttonCor.Click += new System.EventHandler(this.buttonCor_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 626);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(274, 24);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Higor Gomes Dias Rocha";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonCor);
            this.Controls.Add(this.buttonSim);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.labelPergunta);
            this.Name = "FormPrincipal";
            this.Text = "O Programa Aprovado?";
            this.MouseEnter += new System.EventHandler(this.FormPrincipal_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormPrincipal_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPergunta;
        private System.Windows.Forms.Button buttonNao;
        private System.Windows.Forms.Button buttonSim;
        private System.Windows.Forms.Button buttonCor;
        private System.Windows.Forms.Label labelNome;
    }
}

