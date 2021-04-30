
namespace Practice_00
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.number_view1 = new Sunny.UI.UIButton();
            this.number_view6 = new Sunny.UI.UIButton();
            this.number_view5 = new Sunny.UI.UIButton();
            this.number_view4 = new Sunny.UI.UIButton();
            this.number_view3 = new Sunny.UI.UIButton();
            this.number_view2 = new Sunny.UI.UIButton();
            this.viewbutton = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // number_view1
            // 
            this.number_view1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number_view1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.number_view1.Location = new System.Drawing.Point(90, 67);
            this.number_view1.MinimumSize = new System.Drawing.Size(1, 1);
            this.number_view1.Name = "number_view1";
            this.number_view1.Radius = 100;
            this.number_view1.Size = new System.Drawing.Size(100, 100);
            this.number_view1.TabIndex = 4;
            this.number_view1.Text = "uiButton111";
            // 
            // number_view6
            // 
            this.number_view6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number_view6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.number_view6.Location = new System.Drawing.Point(620, 67);
            this.number_view6.MinimumSize = new System.Drawing.Size(1, 1);
            this.number_view6.Name = "number_view6";
            this.number_view6.Radius = 100;
            this.number_view6.Size = new System.Drawing.Size(100, 100);
            this.number_view6.TabIndex = 5;
            this.number_view6.Text = "uiButton2";
            // 
            // number_view5
            // 
            this.number_view5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number_view5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.number_view5.Location = new System.Drawing.Point(514, 67);
            this.number_view5.MinimumSize = new System.Drawing.Size(1, 1);
            this.number_view5.Name = "number_view5";
            this.number_view5.Radius = 100;
            this.number_view5.Size = new System.Drawing.Size(100, 100);
            this.number_view5.TabIndex = 6;
            this.number_view5.Text = "uiButton3";
            // 
            // number_view4
            // 
            this.number_view4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number_view4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.number_view4.Location = new System.Drawing.Point(408, 67);
            this.number_view4.MinimumSize = new System.Drawing.Size(1, 1);
            this.number_view4.Name = "number_view4";
            this.number_view4.Radius = 100;
            this.number_view4.Size = new System.Drawing.Size(100, 100);
            this.number_view4.TabIndex = 7;
            this.number_view4.Text = "uiButton4";
            // 
            // number_view3
            // 
            this.number_view3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number_view3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.number_view3.Location = new System.Drawing.Point(302, 67);
            this.number_view3.MinimumSize = new System.Drawing.Size(1, 1);
            this.number_view3.Name = "number_view3";
            this.number_view3.Radius = 100;
            this.number_view3.Size = new System.Drawing.Size(100, 100);
            this.number_view3.TabIndex = 8;
            this.number_view3.Text = "uiButton5";
            // 
            // number_view2
            // 
            this.number_view2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number_view2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.number_view2.Location = new System.Drawing.Point(196, 67);
            this.number_view2.MinimumSize = new System.Drawing.Size(1, 1);
            this.number_view2.Name = "number_view2";
            this.number_view2.Radius = 100;
            this.number_view2.Size = new System.Drawing.Size(100, 100);
            this.number_view2.TabIndex = 9;
            this.number_view2.Text = "uiButton6";
            // 
            // viewbutton
            // 
            this.viewbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewbutton.Location = new System.Drawing.Point(341, 385);
            this.viewbutton.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(100, 35);
            this.viewbutton.TabIndex = 10;
            this.viewbutton.Text = "uiButton1";
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.number_view2);
            this.Controls.Add(this.number_view3);
            this.Controls.Add(this.number_view4);
            this.Controls.Add(this.number_view5);
            this.Controls.Add(this.number_view6);
            this.Controls.Add(this.number_view1);
            this.Name = "Form1";
            this.StyleCustomMode = true;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton number_view1;
        private Sunny.UI.UIButton number_view6;
        private Sunny.UI.UIButton number_view5;
        private Sunny.UI.UIButton number_view4;
        private Sunny.UI.UIButton number_view3;
        private Sunny.UI.UIButton number_view2;
        private Sunny.UI.UIButton viewbutton;
    }
}

