using RCLibrary;
using RCLibrary.Entities;
using System.Data;


namespace RCInterface
{
    //ToDo #5.4.1 Форма для добавления нового автомобиля +
    public partial class Add_Auto : Form
    {
        private Manager manager = new Manager();
        public Add_Auto()
        {
            InitializeComponent();

            List<classAuto> enumValues_1 = Enum.GetValues(typeof(classAuto)).Cast<classAuto>().ToList();
            for (int i = 0; i < enumValues_1.Count; i++)
                cb_class.Items.Add(enumValues_1[i]);

            List<gearboxType> enumValues_2 = Enum.GetValues(typeof(gearboxType)).Cast<gearboxType>().ToList();
            for (int i = 0; i < enumValues_2.Count; i++)
                cb_type.Items.Add(enumValues_2[i]);

            List<colorAuto> enumValues_3 = Enum.GetValues(typeof(colorAuto)).Cast<colorAuto>().ToList();
            for (int i = 0; i < enumValues_3.Count; i++)
                cb_color.Items.Add(enumValues_3[i]);
        }

        private void btn_add_Admin_Click(object sender, EventArgs e)
        {
            try
            {
                Auto auto = new Auto();
                auto.Brand = tb_brand.Text.Trim();
                auto.Model = tb_model.Text.Trim();
                if (cb_class.SelectedIndex == -1)
                    throw new ArgumentException("Потрібно вказати клас автомобіля.");
                auto.Aclass = (classAuto)cb_class.SelectedItem;

                if (cb_type.SelectedIndex == -1)
                    throw new ArgumentException("Потрібно вказати тип КПП автомобіля.");
                auto.Atype = (gearboxType)cb_type.SelectedItem;

                if (cb_color.SelectedIndex == -1)
                    throw new ArgumentException("Необхідно вказати колір автомобіля.");
                auto.Acolor = (colorAuto)cb_color.SelectedItem;

                if (string.IsNullOrWhiteSpace(mtb_price.Text))
                {
                    throw new ArgumentException("Необхідно зазначити ціну оренди автомобіля.");
                }
                else
                    auto.DailyPrice = Convert.ToInt16(mtb_price.Text);

                // Добавляем автомобиль 
                manager.AddCar(auto);

                DialogResult dialogResult = MessageBox.Show("Автомобіль був доданий!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                    Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
