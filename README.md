# Tic-Tac-Toe

Играта X-O (TicTacToe) може да се игра со еден играч кој се натпреварува против компјутерот или со двајца играчи кои се натпреваруваат помеѓу себе.

Правила на играње
1. Може да се игра со најмногу 2 играчи.
2. Секој играч има свој симбол (кој може да биде X или O) и ги поставуваат наизменично на 3х3 матрица од полиња.
3. Играчот не може да го постави својот симбол на поле ако тоа е претходно одбрано од него или неговиот противник.
4. Во случај еден од играчите да успее да постави 3 симболи во иста редица, колона или дијагонала, тогаш тој победува, а во спротивно е нерешено.

<p align=center><img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/start%20page.png" /></p>
При стартување на играта, се бара да се внесе дали играчот сака да игра со Х или со О (дали сака да го има првиот потег) и дали сака да игра против човек или против компјутер. Исто така се бара и внес на имиња на играчите, кое е опционално, а доколку е избран компјутер како противник, тогаш неговото име е _Computer_ и тоа не може да се промени.
<p align=center>
  <img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/start%20page%20against%20computer.png">
  <img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/start%20page%20against%20player.png">
</p>

<p align=center><img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/game%20in%20duration.png" /></p> 
<p align=center>Тек на играта</p>

Апликацијата ги чува резултатите од играта, се додека не се искучи апликацијата, и води евиденција кој играч колку пати победил и колку пати завршило нерешено.
<p align=center><img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/score.png" /></p> 

Ако еден од играчите победи, се појавува порака која му честита на победникот, а во случај на нерешено се појавува соодветна порака.
<p align=center>
  <img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/victory.png">
  <img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/tie.png">
</p>

На горниот раб на апликацијата има мани од каде што може да се почне нова игра, да се затвори апликацијата или да се побара помош во врска со играта.
<p align=center>
  <img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/new game and exit.png">
  <img src="https://github.com/MihailGjorgjiev/Tic-Tac-Toe/blob/master/TicTacToe/images/help.png">
</p>

На формата се поставени 9 копчиња во 3х3 матрица. Кога еден од играчите ќе кликне на слободно поле се повикува функцијата `btn_click` која одредува дали за запише Х или О на тоа поле во зависност кој играч е на ред и ја повикува функцијата `checkIfFinished` за да провери дали некој играч победил или играта завршила нерешено. Во случај еден од играчите да биде компјутерот, тогаш се повикува функцијата `computer_move` која го одлучува најдобриот потег за компјутерот. При победа на еден од натпреварувачите се испишува порака за честитки за победникот или во случај на нерешено се испишува соодветна порака.

        private void computer_move()
        {
            Button next = null;
            next = win_or_block(isX ? "O" : "X");

            if (next == null)
            {
                next = win_or_block(isX ? "X" : "O");
                if (next == null)
                {
                    next = corner(isX ? "O" : "X");

                    if (next == null)
                    {
                        next = anything_available();
                    }
                }
            }
            if (next != null)
                next.PerformClick();
        }
Функцијата `computer move` прво ја повикува функцијата `win_or_block` со параметар од тип string со вредност знакот на компјутерот со цел да најде поле кое ќе му овозможи победа. Ако нема такво поле, тогаш се повикува истата функција повторно, само што вредноста на параметарот е знакот на играчот, со цел да се осигура дека играчот нема да победи во наредноит потег. Ако повторно нема такво поле, тогаш се повикува функцијата `corner` која го бара најпогодното поле во центарот или во аглите. Ако сѐ уште нема погодно поле, тогаш се повикува `anything_available` која го враќа првото слободно поле. Ако `anything_available` врати null вредност тоа значи дека играта заршила.
