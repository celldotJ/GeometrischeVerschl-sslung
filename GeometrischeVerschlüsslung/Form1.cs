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

        /// <summary>
        /// Encrypts the <paramref name="input"/> using the Geometrische Verschlüsslung
        /// </summary>
        /// <param name="input">The value to be ecrypted.</param>
        /// <returns>The encrypted <paramref name="input"/> </returns>
        private static string Encrypt(string input)
        {
            int columns;
            int rows;

            columns = (int)Math.Ceiling(Math.Sqrt(input.Length));
            rows = (int)Math.Ceiling((decimal)input.Length / columns);

            List<char[]> grid = CreateGrid(input, columns, rows);

            return GetEncryptedValueFromGrid(columns, grid);
        }

        /// <summary>
        /// Creates the Grid and fills it with the word that is to be encrypted.
        /// </summary>
        /// <param name="input">The value to be encrypted.</param>
        /// <param name="columns">The amount of columns needed for the Grid.</param>
        /// <param name="rows">The amount of rows needed for the Grid.</param>
        /// <returns> A grid with <paramref name="input"/> filled in.</returns>
        private static List<char[]> CreateGrid(string input, int columns, int rows)
        {
            List<char[]> Grid = new List<char[]> { };
            int progress = 0;
            for (int i = 0; i < rows; i++)
            {
                char[] row = FillGridRow(input, columns, ref progress);
                Grid.Add(row);
            }

            return Grid;
        }

        /// <summary>
        /// Fills a <see cref="char[]"/> with parts of the input string 
        /// </summary>
        /// <param name="input">The value to be encrypted</param>
        /// <param name="columns">The amount of columns in the grid</param>
        /// <param name="progress">The progress in of the "fill"</param>
        /// <returns>An array that represents a row in the grid</returns>
        private static char[] FillGridRow(string input, int columns, ref int progress)
        {
            char[] row = new char[columns];
            char[] chars = input.ToCharArray();
            for (int z = 0; z < columns; z++)
            {
                if (progress > input.Length - 1)
                {
                    break;
                }
                row[z] = chars[progress];
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