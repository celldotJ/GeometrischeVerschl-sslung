namespace GeometrischeVerschlüsslung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string input = inputTxtBx.Text;
            input = input.Replace(" ", "").ToUpper();
            string result = Encrypt(input);

            resultTxtBx.Text = result;
        }

        private static string Encrypt(string input)
        {
            int columns;
            int rows;

            columns = (int)Math.Ceiling(Math.Sqrt(input.Length));
            rows = (int)Math.Ceiling((decimal)input.Length / columns);

            List<char[]> Grid = CreateGrid(input, columns, rows);

            string result = GetEncryptedValueFromGrid(columns, Grid);
            return result;
        }

        /// <summary>
        /// Creates the Grid used for encryption.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="columns"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        private static List<char[]> CreateGrid(string input, int columns, int rows)
        {
            List<char[]> Grid = new List<char[]> { };
            char[] Chars = input.ToCharArray();
            int progress = 0;
            for (int i = 0; i < rows; i++)
            {
                char[] row = FillGridRow(input, columns, Chars, ref progress);
                Grid.Add(row);
            }

            return Grid;
        }

        /// <summary>
        /// Fills a <see cref="char[]"/> with parts of the input string 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="columns"></param>
        /// <param name="Chars"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        private static char[] FillGridRow(string input, int columns, char[] Chars, ref int progress)
        {
            char[] row = new char[columns];
            for (int z = 0; z < columns; z++)
            {
                if (progress > input.Length - 1)
                {
                    break;
                }
                row[z] = Chars[progress];
                progress++;
            }
            if (row.Contains('\0'))
            {
                for (int t = 0; t < row.Length; t++)
                {
                    if (row[t] == '\0')
                    {
                        row[t] = 'X';
                    }
                }
            }

            return row;
        }
        /// <summary>
        /// Reads the encrypted version of the input from the <paramref name="Grid"/>.
        /// </summary>
        /// <param name="columns">The amount of "columns" in <paramref name="Grid"/></param>
        /// <param name="Grid">The "Grid" that contains the input that is to be encrypted</param>
        /// <returns>The encrypted input.</returns>
        private static string GetEncryptedValueFromGrid(int columns, List<char[]> Grid)
        {
            string result = string.Empty;
            Grid.Reverse();
            for (int i = columns - 1; i > -1; i--)
            {
                Grid.ForEach(x => result += x[i].ToString());
            }

            return result;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string input = inputTxtBx.Text;
            string result = Encrypt(input);
            resultTxtBx.Text = result;
        }
    }
}