using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collectionAndExceptionHandling
{
    public partial class Form1 : Form
    {
        BestMovieDataBase movieDateBase = new BestMovieDataBase();
        MovieInput InputWorker = new MovieInput();
        MoviePrinter OutputWorker = new MoviePrinter();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void butAddMovie_Click(object sender, EventArgs e)
        {


            if((InputWorker.CheckYearInput(textBoxInputMovieYear, labelIAddYearError)) &&

            (InputWorker.CheckStringInput(textBoxMovieTitleInput, labelTitleInputError)) &&

            (InputWorker.CheckStringInput(textBoxMovieDirectorInput, labelDirectorInputError))) {

            }

        }

        private void butDelMovie_Click(object sender, EventArgs e)
        {

        }

        private void butSearchYear_Click(object sender, EventArgs e)
        {

        }

        private void butPrintAllMov_Click(object sender, EventArgs e)
        {
            OutputWorker.printAllMovies(movieDateBase.MovieTable, listBoxPrintMoviesResults);
        }


    }
}
