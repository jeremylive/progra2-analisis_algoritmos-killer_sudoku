
using System;
using System.Collections.Generic;

class KillerSudoku{
    //Matriz
    int[][] sudoku = new int[][];
    //1=*,2=/,3=%,4=+,5=-
    int[] operandos = new int[] { 1,2,3,4,5 };
    //figuras de tetris, ver imagen de ellas..
    int[] figuras = new int[] { 1,2,3,4,5 };
    //Figura actual a usar en cada iteracion, seria bueno llevar un registro..
    int[][] figura = new int[4][2];

    //Esquinas del sudoku donde no pueden ir x figuras
    public void casosIncoherentes(){
        //caso1: 

        //caso2:

        //caso3:

        //caso4:
    }

    //En cada ciclo se debe validar esta funcion para usar el backTracking
    public void dependencias(){
        //caso1:

        //caso2:

        //caso3:
    }

    //Crear Matriz con las figuras de tetris dentro, siguiendo las cordenadas y de forma aleatoria
    public void setFigurasTetris(){
        
    }

    //Creo la figura segun la coordenada que me dan, tipo de figura, posicion figura, el i y j donde comienza
    public int[][] getFigura(int tipo_figura, int posicion_figura, int fila, int columna){

        switch (tipo_figura)
        {
            case 1:
                if(posicion_figura = 1){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila+2, columna};
                        figura[i] = {fila+2, columna+1};
                        figura[i] = {fila+2, columna+2};
                        figura[i] = {fila+1, columna+1};                     
                    }
                }else if(posicion_figura = 2){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna};
                        figura[i] = {fila+1, columna};
                        figura[i] = {fila+2, columna};
                        figura[i] = {fila+1, columna+1};                     
                    }
                }else if(posicion_figura = 3){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna};
                        figura[i] = {fila, columna+1};
                        figura[i] = {fila, columna+2};
                        figura[i] = {fila+1, columna+1};                     
                    }
                }else if(posicion_figura = 4){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila+1, columna};
                        figura[i] = {fila, columna+1};
                        figura[i] = {fila+1, columna+1};
                        figura[i] = {fila+2, columna+1};                     
                    }
                }
                break;
            
            case 2:
                if(posicion_figura = 1){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna};
                        figura[i] = {fila+1, columna};
                        figura[i] = {fila+2, columna};
                        figura[i] = {fila+3, columna};                     
                    }
                }else if(posicion_figura = 2){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna};
                        figura[i] = {fila, columna+1};
                        figura[i] = {fila, columna+2};
                        figura[i] = {fila, columna+3};                     
                    }
                }
                break;

            case 3:
                if(posicion_figura = 1){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna};
                        figura[i] = {fila+1, columna};
                        figura[i] = {fila+2, columna};
                        figura[i] = {fila+2, columna+1};                     
                    }
                }else if(posicion_figura = 2){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila+1, columna};
                        figura[i] = {fila+1, columna+1};
                        figura[i] = {fila+1, columna+2};
                        figura[i] = {fila, columna+2};                     
                    }
                }else if(posicion_figura = 3){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna+1};
                        figura[i] = {fila, columna+2};
                        figura[i] = {fila+1, columna+2};
                        figura[i] = {fila+2, columna+2};                     
                    }
                }else if(posicion_figura = 4){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna};
                        figura[i] = {fila, columna+1};
                        figura[i] = {fila, columna+2};
                        figura[i] = {fila+1, columna};                     
                    }
                }
                break;

            case 4:
                if(posicion_figura = 1){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna};
                        figura[i] = {fila+1, columna};
                        figura[i] = {fila+1, columna+1};
                        figura[i] = {fila+2, columna+1};                     
                    }
                }else if(posicion_figura = 2){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila+1, columna};
                        figura[i] = {fila+1, columna+1};
                        figura[i] = {fila, columna+1};
                        figura[i] = {fila, columna+2};                     
                    }
                }
                break;

            case 5:
                if(posicion_figura = 1){
                    for (int i = 0; i < 4; i++)
                    {
                        figura[i] = {fila, columna};
                        figura[i] = {fila, columna+1};
                        figura[i] = {fila+1, columna};
                        figura[i] = {fila+1, columna+1};                     
                    }
                }
                break;

            default:
                Console.WriteLine("No es una figura disponible dentro del KILLER SUDOKU")
        }

    }


    public void start(){
        Console.WriteLine("Empieza..");

    }

    static void main(String[] args){
        Console.WriteLine("Bienvenido...");
        start();
    }
}