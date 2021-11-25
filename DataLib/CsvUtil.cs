namespace Finance
{
    public class CsvUtil
    {
        private readonly string csvPath;
        private List<string> csvData;
        private Dictionary<string, int> colHeaders = new Dictionary<string, int>();

        public CsvUtil(string csvPath)
        {
            this.csvPath = csvPath;
            this.csvData = new List<string>(File.ReadLines(this.csvPath));
        }

        public void loadData()
        {
            throw new NotImplementedException("Not done yet");
        }

        public void readColHeaders()
        {
            List<List<string>> columns = new List<List<string>>();

            List<string> col1 = new List<string>();
            List<string> col2 = new List<string>();
            List<string> col3 = new List<string>();
            List<string> col4 = new List<string>();
            List<string> col5 = new List<string>();

            columns.Add(col1);
            columns.Add(col2);
            columns.Add(col3);
            columns.Add(col4);
            columns.Add(col5);
            
            List<string> colNames = new List<string>();
            Dictionary<string, int> columnMap = new Dictionary<string, int>();


            foreach(string columnName in this.csvData.First().Split(','))
            {
                colNames.Add(columnName);
            }
            
            foreach(string name in colNames)
            {
                Console.WriteLine(name);
            }

            for(int i = 0; i < colNames.Count; i++)
            {
                columnMap.Add(colNames[i], i);
            }

            Console.WriteLine(columnMap["id"]);
            Console.WriteLine(columnMap["receiptTotal"]);



            // TODO: Load column data into arrays then store in array of arrays 
            // in order to access each inner array by column alias built in this function
            foreach(string row in csvData)
            {
                string[] data = row.Split(',');
                col1.Add(data[0]);
                col2.Add(data[1]);
                col3.Add(data[2]);
                col4.Add(data[3]);
                col5.Add(data[4]);

            }

            // TODO: change code so that below syntax can be run as columns["id"] instead of below

            Console.WriteLine(columns[columnMap["id"]]);
            foreach(var value in columns[columnMap["id"]])
            {
                Console.WriteLine(value);
            }





        }
    }
}