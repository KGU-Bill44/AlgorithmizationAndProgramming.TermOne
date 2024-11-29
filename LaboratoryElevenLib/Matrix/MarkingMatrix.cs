namespace LaboratoryElevenLib.Matrix;

/// <summary>
/// Макет размерности матрицы.
/// </summary>
/// <param name="LengthOfMatrixByRow">Длина матрицы по строками.</param>
/// <param name="LengthOfMatrixByColumn">Длинна матрицы по столбцам.</param>
internal record MarkingMatrix(int LengthOfMatrixByRow, int LengthOfMatrixByColumn);