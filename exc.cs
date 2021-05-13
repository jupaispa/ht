using System;
					
public class Program
{
	public static void Main()
	{
		int cols = 5; int rows = 5; int col_queen = 3; int row_queen = 2;
		int[,] tab = new int[cols,rows];
		tab[col_queen, row_queen] = 1;
		tab[4,4]=-1; tab[3,1]=-1;tab[1,2]=-1;
		for(int i=0; i< cols; i++)
			for(int j =0; j<rows; j++)
				if(!(tab[i, j] == -1 || tab[i, j] == 1))
					tab[i, j] = 0;
		int cont = 0;
		
		for(int i = col_queen; i < cols; i++){
			if(tab[i, row_queen] == 0)
				cont=cont+1;
			else if (tab[i, row_queen] == -1)
				i = cols;
		}
		for(int i = col_queen; i >=0; i--){
			if(tab[i, row_queen] == 0)
				cont=cont+1;
			else if (tab[i, row_queen] == -1)
				i = 0;
		}
		for(int i = row_queen; i < cols; i++){
			if(tab[col_queen, i] == 0)
				cont=cont+1;
			else if (tab[col_queen, i] == -1)
				i = cols;
		}
		for(int i = row_queen; i >=0; i--){
			if(tab[col_queen, i] == 0)
				cont=cont+1;
			else if (tab[col_queen, i] == -1)
				i = 0;
		}
		int id = col_queen; int jd = row_queen;
		while(id >= 0 && jd < rows){
				if(tab[id, jd] == 0)
					cont=cont+1;
				else if (tab[id, jd] == -1)
					id=0;
			id--;jd++;
		}
		id = col_queen;jd = row_queen;		
		while(id < cols && jd >=0){
				if(tab[id, jd] == 0)
					cont=cont+1;
				else if (tab[id, jd] == -1)
					id=cols;
			id++;jd--;
		}
		id = col_queen;jd = row_queen;		
		while(id >= 0 && jd >= 0){
				if(tab[id, jd] == 0)
					cont=cont+1;
				else if (tab[id, jd] == -1)
					id=0;
			id--;jd--;
		}
		id = col_queen;jd = row_queen;		
		while(id < cols  && jd < rows){
			if(tab[id, jd] == 0)
					cont=cont+1;
			else if (tab[id, jd] == -1)
					id=cols;
			id++;jd++;
		}
		Console.WriteLine(cont);
	}
}
