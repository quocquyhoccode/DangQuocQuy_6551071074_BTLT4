namespace BTb3
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void mnuIt_TileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuIt_TileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuIt_Cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuIt_Example1_Click(object sender, EventArgs e)
        {
            Example1 frm_example1 = new Example1();
            frm_example1.MdiParent = this;
            frm_example1.Show();
        }

        private void mnuIt_Example2_Click(object sender, EventArgs e)
        {
            Example2 frm_example2 = new Example2();
            frm_example2.MdiParent = this;
            frm_example2.Show();
        }

        private void mnuIt_Example3_Click(object sender, EventArgs e)
        {
            Example3 frm_example3 = new Example3();
            frm_example3.MdiParent = this;
            frm_example3.Show();
        }

      
    }
}
