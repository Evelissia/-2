using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Шоколадка2
{
    public partial class gameForm : Form
    {        
        static int row = 8;
        static int column = 8;
       
        static bool isComputer = false;
        static bool isComputerFirstMove = true;
        static int computerI;
        static int computerJ;

        public gameForm()
        {
            InitializeComponent();        
            gameView.RowCount = row;
            gameView.ColumnCount = column;
            // Закрашиваем отравленную дольку
            gameView.Rows[row - 1].Cells[0].Style.BackColor = Color.Red;
        }

        private static void ComputerMove (object gameView)
        {
            Application.DoEvents();
            Thread.Sleep(300); // ждем 300 мс
            int computerX = 0;
            int computerY = 0;

            // если ход компьютера и игрок ещё не нажал на ячейку,
            // следующую по диагонали от ядовитой, то на нее нажимает компьютер
            if (isComputerFirstMove && computerI != row - 2 && computerJ != 1)
            {
                computerX = 1;
                computerY = row - 2;
                isComputerFirstMove = false;
            }
            else if (isComputerFirstMove && computerI == 5 || computerI == 4 || computerI == 3 || computerI == 2 || computerI == 1 || computerI == 0 && computerJ == 1)
            {
                computerX = 1;
                computerY = row - 2;
                isComputerFirstMove = false;

                // Закрашивание зеркальных ячеек
                if (((DataGridView)gameView)[computerX, computerY].Style.BackColor == Color.Pink)
                {
                    computerX = column - computerI - 1;
                    computerY = row - computerJ - 1;

                    if (((DataGridView)gameView)[computerX, computerY].Style.BackColor == Color.Pink)
                    {
                        if (computerX == column - 1)
                            computerX++;
                        else
                            computerY++;
                    }
                }
            }
            else if (isComputerFirstMove && computerI == 6 && computerJ == 7 || computerJ == 6 || computerJ == 5 || computerJ == 4 || computerJ == 3 || computerJ == 2)
            {
                computerX = 1;
                computerY = row - 2;
                isComputerFirstMove = false;

                // Закрашивание заркальных ячеек
                if (((DataGridView)gameView)[computerX, computerY].Style.BackColor == Color.Pink)
                {
                    computerX = column - computerI-1 ;
                    computerY = row - computerJ-1 ;

                    if (((DataGridView)gameView)[computerX, computerY].Style.BackColor == Color.Pink)
                    {
                        if (computerX == column - 1)
                            computerX++;
                        else
                            computerY++;
                    }
                }
            }

            // если ход компьютера и игрок нажал на кнопку [6,0] то компьютер нажимает на [7,1]
            else if (isComputerFirstMove && computerI == 6 && computerJ == 0)
            {
                computerX = 1;
                computerY = 7;
                isComputerFirstMove = false;
            }
            else if (isComputerFirstMove && computerI == 7 && computerJ == 1)
            {
                computerX = 0;
                computerY = row - 2;
                isComputerFirstMove = false;
            }
            // если вторая по диагонали от красной ячейка занята, но сейчас ход компьютера
            // выбираем левую верхнюю ячейку
            else if (isComputerFirstMove)
            {
                computerX = 0;
                computerY = 0;
                isComputerFirstMove = false;
            }                       
            // иначе выбираем такую ячейку, которая зеркальна нажатой ячейке
            else
            {
                computerX = column - computerI - 1;
                computerY = row - computerJ - 1;

                // если зеркальная ячейка занята - занимаем следующую
                if (((DataGridView)gameView)[computerX, computerY].Style.BackColor == Color.Pink)
                {
                    if (computerX == column - 1)
                        computerX++;
                    else
                        computerY++;
                }
                // если компьютер нажал отравленную ячейку - выводим сообщение
                if (computerY == 7 && computerX == 0)
                {
                    MessageBox.Show("Вы победили!");
                    isComputerFirstMove = false;
                    isComputer = false;                    
                }
          
                isComputerFirstMove = false;
            }
            // проверка на выход за пределы
            if (computerX == column || computerY == row)
                return;
            for (int y = 0; y <= computerY; y++)
                for (int x = computerX; x < column; x++)
                    ((DataGridView)gameView)[x, y].Style.BackColor = Color.Pink;                      
        }

        private void gameView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex, j = e.ColumnIndex;

            for (int y = 0; y <= i; y++)
                for (int x = j; x < column; x++)
                    // Закрашиваем все ячейки находящиеся выше и правее активной
                    gameView[x, y].Style.BackColor = Color.Pink;

            if (isComputer)
            {
                // если играем с компьютером
                // запоминаем куда нажал игрок
                computerI = i;
                computerJ = j;
                // создаем новый поток для реалистичности
                Thread computerMove = new Thread(ComputerMove);
                computerMove.Start(gameView);
            }

            Win();
        }

        private void Win()
        {
            // Задаем переменную, которая будет хранить активную ячейку
            DataGridViewCell poison = gameView.CurrentCell;

            // Присваиваем переменной poison конкретную ячейку и при ее активации выводим сообщение
            if (poison == gameView.Rows[row - 1].Cells[0])
            {
                MessageBox.Show("Вы проиграли!");
            }           
        }

        // Обработчик кнопки Игрок против Игрока
        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    // Создаем новую игру и перекрашиваем ячейки обратно в белый
                    gameView[i, j].Style.BackColor = Color.Empty;

            // Закрашиваем отравленную дольку
            gameView.Rows[row - 1].Cells[0].Style.BackColor = Color.Red;

            isComputer = false;
        }
        // Обработчик кнопки Игрок против компьютера
        private void btnPlayerAndComputer_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < row; x++)
                for (int y = 0; y < column; y++)
                    // Создаем новую игру и перекрашиваем ячейки обратно в белый
                    gameView[x, y].Style.BackColor = Color.Empty;

            // Закрашиваем отравленную дольку
            gameView.Rows[row - 1].Cells[0].Style.BackColor = Color.Red;

            isComputer = true;
            isComputerFirstMove = true;
        }

        private void gameRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поле игры «Шоколадка» — прямоугольная плитка шоколада; " +
                            "двое игроков по очереди выбирают одну дольку и съедают вместе со всеми дольками выше и правее её. " +
                            "Проигрывает тот игрок, который съедает «отравленную» левую нижнюю дольку.", "Правила игры");
        }

        private void aboutMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Половцева Виктория Владимировна\n" +
                            "ОмГТУ. Группа: ПИН-202\n" +
                            "Факультет информационных технологий и компьютерных систем\n" +
                            "Кафедра Автоматизированные системы обработки информации и управления", "Об Авторе");
        }
    }
}

    
