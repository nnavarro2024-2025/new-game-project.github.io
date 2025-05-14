using Godot;
using System;

public partial class NewScript : Node
{
	public override void _Ready()
	{
		// Test if GD.Print() is working
		GD.Print("Hello, Godot!");

		// Your matrix code...
		int[,] matrix = new int[10, 10];
		int[] rowSum = new int[10];

		// Fill the matrix
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				matrix[i, j] = i + j;
			}
		}

		// Calculate row sums
		for (int i = 0; i < 10; i++) {
			int sum = 0;
			for (int j = 0; j < 10; j++) {
				sum += matrix[i, j];
			}
			rowSum[i] = sum;
		}

		// Print the matrix
		GD.Print("Matrix:");
		for (int i = 0; i < 10; i++) {
			string row = "";
			for (int j = 0; j < 10; j++) {
				row += matrix[i, j].ToString().PadLeft(3) + " ";
			}
			GD.Print(row);
		}

		// Print row sums
		GD.Print("\nRow Sums:");
		for (int i = 0; i < 10; i++) {
			GD.Print($"Row {i}: {rowSum[i]}");
		}
	}
}
