using System;
using System.Collections.Generic;
using System.Threading;

namespace Dashboard_BindingToList {
    public class Data {
        public string SalesPerson { get; set; }
        public int Quantity { get; set; }

        public static List<Data> CreateData() {
            List<Data> data = new List<Data>();
            string[] salesPersons = { "Andrew Fuller", "Michael Suyama", "Robert King", "Nancy Davolio",
                "Margaret Peacock", "Laura Callahan", "Steven Buchanan", "Janet Leverling" };

            for (int i = 0; i < 100; i++) {
                Data record = new Data();
                int seed = (int)DateTime.Now.Ticks & 0x0000FFFF;
                record.SalesPerson = salesPersons[new Random(seed).Next(0, salesPersons.Length)];
                record.Quantity = new Random(seed).Next(0, 100);
                data.Add(record);
                Thread.Sleep(3);
            }
            return data;
        }
    }
}
