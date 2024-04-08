namespace lab4
{
    public partial class Form1 : Form
    {
        List<Transport> list = new List<Transport>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.list.Clear();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.list.Add(new Auto
                        {
                            type = TransportType.Автомобиль,
                            carType = (CarTypes)rnd.Next(Enum.GetValues(typeof(CarTypes)).Length),
                            EngineCapacity = rnd.Next(101),
                            DoorsCount = rnd.Next(3, 6)
                        });
                        break;
                    case 1:
                        this.list.Add(new Plane
                        {
                            type = TransportType.Самолет,
                            engineType = (EngineTypes)rnd.Next(Enum.GetValues(typeof(EngineTypes)).Length),
                            FlightHigh = rnd.NextDouble() * 10000
                        });
                        break;
                    case 2:
                        this.list.Add(new Bike
                        {
                            type = TransportType.Велосипед,
                            bikeType = (BikeTypes)rnd.Next(Enum.GetValues(typeof(BikeTypes)).Length),
                            radius = rnd.Next(10, 31)
                        });
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int bikesCount = 0;
            int planesCount = 0;
            int autosCount = 0;

            foreach (var transport in this.list)
            {
                switch (transport.type)
                {
                    case TransportType.Велосипед:
                        bikesCount++;
                        break;
                    case TransportType.Автомобиль:
                        autosCount++;
                        break;
                    case TransportType.Самолет:
                        planesCount++;
                        break;
                }
            }

            txtInfo.Text = "Велик\tАвто\tСамолет";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", bikesCount, autosCount, planesCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.list.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            var transport = this.list[0];
            this.list.RemoveAt(0);

            txtOut.Text = transport.GetInfo();

            ShowInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}