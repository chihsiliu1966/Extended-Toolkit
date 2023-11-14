﻿#region MIT License
/*
 * MIT License
 *
 * Copyright (c) 2017 - 2023 Krypton Suite
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 */
#endregion

namespace Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot
{
    public class Speed : IColourMap
    {
        public string Name => "Speed";

        public (byte r, byte g, byte b) GetRGB(byte value) =>
            (cmaplocal[value, 0], cmaplocal[value, 1], cmaplocal[value, 2]);

        private static readonly byte[,] cmaplocal = {
            { 255, 253, 205 },
            { 254, 252, 203 },
            { 254, 250, 201 },
            { 253, 249, 199 },
            { 252, 248, 197 },
            { 252, 247, 194 },
            { 251, 246, 192 },
            { 250, 244, 190 },
            { 249, 243, 188 },
            { 249, 242, 186 },
            { 248, 241, 184 },
            { 247, 240, 182 },
            { 247, 238, 180 },
            { 246, 237, 177 },
            { 246, 236, 175 },
            { 245, 235, 173 },
            { 244, 234, 171 },
            { 243, 233, 169 },
            { 243, 231, 167 },
            { 242, 230, 165 },
            { 241, 229, 162 },
            { 241, 228, 160 },
            { 240, 227, 158 },
            { 239, 226, 156 },
            { 239, 225, 154 },
            { 238, 223, 152 },
            { 237, 222, 150 },
            { 237, 221, 147 },
            { 236, 220, 145 },
            { 235, 219, 143 },
            { 234, 218, 141 },
            { 234, 217, 139 },
            { 233, 216, 137 },
            { 232, 215, 134 },
            { 231, 214, 132 },
            { 231, 213, 130 },
            { 230, 212, 128 },
            { 229, 211, 126 },
            { 228, 210, 123 },
            { 227, 208, 121 },
            { 227, 207, 119 },
            { 226, 206, 117 },
            { 225, 205, 115 },
            { 224, 205, 113 },
            { 223, 204, 110 },
            { 222, 203, 108 },
            { 221, 202, 106 },
            { 220, 201, 104 },
            { 219, 200, 102 },
            { 218, 199, 100 },
            { 217, 198, 97 },
            { 216, 197, 95 },
            { 215, 196, 93 },
            { 214, 195, 91 },
            { 213, 194, 89 },
            { 212, 193, 87 },
            { 211, 193, 85 },
            { 210, 192, 83 },
            { 209, 191, 81 },
            { 208, 190, 79 },
            { 206, 189, 76 },
            { 205, 189, 74 },
            { 204, 188, 72 },
            { 203, 187, 70 },
            { 201, 186, 69 },
            { 200, 185, 67 },
            { 199, 185, 65 },
            { 197, 184, 63 },
            { 196, 183, 61 },
            { 195, 183, 59 },
            { 193, 182, 57 },
            { 192, 181, 55 },
            { 190, 180, 54 },
            { 189, 180, 52 },
            { 187, 179, 50 },
            { 186, 178, 48 },
            { 184, 178, 47 },
            { 183, 177, 45 },
            { 181, 176, 43 },
            { 180, 176, 42 },
            { 178, 175, 40 },
            { 177, 174, 39 },
            { 175, 174, 37 },
            { 173, 173, 35 },
            { 172, 173, 34 },
            { 170, 172, 32 },
            { 169, 171, 31 },
            { 167, 171, 30 },
            { 165, 170, 28 },
            { 164, 169, 27 },
            { 162, 169, 25 },
            { 160, 168, 24 },
            { 159, 168, 23 },
            { 157, 167, 21 },
            { 155, 166, 20 },
            { 154, 166, 19 },
            { 152, 165, 18 },
            { 150, 165, 16 },
            { 149, 164, 15 },
            { 147, 163, 14 },
            { 145, 163, 13 },
            { 143, 162, 12 },
            { 142, 162, 11 },
            { 140, 161, 10 },
            { 138, 160, 9 },
            { 136, 160, 8 },
            { 135, 159, 8 },
            { 133, 159, 7 },
            { 131, 158, 7 },
            { 129, 157, 6 },
            { 128, 157, 6 },
            { 126, 156, 6 },
            { 124, 156, 6 },
            { 122, 155, 6 },
            { 121, 154, 6 },
            { 119, 154, 6 },
            { 117, 153, 6 },
            { 115, 153, 6 },
            { 113, 152, 6 },
            { 112, 151, 7 },
            { 110, 151, 7 },
            { 108, 150, 7 },
            { 106, 149, 8 },
            { 104, 149, 9 },
            { 102, 148, 9 },
            { 101, 148, 10 },
            { 99, 147, 11 },
            { 97, 146, 11 },
            { 95, 146, 12 },
            { 93, 145, 13 },
            { 92, 144, 14 },
            { 90, 144, 15 },
            { 88, 143, 15 },
            { 86, 142, 16 },
            { 84, 142, 17 },
            { 82, 141, 18 },
            { 81, 140, 18 },
            { 79, 140, 19 },
            { 77, 139, 20 },
            { 75, 138, 21 },
            { 73, 138, 22 },
            { 72, 137, 22 },
            { 70, 136, 23 },
            { 68, 136, 24 },
            { 66, 135, 25 },
            { 64, 134, 25 },
            { 63, 133, 26 },
            { 61, 133, 27 },
            { 59, 132, 28 },
            { 57, 131, 28 },
            { 56, 131, 29 },
            { 54, 130, 30 },
            { 52, 129, 30 },
            { 50, 128, 31 },
            { 49, 127, 32 },
            { 47, 127, 32 },
            { 45, 126, 33 },
            { 44, 125, 33 },
            { 42, 124, 34 },
            { 40, 124, 35 },
            { 39, 123, 35 },
            { 37, 122, 36 },
            { 36, 121, 36 },
            { 34, 120, 37 },
            { 33, 120, 37 },
            { 31, 119, 38 },
            { 30, 118, 38 },
            { 28, 117, 39 },
            { 27, 116, 39 },
            { 26, 115, 39 },
            { 24, 115, 40 },
            { 23, 114, 40 },
            { 22, 113, 41 },
            { 21, 112, 41 },
            { 19, 111, 41 },
            { 18, 110, 42 },
            { 17, 109, 42 },
            { 16, 108, 42 },
            { 15, 108, 43 },
            { 15, 107, 43 },
            { 14, 106, 43 },
            { 13, 105, 43 },
            { 13, 104, 43 },
            { 12, 103, 44 },
            { 12, 102, 44 },
            { 11, 101, 44 },
            { 11, 100, 44 },
            { 11, 99, 44 },
            { 11, 99, 44 },
            { 11, 98, 45 },
            { 11, 97, 45 },
            { 11, 96, 45 },
            { 11, 95, 45 },
            { 11, 94, 45 },
            { 12, 93, 45 },
            { 12, 92, 45 },
            { 12, 91, 45 },
            { 13, 90, 45 },
            { 13, 89, 45 },
            { 14, 88, 45 },
            { 14, 87, 45 },
            { 15, 86, 44 },
            { 15, 85, 44 },
            { 16, 84, 44 },
            { 16, 84, 44 },
            { 16, 83, 44 },
            { 17, 82, 44 },
            { 17, 81, 44 },
            { 18, 80, 43 },
            { 18, 79, 43 },
            { 19, 78, 43 },
            { 19, 77, 43 },
            { 20, 76, 42 },
            { 20, 75, 42 },
            { 20, 74, 42 },
            { 21, 73, 42 },
            { 21, 72, 41 },
            { 22, 71, 41 },
            { 22, 70, 41 },
            { 22, 69, 40 },
            { 23, 68, 40 },
            { 23, 67, 39 },
            { 23, 66, 39 },
            { 23, 65, 39 },
            { 24, 64, 38 },
            { 24, 63, 38 },
            { 24, 63, 37 },
            { 24, 62, 37 },
            { 25, 61, 36 },
            { 25, 60, 36 },
            { 25, 59, 35 },
            { 25, 58, 35 },
            { 25, 57, 34 },
            { 25, 56, 34 },
            { 25, 55, 33 },
            { 25, 54, 33 },
            { 25, 53, 32 },
            { 25, 52, 31 },
            { 25, 51, 31 },
            { 25, 50, 30 },
            { 25, 49, 30 },
            { 25, 48, 29 },
            { 25, 47, 28 },
            { 25, 46, 28 },
            { 25, 45, 27 },
            { 25, 44, 26 },
            { 25, 44, 25 },
            { 25, 43, 25 },
            { 25, 42, 24 },
            { 24, 41, 23 },
            { 24, 40, 23 },
            { 24, 39, 22 },
            { 24, 38, 21 },
            { 24, 37, 20 },
            { 23, 36, 19 },
            { 23, 35, 19 }

        };
    }
}

