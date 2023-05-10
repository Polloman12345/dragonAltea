namespace asociacionDragon
{
    partial class GameList
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
            button1 = new Button();
            listView1 = new ListView();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1327, 600);
            button1.Name = "button1";
            button1.Size = new Size(99, 32);
            button1.TabIndex = 1;
            button1.Text = "Añadir juego";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(1414, 582);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button2
            // 
            button2.Location = new Point(12, 606);
            button2.Name = "button2";
            button2.Size = new Size(175, 26);
            button2.TabIndex = 2;
            button2.Text = "Eliminar seleccionados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 644);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "GameList";
            Text = "Lista de juegos";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListView listView1;
        private Button button2;
    }
}