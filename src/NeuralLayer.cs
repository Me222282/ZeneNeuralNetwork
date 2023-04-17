using System;
using Zene.Structs;

namespace Zene.NeuralNetwork
{
    public class NeuralLayer : IMatrix
    {
        public NeuralLayer(int preSize, int postSize)
        {
            Rows = postSize;
            Columns = preSize;
            _matrix = new double[postSize * preSize];
        }

        public int Rows { get; }
        public int Columns { get; }

        private readonly double[] _matrix;
        public int Length => _matrix.Length;

        public double this[int x, int y]
        {
            get => _matrix[x + (y * Rows)];
            set => _matrix[x + (y * Rows)] = value;
        }
        public double this[int index]
        {
            get => _matrix[index];
            set => _matrix[index] = value;
        }
        public double this[Index index]
        {
            get => _matrix[index.Value];
            set => _matrix[index.Value] = value;
        }

        public MatrixSpan MatrixData() => new MatrixSpan(Rows, Columns, _matrix);
    }
}
