using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnicodeNormalization
{
	internal partial class UChar
	{
		private static Dictionary<int, Dictionary<int, Feature>> generateUData()
		{
			return new Dictionary<int, Dictionary<int, Feature>>
			{
				[0] = new Dictionary<int, Feature>
				{
					[60] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8814, },
					},
					[61] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8800, },
					},
					[62] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8815, },
					},
					[65] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 192, [769] = 193, [770] = 194, [771] = 195, [772] = 256, [774] = 258, [775] = 550, [776] = 196, [777] = 7842, [778] = 197, [780] = 461, [783] = 512, [785] = 514, [803] = 7840, [805] = 7680, [808] = 260, },
					},
					[66] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7682, [803] = 7684, [817] = 7686, },
					},
					[67] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 262, [770] = 264, [775] = 266, [780] = 268, [807] = 199, },
					},
					[68] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7690, [780] = 270, [803] = 7692, [807] = 7696, [813] = 7698, [817] = 7694, },
					},
					[69] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 200, [769] = 201, [770] = 202, [771] = 7868, [772] = 274, [774] = 276, [775] = 278, [776] = 203, [777] = 7866, [780] = 282, [783] = 516, [785] = 518, [803] = 7864, [807] = 552, [808] = 280, [813] = 7704, [816] = 7706, },
					},
					[70] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7710, },
					},
					[71] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 500, [770] = 284, [772] = 7712, [774] = 286, [775] = 288, [780] = 486, [807] = 290, },
					},
					[72] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 292, [775] = 7714, [776] = 7718, [780] = 542, [803] = 7716, [807] = 7720, [814] = 7722, },
					},
					[73] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 204, [769] = 205, [770] = 206, [771] = 296, [772] = 298, [774] = 300, [775] = 304, [776] = 207, [777] = 7880, [780] = 463, [783] = 520, [785] = 522, [803] = 7882, [808] = 302, [816] = 7724, },
					},
					[74] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 308, },
					},
					[75] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7728, [780] = 488, [803] = 7730, [807] = 310, [817] = 7732, },
					},
					[76] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 313, [780] = 317, [803] = 7734, [807] = 315, [813] = 7740, [817] = 7738, },
					},
					[77] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7742, [775] = 7744, [803] = 7746, },
					},
					[78] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 504, [769] = 323, [771] = 209, [775] = 7748, [780] = 327, [803] = 7750, [807] = 325, [813] = 7754, [817] = 7752, },
					},
					[79] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 210, [769] = 211, [770] = 212, [771] = 213, [772] = 332, [774] = 334, [775] = 558, [776] = 214, [777] = 7886, [779] = 336, [780] = 465, [783] = 524, [785] = 526, [795] = 416, [803] = 7884, [808] = 490, },
					},
					[80] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7764, [775] = 7766, },
					},
					[82] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 340, [775] = 7768, [780] = 344, [783] = 528, [785] = 530, [803] = 7770, [807] = 342, [817] = 7774, },
					},
					[83] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 346, [770] = 348, [775] = 7776, [780] = 352, [803] = 7778, [806] = 536, [807] = 350, },
					},
					[84] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7786, [780] = 356, [803] = 7788, [806] = 538, [807] = 354, [813] = 7792, [817] = 7790, },
					},
					[85] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 217, [769] = 218, [770] = 219, [771] = 360, [772] = 362, [774] = 364, [776] = 220, [777] = 7910, [778] = 366, [779] = 368, [780] = 467, [783] = 532, [785] = 534, [795] = 431, [803] = 7908, [804] = 7794, [808] = 370, [813] = 7798, [816] = 7796, },
					},
					[86] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [771] = 7804, [803] = 7806, },
					},
					[87] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7808, [769] = 7810, [770] = 372, [775] = 7814, [776] = 7812, [803] = 7816, },
					},
					[88] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7818, [776] = 7820, },
					},
					[89] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7922, [769] = 221, [770] = 374, [771] = 7928, [772] = 562, [775] = 7822, [776] = 376, [777] = 7926, [803] = 7924, },
					},
					[90] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 377, [770] = 7824, [775] = 379, [780] = 381, [803] = 7826, [817] = 7828, },
					},
					[97] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 224, [769] = 225, [770] = 226, [771] = 227, [772] = 257, [774] = 259, [775] = 551, [776] = 228, [777] = 7843, [778] = 229, [780] = 462, [783] = 513, [785] = 515, [803] = 7841, [805] = 7681, [808] = 261, },
					},
					[98] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7683, [803] = 7685, [817] = 7687, },
					},
					[99] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 263, [770] = 265, [775] = 267, [780] = 269, [807] = 231, },
					},
					[100] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7691, [780] = 271, [803] = 7693, [807] = 7697, [813] = 7699, [817] = 7695, },
					},
					[101] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 232, [769] = 233, [770] = 234, [771] = 7869, [772] = 275, [774] = 277, [775] = 279, [776] = 235, [777] = 7867, [780] = 283, [783] = 517, [785] = 519, [803] = 7865, [807] = 553, [808] = 281, [813] = 7705, [816] = 7707, },
					},
					[102] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7711, },
					},
					[103] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 501, [770] = 285, [772] = 7713, [774] = 287, [775] = 289, [780] = 487, [807] = 291, },
					},
					[104] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 293, [775] = 7715, [776] = 7719, [780] = 543, [803] = 7717, [807] = 7721, [814] = 7723, [817] = 7830, },
					},
					[105] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 236, [769] = 237, [770] = 238, [771] = 297, [772] = 299, [774] = 301, [776] = 239, [777] = 7881, [780] = 464, [783] = 521, [785] = 523, [803] = 7883, [808] = 303, [816] = 7725, },
					},
					[106] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 309, [780] = 496, },
					},
					[107] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7729, [780] = 489, [803] = 7731, [807] = 311, [817] = 7733, },
					},
					[108] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 314, [780] = 318, [803] = 7735, [807] = 316, [813] = 7741, [817] = 7739, },
					},
					[109] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7743, [775] = 7745, [803] = 7747, },
					},
					[110] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 505, [769] = 324, [771] = 241, [775] = 7749, [780] = 328, [803] = 7751, [807] = 326, [813] = 7755, [817] = 7753, },
					},
					[111] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 242, [769] = 243, [770] = 244, [771] = 245, [772] = 333, [774] = 335, [775] = 559, [776] = 246, [777] = 7887, [779] = 337, [780] = 466, [783] = 525, [785] = 527, [795] = 417, [803] = 7885, [808] = 491, },
					},
					[112] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7765, [775] = 7767, },
					},
					[114] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 341, [775] = 7769, [780] = 345, [783] = 529, [785] = 531, [803] = 7771, [807] = 343, [817] = 7775, },
					},
					[115] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 347, [770] = 349, [775] = 7777, [780] = 353, [803] = 7779, [806] = 537, [807] = 351, },
					},
					[116] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7787, [776] = 7831, [780] = 357, [803] = 7789, [806] = 539, [807] = 355, [813] = 7793, [817] = 7791, },
					},
					[117] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 249, [769] = 250, [770] = 251, [771] = 361, [772] = 363, [774] = 365, [776] = 252, [777] = 7911, [778] = 367, [779] = 369, [780] = 468, [783] = 533, [785] = 535, [795] = 432, [803] = 7909, [804] = 7795, [808] = 371, [813] = 7799, [816] = 7797, },
					},
					[118] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [771] = 7805, [803] = 7807, },
					},
					[119] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7809, [769] = 7811, [770] = 373, [775] = 7815, [776] = 7813, [778] = 7832, [803] = 7817, },
					},
					[120] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7819, [776] = 7821, },
					},
					[121] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7923, [769] = 253, [770] = 375, [771] = 7929, [772] = 563, [775] = 7823, [776] = 255, [777] = 7927, [778] = 7833, [803] = 7925, },
					},
					[122] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 378, [770] = 7825, [775] = 380, [780] = 382, [803] = 7827, [817] = 7829, },
					},
					[160] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[168] = new Feature
					{
						_0 = new int[] { 32, 776 },
						_1 = 256,
						_2 = new Dictionary<int, int> { [768] = 8173, [769] = 901, [834] = 8129, },
					},
					[170] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[175] = new Feature
					{
						_0 = new int[] { 32, 772 },
						_1 = 256,
						_2 = null,
					},
					[178] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[179] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[180] = new Feature
					{
						_0 = new int[] { 32, 769 },
						_1 = 256,
						_2 = null,
					},
					[181] = new Feature
					{
						_0 = new int[] { 956 },
						_1 = 256,
						_2 = null,
					},
					[184] = new Feature
					{
						_0 = new int[] { 32, 807 },
						_1 = 256,
						_2 = null,
					},
					[185] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[186] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[188] = new Feature
					{
						_0 = new int[] { 49, 8260, 52 },
						_1 = 256,
						_2 = null,
					},
					[189] = new Feature
					{
						_0 = new int[] { 49, 8260, 50 },
						_1 = 256,
						_2 = null,
					},
					[190] = new Feature
					{
						_0 = new int[] { 51, 8260, 52 },
						_1 = 256,
						_2 = null,
					},
					[192] = new Feature
					{
						_0 = new int[] { 65, 768 },
						_1 = null,
						_2 = null,
					},
					[193] = new Feature
					{
						_0 = new int[] { 65, 769 },
						_1 = null,
						_2 = null,
					},
					[194] = new Feature
					{
						_0 = new int[] { 65, 770 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7846, [769] = 7844, [771] = 7850, [777] = 7848, },
					},
					[195] = new Feature
					{
						_0 = new int[] { 65, 771 },
						_1 = null,
						_2 = null,
					},
					[196] = new Feature
					{
						_0 = new int[] { 65, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 478, },
					},
					[197] = new Feature
					{
						_0 = new int[] { 65, 778 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 506, },
					},
					[198] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 508, [772] = 482, },
					},
					[199] = new Feature
					{
						_0 = new int[] { 67, 807 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7688, },
					},
					[200] = new Feature
					{
						_0 = new int[] { 69, 768 },
						_1 = null,
						_2 = null,
					},
					[201] = new Feature
					{
						_0 = new int[] { 69, 769 },
						_1 = null,
						_2 = null,
					},
					[202] = new Feature
					{
						_0 = new int[] { 69, 770 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7872, [769] = 7870, [771] = 7876, [777] = 7874, },
					},
					[203] = new Feature
					{
						_0 = new int[] { 69, 776 },
						_1 = null,
						_2 = null,
					},
					[204] = new Feature
					{
						_0 = new int[] { 73, 768 },
						_1 = null,
						_2 = null,
					},
					[205] = new Feature
					{
						_0 = new int[] { 73, 769 },
						_1 = null,
						_2 = null,
					},
					[206] = new Feature
					{
						_0 = new int[] { 73, 770 },
						_1 = null,
						_2 = null,
					},
					[207] = new Feature
					{
						_0 = new int[] { 73, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7726, },
					},
					[209] = new Feature
					{
						_0 = new int[] { 78, 771 },
						_1 = null,
						_2 = null,
					},
					[210] = new Feature
					{
						_0 = new int[] { 79, 768 },
						_1 = null,
						_2 = null,
					},
					[211] = new Feature
					{
						_0 = new int[] { 79, 769 },
						_1 = null,
						_2 = null,
					},
					[212] = new Feature
					{
						_0 = new int[] { 79, 770 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7890, [769] = 7888, [771] = 7894, [777] = 7892, },
					},
					[213] = new Feature
					{
						_0 = new int[] { 79, 771 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7756, [772] = 556, [776] = 7758, },
					},
					[214] = new Feature
					{
						_0 = new int[] { 79, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 554, },
					},
					[216] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 510, },
					},
					[217] = new Feature
					{
						_0 = new int[] { 85, 768 },
						_1 = null,
						_2 = null,
					},
					[218] = new Feature
					{
						_0 = new int[] { 85, 769 },
						_1 = null,
						_2 = null,
					},
					[219] = new Feature
					{
						_0 = new int[] { 85, 770 },
						_1 = null,
						_2 = null,
					},
					[220] = new Feature
					{
						_0 = new int[] { 85, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 475, [769] = 471, [772] = 469, [780] = 473, },
					},
					[221] = new Feature
					{
						_0 = new int[] { 89, 769 },
						_1 = null,
						_2 = null,
					},
					[224] = new Feature
					{
						_0 = new int[] { 97, 768 },
						_1 = null,
						_2 = null,
					},
					[225] = new Feature
					{
						_0 = new int[] { 97, 769 },
						_1 = null,
						_2 = null,
					},
					[226] = new Feature
					{
						_0 = new int[] { 97, 770 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7847, [769] = 7845, [771] = 7851, [777] = 7849, },
					},
					[227] = new Feature
					{
						_0 = new int[] { 97, 771 },
						_1 = null,
						_2 = null,
					},
					[228] = new Feature
					{
						_0 = new int[] { 97, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 479, },
					},
					[229] = new Feature
					{
						_0 = new int[] { 97, 778 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 507, },
					},
					[230] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 509, [772] = 483, },
					},
					[231] = new Feature
					{
						_0 = new int[] { 99, 807 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7689, },
					},
					[232] = new Feature
					{
						_0 = new int[] { 101, 768 },
						_1 = null,
						_2 = null,
					},
					[233] = new Feature
					{
						_0 = new int[] { 101, 769 },
						_1 = null,
						_2 = null,
					},
					[234] = new Feature
					{
						_0 = new int[] { 101, 770 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7873, [769] = 7871, [771] = 7877, [777] = 7875, },
					},
					[235] = new Feature
					{
						_0 = new int[] { 101, 776 },
						_1 = null,
						_2 = null,
					},
					[236] = new Feature
					{
						_0 = new int[] { 105, 768 },
						_1 = null,
						_2 = null,
					},
					[237] = new Feature
					{
						_0 = new int[] { 105, 769 },
						_1 = null,
						_2 = null,
					},
					[238] = new Feature
					{
						_0 = new int[] { 105, 770 },
						_1 = null,
						_2 = null,
					},
					[239] = new Feature
					{
						_0 = new int[] { 105, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7727, },
					},
					[241] = new Feature
					{
						_0 = new int[] { 110, 771 },
						_1 = null,
						_2 = null,
					},
					[242] = new Feature
					{
						_0 = new int[] { 111, 768 },
						_1 = null,
						_2 = null,
					},
					[243] = new Feature
					{
						_0 = new int[] { 111, 769 },
						_1 = null,
						_2 = null,
					},
					[244] = new Feature
					{
						_0 = new int[] { 111, 770 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7891, [769] = 7889, [771] = 7895, [777] = 7893, },
					},
					[245] = new Feature
					{
						_0 = new int[] { 111, 771 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7757, [772] = 557, [776] = 7759, },
					},
					[246] = new Feature
					{
						_0 = new int[] { 111, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 555, },
					},
					[248] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 511, },
					},
					[249] = new Feature
					{
						_0 = new int[] { 117, 768 },
						_1 = null,
						_2 = null,
					},
					[250] = new Feature
					{
						_0 = new int[] { 117, 769 },
						_1 = null,
						_2 = null,
					},
					[251] = new Feature
					{
						_0 = new int[] { 117, 770 },
						_1 = null,
						_2 = null,
					},
					[252] = new Feature
					{
						_0 = new int[] { 117, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 476, [769] = 472, [772] = 470, [780] = 474, },
					},
					[253] = new Feature
					{
						_0 = new int[] { 121, 769 },
						_1 = null,
						_2 = null,
					},
					[255] = new Feature
					{
						_0 = new int[] { 121, 776 },
						_1 = null,
						_2 = null,
					},
				},
				[256] = new Dictionary<int, Feature>
				{
					[256] = new Feature
					{
						_0 = new int[] { 65, 772 },
						_1 = null,
						_2 = null,
					},
					[257] = new Feature
					{
						_0 = new int[] { 97, 772 },
						_1 = null,
						_2 = null,
					},
					[258] = new Feature
					{
						_0 = new int[] { 65, 774 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7856, [769] = 7854, [771] = 7860, [777] = 7858, },
					},
					[259] = new Feature
					{
						_0 = new int[] { 97, 774 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7857, [769] = 7855, [771] = 7861, [777] = 7859, },
					},
					[260] = new Feature
					{
						_0 = new int[] { 65, 808 },
						_1 = null,
						_2 = null,
					},
					[261] = new Feature
					{
						_0 = new int[] { 97, 808 },
						_1 = null,
						_2 = null,
					},
					[262] = new Feature
					{
						_0 = new int[] { 67, 769 },
						_1 = null,
						_2 = null,
					},
					[263] = new Feature
					{
						_0 = new int[] { 99, 769 },
						_1 = null,
						_2 = null,
					},
					[264] = new Feature
					{
						_0 = new int[] { 67, 770 },
						_1 = null,
						_2 = null,
					},
					[265] = new Feature
					{
						_0 = new int[] { 99, 770 },
						_1 = null,
						_2 = null,
					},
					[266] = new Feature
					{
						_0 = new int[] { 67, 775 },
						_1 = null,
						_2 = null,
					},
					[267] = new Feature
					{
						_0 = new int[] { 99, 775 },
						_1 = null,
						_2 = null,
					},
					[268] = new Feature
					{
						_0 = new int[] { 67, 780 },
						_1 = null,
						_2 = null,
					},
					[269] = new Feature
					{
						_0 = new int[] { 99, 780 },
						_1 = null,
						_2 = null,
					},
					[270] = new Feature
					{
						_0 = new int[] { 68, 780 },
						_1 = null,
						_2 = null,
					},
					[271] = new Feature
					{
						_0 = new int[] { 100, 780 },
						_1 = null,
						_2 = null,
					},
					[274] = new Feature
					{
						_0 = new int[] { 69, 772 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7700, [769] = 7702, },
					},
					[275] = new Feature
					{
						_0 = new int[] { 101, 772 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7701, [769] = 7703, },
					},
					[276] = new Feature
					{
						_0 = new int[] { 69, 774 },
						_1 = null,
						_2 = null,
					},
					[277] = new Feature
					{
						_0 = new int[] { 101, 774 },
						_1 = null,
						_2 = null,
					},
					[278] = new Feature
					{
						_0 = new int[] { 69, 775 },
						_1 = null,
						_2 = null,
					},
					[279] = new Feature
					{
						_0 = new int[] { 101, 775 },
						_1 = null,
						_2 = null,
					},
					[280] = new Feature
					{
						_0 = new int[] { 69, 808 },
						_1 = null,
						_2 = null,
					},
					[281] = new Feature
					{
						_0 = new int[] { 101, 808 },
						_1 = null,
						_2 = null,
					},
					[282] = new Feature
					{
						_0 = new int[] { 69, 780 },
						_1 = null,
						_2 = null,
					},
					[283] = new Feature
					{
						_0 = new int[] { 101, 780 },
						_1 = null,
						_2 = null,
					},
					[284] = new Feature
					{
						_0 = new int[] { 71, 770 },
						_1 = null,
						_2 = null,
					},
					[285] = new Feature
					{
						_0 = new int[] { 103, 770 },
						_1 = null,
						_2 = null,
					},
					[286] = new Feature
					{
						_0 = new int[] { 71, 774 },
						_1 = null,
						_2 = null,
					},
					[287] = new Feature
					{
						_0 = new int[] { 103, 774 },
						_1 = null,
						_2 = null,
					},
					[288] = new Feature
					{
						_0 = new int[] { 71, 775 },
						_1 = null,
						_2 = null,
					},
					[289] = new Feature
					{
						_0 = new int[] { 103, 775 },
						_1 = null,
						_2 = null,
					},
					[290] = new Feature
					{
						_0 = new int[] { 71, 807 },
						_1 = null,
						_2 = null,
					},
					[291] = new Feature
					{
						_0 = new int[] { 103, 807 },
						_1 = null,
						_2 = null,
					},
					[292] = new Feature
					{
						_0 = new int[] { 72, 770 },
						_1 = null,
						_2 = null,
					},
					[293] = new Feature
					{
						_0 = new int[] { 104, 770 },
						_1 = null,
						_2 = null,
					},
					[296] = new Feature
					{
						_0 = new int[] { 73, 771 },
						_1 = null,
						_2 = null,
					},
					[297] = new Feature
					{
						_0 = new int[] { 105, 771 },
						_1 = null,
						_2 = null,
					},
					[298] = new Feature
					{
						_0 = new int[] { 73, 772 },
						_1 = null,
						_2 = null,
					},
					[299] = new Feature
					{
						_0 = new int[] { 105, 772 },
						_1 = null,
						_2 = null,
					},
					[300] = new Feature
					{
						_0 = new int[] { 73, 774 },
						_1 = null,
						_2 = null,
					},
					[301] = new Feature
					{
						_0 = new int[] { 105, 774 },
						_1 = null,
						_2 = null,
					},
					[302] = new Feature
					{
						_0 = new int[] { 73, 808 },
						_1 = null,
						_2 = null,
					},
					[303] = new Feature
					{
						_0 = new int[] { 105, 808 },
						_1 = null,
						_2 = null,
					},
					[304] = new Feature
					{
						_0 = new int[] { 73, 775 },
						_1 = null,
						_2 = null,
					},
					[306] = new Feature
					{
						_0 = new int[] { 73, 74 },
						_1 = 256,
						_2 = null,
					},
					[307] = new Feature
					{
						_0 = new int[] { 105, 106 },
						_1 = 256,
						_2 = null,
					},
					[308] = new Feature
					{
						_0 = new int[] { 74, 770 },
						_1 = null,
						_2 = null,
					},
					[309] = new Feature
					{
						_0 = new int[] { 106, 770 },
						_1 = null,
						_2 = null,
					},
					[310] = new Feature
					{
						_0 = new int[] { 75, 807 },
						_1 = null,
						_2 = null,
					},
					[311] = new Feature
					{
						_0 = new int[] { 107, 807 },
						_1 = null,
						_2 = null,
					},
					[313] = new Feature
					{
						_0 = new int[] { 76, 769 },
						_1 = null,
						_2 = null,
					},
					[314] = new Feature
					{
						_0 = new int[] { 108, 769 },
						_1 = null,
						_2 = null,
					},
					[315] = new Feature
					{
						_0 = new int[] { 76, 807 },
						_1 = null,
						_2 = null,
					},
					[316] = new Feature
					{
						_0 = new int[] { 108, 807 },
						_1 = null,
						_2 = null,
					},
					[317] = new Feature
					{
						_0 = new int[] { 76, 780 },
						_1 = null,
						_2 = null,
					},
					[318] = new Feature
					{
						_0 = new int[] { 108, 780 },
						_1 = null,
						_2 = null,
					},
					[319] = new Feature
					{
						_0 = new int[] { 76, 183 },
						_1 = 256,
						_2 = null,
					},
					[320] = new Feature
					{
						_0 = new int[] { 108, 183 },
						_1 = 256,
						_2 = null,
					},
					[323] = new Feature
					{
						_0 = new int[] { 78, 769 },
						_1 = null,
						_2 = null,
					},
					[324] = new Feature
					{
						_0 = new int[] { 110, 769 },
						_1 = null,
						_2 = null,
					},
					[325] = new Feature
					{
						_0 = new int[] { 78, 807 },
						_1 = null,
						_2 = null,
					},
					[326] = new Feature
					{
						_0 = new int[] { 110, 807 },
						_1 = null,
						_2 = null,
					},
					[327] = new Feature
					{
						_0 = new int[] { 78, 780 },
						_1 = null,
						_2 = null,
					},
					[328] = new Feature
					{
						_0 = new int[] { 110, 780 },
						_1 = null,
						_2 = null,
					},
					[329] = new Feature
					{
						_0 = new int[] { 700, 110 },
						_1 = 256,
						_2 = null,
					},
					[332] = new Feature
					{
						_0 = new int[] { 79, 772 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7760, [769] = 7762, },
					},
					[333] = new Feature
					{
						_0 = new int[] { 111, 772 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7761, [769] = 7763, },
					},
					[334] = new Feature
					{
						_0 = new int[] { 79, 774 },
						_1 = null,
						_2 = null,
					},
					[335] = new Feature
					{
						_0 = new int[] { 111, 774 },
						_1 = null,
						_2 = null,
					},
					[336] = new Feature
					{
						_0 = new int[] { 79, 779 },
						_1 = null,
						_2 = null,
					},
					[337] = new Feature
					{
						_0 = new int[] { 111, 779 },
						_1 = null,
						_2 = null,
					},
					[340] = new Feature
					{
						_0 = new int[] { 82, 769 },
						_1 = null,
						_2 = null,
					},
					[341] = new Feature
					{
						_0 = new int[] { 114, 769 },
						_1 = null,
						_2 = null,
					},
					[342] = new Feature
					{
						_0 = new int[] { 82, 807 },
						_1 = null,
						_2 = null,
					},
					[343] = new Feature
					{
						_0 = new int[] { 114, 807 },
						_1 = null,
						_2 = null,
					},
					[344] = new Feature
					{
						_0 = new int[] { 82, 780 },
						_1 = null,
						_2 = null,
					},
					[345] = new Feature
					{
						_0 = new int[] { 114, 780 },
						_1 = null,
						_2 = null,
					},
					[346] = new Feature
					{
						_0 = new int[] { 83, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7780, },
					},
					[347] = new Feature
					{
						_0 = new int[] { 115, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7781, },
					},
					[348] = new Feature
					{
						_0 = new int[] { 83, 770 },
						_1 = null,
						_2 = null,
					},
					[349] = new Feature
					{
						_0 = new int[] { 115, 770 },
						_1 = null,
						_2 = null,
					},
					[350] = new Feature
					{
						_0 = new int[] { 83, 807 },
						_1 = null,
						_2 = null,
					},
					[351] = new Feature
					{
						_0 = new int[] { 115, 807 },
						_1 = null,
						_2 = null,
					},
					[352] = new Feature
					{
						_0 = new int[] { 83, 780 },
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7782, },
					},
					[353] = new Feature
					{
						_0 = new int[] { 115, 780 },
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7783, },
					},
					[354] = new Feature
					{
						_0 = new int[] { 84, 807 },
						_1 = null,
						_2 = null,
					},
					[355] = new Feature
					{
						_0 = new int[] { 116, 807 },
						_1 = null,
						_2 = null,
					},
					[356] = new Feature
					{
						_0 = new int[] { 84, 780 },
						_1 = null,
						_2 = null,
					},
					[357] = new Feature
					{
						_0 = new int[] { 116, 780 },
						_1 = null,
						_2 = null,
					},
					[360] = new Feature
					{
						_0 = new int[] { 85, 771 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7800, },
					},
					[361] = new Feature
					{
						_0 = new int[] { 117, 771 },
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 7801, },
					},
					[362] = new Feature
					{
						_0 = new int[] { 85, 772 },
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 7802, },
					},
					[363] = new Feature
					{
						_0 = new int[] { 117, 772 },
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 7803, },
					},
					[364] = new Feature
					{
						_0 = new int[] { 85, 774 },
						_1 = null,
						_2 = null,
					},
					[365] = new Feature
					{
						_0 = new int[] { 117, 774 },
						_1 = null,
						_2 = null,
					},
					[366] = new Feature
					{
						_0 = new int[] { 85, 778 },
						_1 = null,
						_2 = null,
					},
					[367] = new Feature
					{
						_0 = new int[] { 117, 778 },
						_1 = null,
						_2 = null,
					},
					[368] = new Feature
					{
						_0 = new int[] { 85, 779 },
						_1 = null,
						_2 = null,
					},
					[369] = new Feature
					{
						_0 = new int[] { 117, 779 },
						_1 = null,
						_2 = null,
					},
					[370] = new Feature
					{
						_0 = new int[] { 85, 808 },
						_1 = null,
						_2 = null,
					},
					[371] = new Feature
					{
						_0 = new int[] { 117, 808 },
						_1 = null,
						_2 = null,
					},
					[372] = new Feature
					{
						_0 = new int[] { 87, 770 },
						_1 = null,
						_2 = null,
					},
					[373] = new Feature
					{
						_0 = new int[] { 119, 770 },
						_1 = null,
						_2 = null,
					},
					[374] = new Feature
					{
						_0 = new int[] { 89, 770 },
						_1 = null,
						_2 = null,
					},
					[375] = new Feature
					{
						_0 = new int[] { 121, 770 },
						_1 = null,
						_2 = null,
					},
					[376] = new Feature
					{
						_0 = new int[] { 89, 776 },
						_1 = null,
						_2 = null,
					},
					[377] = new Feature
					{
						_0 = new int[] { 90, 769 },
						_1 = null,
						_2 = null,
					},
					[378] = new Feature
					{
						_0 = new int[] { 122, 769 },
						_1 = null,
						_2 = null,
					},
					[379] = new Feature
					{
						_0 = new int[] { 90, 775 },
						_1 = null,
						_2 = null,
					},
					[380] = new Feature
					{
						_0 = new int[] { 122, 775 },
						_1 = null,
						_2 = null,
					},
					[381] = new Feature
					{
						_0 = new int[] { 90, 780 },
						_1 = null,
						_2 = null,
					},
					[382] = new Feature
					{
						_0 = new int[] { 122, 780 },
						_1 = null,
						_2 = null,
					},
					[383] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = new Dictionary<int, int> { [775] = 7835, },
					},
					[416] = new Feature
					{
						_0 = new int[] { 79, 795 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7900, [769] = 7898, [771] = 7904, [777] = 7902, [803] = 7906, },
					},
					[417] = new Feature
					{
						_0 = new int[] { 111, 795 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7901, [769] = 7899, [771] = 7905, [777] = 7903, [803] = 7907, },
					},
					[431] = new Feature
					{
						_0 = new int[] { 85, 795 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7914, [769] = 7912, [771] = 7918, [777] = 7916, [803] = 7920, },
					},
					[432] = new Feature
					{
						_0 = new int[] { 117, 795 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7915, [769] = 7913, [771] = 7919, [777] = 7917, [803] = 7921, },
					},
					[439] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [780] = 494, },
					},
					[452] = new Feature
					{
						_0 = new int[] { 68, 381 },
						_1 = 256,
						_2 = null,
					},
					[453] = new Feature
					{
						_0 = new int[] { 68, 382 },
						_1 = 256,
						_2 = null,
					},
					[454] = new Feature
					{
						_0 = new int[] { 100, 382 },
						_1 = 256,
						_2 = null,
					},
					[455] = new Feature
					{
						_0 = new int[] { 76, 74 },
						_1 = 256,
						_2 = null,
					},
					[456] = new Feature
					{
						_0 = new int[] { 76, 106 },
						_1 = 256,
						_2 = null,
					},
					[457] = new Feature
					{
						_0 = new int[] { 108, 106 },
						_1 = 256,
						_2 = null,
					},
					[458] = new Feature
					{
						_0 = new int[] { 78, 74 },
						_1 = 256,
						_2 = null,
					},
					[459] = new Feature
					{
						_0 = new int[] { 78, 106 },
						_1 = 256,
						_2 = null,
					},
					[460] = new Feature
					{
						_0 = new int[] { 110, 106 },
						_1 = 256,
						_2 = null,
					},
					[461] = new Feature
					{
						_0 = new int[] { 65, 780 },
						_1 = null,
						_2 = null,
					},
					[462] = new Feature
					{
						_0 = new int[] { 97, 780 },
						_1 = null,
						_2 = null,
					},
					[463] = new Feature
					{
						_0 = new int[] { 73, 780 },
						_1 = null,
						_2 = null,
					},
					[464] = new Feature
					{
						_0 = new int[] { 105, 780 },
						_1 = null,
						_2 = null,
					},
					[465] = new Feature
					{
						_0 = new int[] { 79, 780 },
						_1 = null,
						_2 = null,
					},
					[466] = new Feature
					{
						_0 = new int[] { 111, 780 },
						_1 = null,
						_2 = null,
					},
					[467] = new Feature
					{
						_0 = new int[] { 85, 780 },
						_1 = null,
						_2 = null,
					},
					[468] = new Feature
					{
						_0 = new int[] { 117, 780 },
						_1 = null,
						_2 = null,
					},
					[469] = new Feature
					{
						_0 = new int[] { 220, 772 },
						_1 = null,
						_2 = null,
					},
					[470] = new Feature
					{
						_0 = new int[] { 252, 772 },
						_1 = null,
						_2 = null,
					},
					[471] = new Feature
					{
						_0 = new int[] { 220, 769 },
						_1 = null,
						_2 = null,
					},
					[472] = new Feature
					{
						_0 = new int[] { 252, 769 },
						_1 = null,
						_2 = null,
					},
					[473] = new Feature
					{
						_0 = new int[] { 220, 780 },
						_1 = null,
						_2 = null,
					},
					[474] = new Feature
					{
						_0 = new int[] { 252, 780 },
						_1 = null,
						_2 = null,
					},
					[475] = new Feature
					{
						_0 = new int[] { 220, 768 },
						_1 = null,
						_2 = null,
					},
					[476] = new Feature
					{
						_0 = new int[] { 252, 768 },
						_1 = null,
						_2 = null,
					},
					[478] = new Feature
					{
						_0 = new int[] { 196, 772 },
						_1 = null,
						_2 = null,
					},
					[479] = new Feature
					{
						_0 = new int[] { 228, 772 },
						_1 = null,
						_2 = null,
					},
					[480] = new Feature
					{
						_0 = new int[] { 550, 772 },
						_1 = null,
						_2 = null,
					},
					[481] = new Feature
					{
						_0 = new int[] { 551, 772 },
						_1 = null,
						_2 = null,
					},
					[482] = new Feature
					{
						_0 = new int[] { 198, 772 },
						_1 = null,
						_2 = null,
					},
					[483] = new Feature
					{
						_0 = new int[] { 230, 772 },
						_1 = null,
						_2 = null,
					},
					[486] = new Feature
					{
						_0 = new int[] { 71, 780 },
						_1 = null,
						_2 = null,
					},
					[487] = new Feature
					{
						_0 = new int[] { 103, 780 },
						_1 = null,
						_2 = null,
					},
					[488] = new Feature
					{
						_0 = new int[] { 75, 780 },
						_1 = null,
						_2 = null,
					},
					[489] = new Feature
					{
						_0 = new int[] { 107, 780 },
						_1 = null,
						_2 = null,
					},
					[490] = new Feature
					{
						_0 = new int[] { 79, 808 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 492, },
					},
					[491] = new Feature
					{
						_0 = new int[] { 111, 808 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 493, },
					},
					[492] = new Feature
					{
						_0 = new int[] { 490, 772 },
						_1 = null,
						_2 = null,
					},
					[493] = new Feature
					{
						_0 = new int[] { 491, 772 },
						_1 = null,
						_2 = null,
					},
					[494] = new Feature
					{
						_0 = new int[] { 439, 780 },
						_1 = null,
						_2 = null,
					},
					[495] = new Feature
					{
						_0 = new int[] { 658, 780 },
						_1 = null,
						_2 = null,
					},
					[496] = new Feature
					{
						_0 = new int[] { 106, 780 },
						_1 = null,
						_2 = null,
					},
					[497] = new Feature
					{
						_0 = new int[] { 68, 90 },
						_1 = 256,
						_2 = null,
					},
					[498] = new Feature
					{
						_0 = new int[] { 68, 122 },
						_1 = 256,
						_2 = null,
					},
					[499] = new Feature
					{
						_0 = new int[] { 100, 122 },
						_1 = 256,
						_2 = null,
					},
					[500] = new Feature
					{
						_0 = new int[] { 71, 769 },
						_1 = null,
						_2 = null,
					},
					[501] = new Feature
					{
						_0 = new int[] { 103, 769 },
						_1 = null,
						_2 = null,
					},
					[504] = new Feature
					{
						_0 = new int[] { 78, 768 },
						_1 = null,
						_2 = null,
					},
					[505] = new Feature
					{
						_0 = new int[] { 110, 768 },
						_1 = null,
						_2 = null,
					},
					[506] = new Feature
					{
						_0 = new int[] { 197, 769 },
						_1 = null,
						_2 = null,
					},
					[507] = new Feature
					{
						_0 = new int[] { 229, 769 },
						_1 = null,
						_2 = null,
					},
					[508] = new Feature
					{
						_0 = new int[] { 198, 769 },
						_1 = null,
						_2 = null,
					},
					[509] = new Feature
					{
						_0 = new int[] { 230, 769 },
						_1 = null,
						_2 = null,
					},
					[510] = new Feature
					{
						_0 = new int[] { 216, 769 },
						_1 = null,
						_2 = null,
					},
					[511] = new Feature
					{
						_0 = new int[] { 248, 769 },
						_1 = null,
						_2 = null,
					},
					[66045] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[512] = new Dictionary<int, Feature>
				{
					[512] = new Feature
					{
						_0 = new int[] { 65, 783 },
						_1 = null,
						_2 = null,
					},
					[513] = new Feature
					{
						_0 = new int[] { 97, 783 },
						_1 = null,
						_2 = null,
					},
					[514] = new Feature
					{
						_0 = new int[] { 65, 785 },
						_1 = null,
						_2 = null,
					},
					[515] = new Feature
					{
						_0 = new int[] { 97, 785 },
						_1 = null,
						_2 = null,
					},
					[516] = new Feature
					{
						_0 = new int[] { 69, 783 },
						_1 = null,
						_2 = null,
					},
					[517] = new Feature
					{
						_0 = new int[] { 101, 783 },
						_1 = null,
						_2 = null,
					},
					[518] = new Feature
					{
						_0 = new int[] { 69, 785 },
						_1 = null,
						_2 = null,
					},
					[519] = new Feature
					{
						_0 = new int[] { 101, 785 },
						_1 = null,
						_2 = null,
					},
					[520] = new Feature
					{
						_0 = new int[] { 73, 783 },
						_1 = null,
						_2 = null,
					},
					[521] = new Feature
					{
						_0 = new int[] { 105, 783 },
						_1 = null,
						_2 = null,
					},
					[522] = new Feature
					{
						_0 = new int[] { 73, 785 },
						_1 = null,
						_2 = null,
					},
					[523] = new Feature
					{
						_0 = new int[] { 105, 785 },
						_1 = null,
						_2 = null,
					},
					[524] = new Feature
					{
						_0 = new int[] { 79, 783 },
						_1 = null,
						_2 = null,
					},
					[525] = new Feature
					{
						_0 = new int[] { 111, 783 },
						_1 = null,
						_2 = null,
					},
					[526] = new Feature
					{
						_0 = new int[] { 79, 785 },
						_1 = null,
						_2 = null,
					},
					[527] = new Feature
					{
						_0 = new int[] { 111, 785 },
						_1 = null,
						_2 = null,
					},
					[528] = new Feature
					{
						_0 = new int[] { 82, 783 },
						_1 = null,
						_2 = null,
					},
					[529] = new Feature
					{
						_0 = new int[] { 114, 783 },
						_1 = null,
						_2 = null,
					},
					[530] = new Feature
					{
						_0 = new int[] { 82, 785 },
						_1 = null,
						_2 = null,
					},
					[531] = new Feature
					{
						_0 = new int[] { 114, 785 },
						_1 = null,
						_2 = null,
					},
					[532] = new Feature
					{
						_0 = new int[] { 85, 783 },
						_1 = null,
						_2 = null,
					},
					[533] = new Feature
					{
						_0 = new int[] { 117, 783 },
						_1 = null,
						_2 = null,
					},
					[534] = new Feature
					{
						_0 = new int[] { 85, 785 },
						_1 = null,
						_2 = null,
					},
					[535] = new Feature
					{
						_0 = new int[] { 117, 785 },
						_1 = null,
						_2 = null,
					},
					[536] = new Feature
					{
						_0 = new int[] { 83, 806 },
						_1 = null,
						_2 = null,
					},
					[537] = new Feature
					{
						_0 = new int[] { 115, 806 },
						_1 = null,
						_2 = null,
					},
					[538] = new Feature
					{
						_0 = new int[] { 84, 806 },
						_1 = null,
						_2 = null,
					},
					[539] = new Feature
					{
						_0 = new int[] { 116, 806 },
						_1 = null,
						_2 = null,
					},
					[542] = new Feature
					{
						_0 = new int[] { 72, 780 },
						_1 = null,
						_2 = null,
					},
					[543] = new Feature
					{
						_0 = new int[] { 104, 780 },
						_1 = null,
						_2 = null,
					},
					[550] = new Feature
					{
						_0 = new int[] { 65, 775 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 480, },
					},
					[551] = new Feature
					{
						_0 = new int[] { 97, 775 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 481, },
					},
					[552] = new Feature
					{
						_0 = new int[] { 69, 807 },
						_1 = null,
						_2 = new Dictionary<int, int> { [774] = 7708, },
					},
					[553] = new Feature
					{
						_0 = new int[] { 101, 807 },
						_1 = null,
						_2 = new Dictionary<int, int> { [774] = 7709, },
					},
					[554] = new Feature
					{
						_0 = new int[] { 214, 772 },
						_1 = null,
						_2 = null,
					},
					[555] = new Feature
					{
						_0 = new int[] { 246, 772 },
						_1 = null,
						_2 = null,
					},
					[556] = new Feature
					{
						_0 = new int[] { 213, 772 },
						_1 = null,
						_2 = null,
					},
					[557] = new Feature
					{
						_0 = new int[] { 245, 772 },
						_1 = null,
						_2 = null,
					},
					[558] = new Feature
					{
						_0 = new int[] { 79, 775 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 560, },
					},
					[559] = new Feature
					{
						_0 = new int[] { 111, 775 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 561, },
					},
					[560] = new Feature
					{
						_0 = new int[] { 558, 772 },
						_1 = null,
						_2 = null,
					},
					[561] = new Feature
					{
						_0 = new int[] { 559, 772 },
						_1 = null,
						_2 = null,
					},
					[562] = new Feature
					{
						_0 = new int[] { 89, 772 },
						_1 = null,
						_2 = null,
					},
					[563] = new Feature
					{
						_0 = new int[] { 121, 772 },
						_1 = null,
						_2 = null,
					},
					[658] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [780] = 495, },
					},
					[688] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[689] = new Feature
					{
						_0 = new int[] { 614 },
						_1 = 256,
						_2 = null,
					},
					[690] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[691] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[692] = new Feature
					{
						_0 = new int[] { 633 },
						_1 = 256,
						_2 = null,
					},
					[693] = new Feature
					{
						_0 = new int[] { 635 },
						_1 = 256,
						_2 = null,
					},
					[694] = new Feature
					{
						_0 = new int[] { 641 },
						_1 = 256,
						_2 = null,
					},
					[695] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[696] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[728] = new Feature
					{
						_0 = new int[] { 32, 774 },
						_1 = 256,
						_2 = null,
					},
					[729] = new Feature
					{
						_0 = new int[] { 32, 775 },
						_1 = 256,
						_2 = null,
					},
					[730] = new Feature
					{
						_0 = new int[] { 32, 778 },
						_1 = 256,
						_2 = null,
					},
					[731] = new Feature
					{
						_0 = new int[] { 32, 808 },
						_1 = 256,
						_2 = null,
					},
					[732] = new Feature
					{
						_0 = new int[] { 32, 771 },
						_1 = 256,
						_2 = null,
					},
					[733] = new Feature
					{
						_0 = new int[] { 32, 779 },
						_1 = 256,
						_2 = null,
					},
					[736] = new Feature
					{
						_0 = new int[] { 611 },
						_1 = 256,
						_2 = null,
					},
					[737] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[738] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[739] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[740] = new Feature
					{
						_0 = new int[] { 661 },
						_1 = 256,
						_2 = null,
					},
					[66272] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[768] = new Dictionary<int, Feature>
				{
					[768] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[769] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[770] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[771] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[772] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[773] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[774] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[775] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[776] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = new Dictionary<int, int> { [769] = 836, },
					},
					[777] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[778] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[779] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[780] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[781] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[782] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[783] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[784] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[785] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[786] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[787] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[788] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[789] = new Feature
					{
						_0 = null,
						_1 = 232,
						_2 = null,
					},
					[790] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[791] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[792] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[793] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[794] = new Feature
					{
						_0 = null,
						_1 = 232,
						_2 = null,
					},
					[795] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[796] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[797] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[798] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[799] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[800] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[801] = new Feature
					{
						_0 = null,
						_1 = 202,
						_2 = null,
					},
					[802] = new Feature
					{
						_0 = null,
						_1 = 202,
						_2 = null,
					},
					[803] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[804] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[805] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[806] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[807] = new Feature
					{
						_0 = null,
						_1 = 202,
						_2 = null,
					},
					[808] = new Feature
					{
						_0 = null,
						_1 = 202,
						_2 = null,
					},
					[809] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[810] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[811] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[812] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[813] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[814] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[815] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[816] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[817] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[818] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[819] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[820] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[821] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[822] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[823] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[824] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[825] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[826] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[827] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[828] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[829] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[830] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[831] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[832] = new Feature
					{
						_0 = new int[] { 768 },
						_1 = 230,
						_2 = null,
					},
					[833] = new Feature
					{
						_0 = new int[] { 769 },
						_1 = 230,
						_2 = null,
					},
					[834] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[835] = new Feature
					{
						_0 = new int[] { 787 },
						_1 = 230,
						_2 = null,
					},
					[836] = new Feature
					{
						_0 = new int[] { 776, 769 },
						_1 = 230,
						_2 = null,
					},
					[837] = new Feature
					{
						_0 = null,
						_1 = 240,
						_2 = null,
					},
					[838] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[839] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[840] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[841] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[842] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[843] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[844] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[845] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[846] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[848] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[849] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[850] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[851] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[852] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[853] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[854] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[855] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[856] = new Feature
					{
						_0 = null,
						_1 = 232,
						_2 = null,
					},
					[857] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[858] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[859] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[860] = new Feature
					{
						_0 = null,
						_1 = 233,
						_2 = null,
					},
					[861] = new Feature
					{
						_0 = null,
						_1 = 234,
						_2 = null,
					},
					[862] = new Feature
					{
						_0 = null,
						_1 = 234,
						_2 = null,
					},
					[863] = new Feature
					{
						_0 = null,
						_1 = 233,
						_2 = null,
					},
					[864] = new Feature
					{
						_0 = null,
						_1 = 234,
						_2 = null,
					},
					[865] = new Feature
					{
						_0 = null,
						_1 = 234,
						_2 = null,
					},
					[866] = new Feature
					{
						_0 = null,
						_1 = 233,
						_2 = null,
					},
					[867] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[868] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[869] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[870] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[871] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[872] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[873] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[874] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[875] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[876] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[877] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[878] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[879] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[884] = new Feature
					{
						_0 = new int[] { 697 },
						_1 = null,
						_2 = null,
					},
					[890] = new Feature
					{
						_0 = new int[] { 32, 837 },
						_1 = 256,
						_2 = null,
					},
					[894] = new Feature
					{
						_0 = new int[] { 59 },
						_1 = null,
						_2 = null,
					},
					[900] = new Feature
					{
						_0 = new int[] { 32, 769 },
						_1 = 256,
						_2 = null,
					},
					[901] = new Feature
					{
						_0 = new int[] { 168, 769 },
						_1 = null,
						_2 = null,
					},
					[902] = new Feature
					{
						_0 = new int[] { 913, 769 },
						_1 = null,
						_2 = null,
					},
					[903] = new Feature
					{
						_0 = new int[] { 183 },
						_1 = null,
						_2 = null,
					},
					[904] = new Feature
					{
						_0 = new int[] { 917, 769 },
						_1 = null,
						_2 = null,
					},
					[905] = new Feature
					{
						_0 = new int[] { 919, 769 },
						_1 = null,
						_2 = null,
					},
					[906] = new Feature
					{
						_0 = new int[] { 921, 769 },
						_1 = null,
						_2 = null,
					},
					[908] = new Feature
					{
						_0 = new int[] { 927, 769 },
						_1 = null,
						_2 = null,
					},
					[910] = new Feature
					{
						_0 = new int[] { 933, 769 },
						_1 = null,
						_2 = null,
					},
					[911] = new Feature
					{
						_0 = new int[] { 937, 769 },
						_1 = null,
						_2 = null,
					},
					[912] = new Feature
					{
						_0 = new int[] { 970, 769 },
						_1 = null,
						_2 = null,
					},
					[913] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8122, [769] = 902, [772] = 8121, [774] = 8120, [787] = 7944, [788] = 7945, [837] = 8124, },
					},
					[917] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8136, [769] = 904, [787] = 7960, [788] = 7961, },
					},
					[919] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8138, [769] = 905, [787] = 7976, [788] = 7977, [837] = 8140, },
					},
					[921] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8154, [769] = 906, [772] = 8153, [774] = 8152, [776] = 938, [787] = 7992, [788] = 7993, },
					},
					[927] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8184, [769] = 908, [787] = 8008, [788] = 8009, },
					},
					[929] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [788] = 8172, },
					},
					[933] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8170, [769] = 910, [772] = 8169, [774] = 8168, [776] = 939, [788] = 8025, },
					},
					[937] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8186, [769] = 911, [787] = 8040, [788] = 8041, [837] = 8188, },
					},
					[938] = new Feature
					{
						_0 = new int[] { 921, 776 },
						_1 = null,
						_2 = null,
					},
					[939] = new Feature
					{
						_0 = new int[] { 933, 776 },
						_1 = null,
						_2 = null,
					},
					[940] = new Feature
					{
						_0 = new int[] { 945, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8116, },
					},
					[941] = new Feature
					{
						_0 = new int[] { 949, 769 },
						_1 = null,
						_2 = null,
					},
					[942] = new Feature
					{
						_0 = new int[] { 951, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8132, },
					},
					[943] = new Feature
					{
						_0 = new int[] { 953, 769 },
						_1 = null,
						_2 = null,
					},
					[944] = new Feature
					{
						_0 = new int[] { 971, 769 },
						_1 = null,
						_2 = null,
					},
					[945] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8048, [769] = 940, [772] = 8113, [774] = 8112, [787] = 7936, [788] = 7937, [834] = 8118, [837] = 8115, },
					},
					[949] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8050, [769] = 941, [787] = 7952, [788] = 7953, },
					},
					[951] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8052, [769] = 942, [787] = 7968, [788] = 7969, [834] = 8134, [837] = 8131, },
					},
					[953] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8054, [769] = 943, [772] = 8145, [774] = 8144, [776] = 970, [787] = 7984, [788] = 7985, [834] = 8150, },
					},
					[959] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8056, [769] = 972, [787] = 8000, [788] = 8001, },
					},
					[961] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [787] = 8164, [788] = 8165, },
					},
					[965] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8058, [769] = 973, [772] = 8161, [774] = 8160, [776] = 971, [787] = 8016, [788] = 8017, [834] = 8166, },
					},
					[969] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8060, [769] = 974, [787] = 8032, [788] = 8033, [834] = 8182, [837] = 8179, },
					},
					[970] = new Feature
					{
						_0 = new int[] { 953, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8146, [769] = 912, [834] = 8151, },
					},
					[971] = new Feature
					{
						_0 = new int[] { 965, 776 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8162, [769] = 944, [834] = 8167, },
					},
					[972] = new Feature
					{
						_0 = new int[] { 959, 769 },
						_1 = null,
						_2 = null,
					},
					[973] = new Feature
					{
						_0 = new int[] { 965, 769 },
						_1 = null,
						_2 = null,
					},
					[974] = new Feature
					{
						_0 = new int[] { 969, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8180, },
					},
					[976] = new Feature
					{
						_0 = new int[] { 946 },
						_1 = 256,
						_2 = null,
					},
					[977] = new Feature
					{
						_0 = new int[] { 952 },
						_1 = 256,
						_2 = null,
					},
					[978] = new Feature
					{
						_0 = new int[] { 933 },
						_1 = 256,
						_2 = new Dictionary<int, int> { [769] = 979, [776] = 980, },
					},
					[979] = new Feature
					{
						_0 = new int[] { 978, 769 },
						_1 = null,
						_2 = null,
					},
					[980] = new Feature
					{
						_0 = new int[] { 978, 776 },
						_1 = null,
						_2 = null,
					},
					[981] = new Feature
					{
						_0 = new int[] { 966 },
						_1 = 256,
						_2 = null,
					},
					[982] = new Feature
					{
						_0 = new int[] { 960 },
						_1 = 256,
						_2 = null,
					},
					[1008] = new Feature
					{
						_0 = new int[] { 954 },
						_1 = 256,
						_2 = null,
					},
					[1009] = new Feature
					{
						_0 = new int[] { 961 },
						_1 = 256,
						_2 = null,
					},
					[1010] = new Feature
					{
						_0 = new int[] { 962 },
						_1 = 256,
						_2 = null,
					},
					[1012] = new Feature
					{
						_0 = new int[] { 920 },
						_1 = 256,
						_2 = null,
					},
					[1013] = new Feature
					{
						_0 = new int[] { 949 },
						_1 = 256,
						_2 = null,
					},
					[1017] = new Feature
					{
						_0 = new int[] { 931 },
						_1 = 256,
						_2 = null,
					},
					[66422] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[66423] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[66424] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[66425] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[66426] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[1024] = new Dictionary<int, Feature>
				{
					[1024] = new Feature
					{
						_0 = new int[] { 1045, 768 },
						_1 = null,
						_2 = null,
					},
					[1025] = new Feature
					{
						_0 = new int[] { 1045, 776 },
						_1 = null,
						_2 = null,
					},
					[1027] = new Feature
					{
						_0 = new int[] { 1043, 769 },
						_1 = null,
						_2 = null,
					},
					[1030] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1031, },
					},
					[1031] = new Feature
					{
						_0 = new int[] { 1030, 776 },
						_1 = null,
						_2 = null,
					},
					[1036] = new Feature
					{
						_0 = new int[] { 1050, 769 },
						_1 = null,
						_2 = null,
					},
					[1037] = new Feature
					{
						_0 = new int[] { 1048, 768 },
						_1 = null,
						_2 = null,
					},
					[1038] = new Feature
					{
						_0 = new int[] { 1059, 774 },
						_1 = null,
						_2 = null,
					},
					[1040] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [774] = 1232, [776] = 1234, },
					},
					[1043] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 1027, },
					},
					[1045] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 1024, [774] = 1238, [776] = 1025, },
					},
					[1046] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [774] = 1217, [776] = 1244, },
					},
					[1047] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1246, },
					},
					[1048] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 1037, [772] = 1250, [774] = 1049, [776] = 1252, },
					},
					[1049] = new Feature
					{
						_0 = new int[] { 1048, 774 },
						_1 = null,
						_2 = null,
					},
					[1050] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 1036, },
					},
					[1054] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1254, },
					},
					[1059] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 1262, [774] = 1038, [776] = 1264, [779] = 1266, },
					},
					[1063] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1268, },
					},
					[1067] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1272, },
					},
					[1069] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1260, },
					},
					[1072] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [774] = 1233, [776] = 1235, },
					},
					[1075] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 1107, },
					},
					[1077] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 1104, [774] = 1239, [776] = 1105, },
					},
					[1078] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [774] = 1218, [776] = 1245, },
					},
					[1079] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1247, },
					},
					[1080] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 1117, [772] = 1251, [774] = 1081, [776] = 1253, },
					},
					[1081] = new Feature
					{
						_0 = new int[] { 1080, 774 },
						_1 = null,
						_2 = null,
					},
					[1082] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [769] = 1116, },
					},
					[1086] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1255, },
					},
					[1091] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 1263, [774] = 1118, [776] = 1265, [779] = 1267, },
					},
					[1095] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1269, },
					},
					[1099] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1273, },
					},
					[1101] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1261, },
					},
					[1104] = new Feature
					{
						_0 = new int[] { 1077, 768 },
						_1 = null,
						_2 = null,
					},
					[1105] = new Feature
					{
						_0 = new int[] { 1077, 776 },
						_1 = null,
						_2 = null,
					},
					[1107] = new Feature
					{
						_0 = new int[] { 1075, 769 },
						_1 = null,
						_2 = null,
					},
					[1110] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1111, },
					},
					[1111] = new Feature
					{
						_0 = new int[] { 1110, 776 },
						_1 = null,
						_2 = null,
					},
					[1116] = new Feature
					{
						_0 = new int[] { 1082, 769 },
						_1 = null,
						_2 = null,
					},
					[1117] = new Feature
					{
						_0 = new int[] { 1080, 768 },
						_1 = null,
						_2 = null,
					},
					[1118] = new Feature
					{
						_0 = new int[] { 1091, 774 },
						_1 = null,
						_2 = null,
					},
					[1140] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [783] = 1142, },
					},
					[1141] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [783] = 1143, },
					},
					[1142] = new Feature
					{
						_0 = new int[] { 1140, 783 },
						_1 = null,
						_2 = null,
					},
					[1143] = new Feature
					{
						_0 = new int[] { 1141, 783 },
						_1 = null,
						_2 = null,
					},
					[1155] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1156] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1157] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1158] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1159] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1217] = new Feature
					{
						_0 = new int[] { 1046, 774 },
						_1 = null,
						_2 = null,
					},
					[1218] = new Feature
					{
						_0 = new int[] { 1078, 774 },
						_1 = null,
						_2 = null,
					},
					[1232] = new Feature
					{
						_0 = new int[] { 1040, 774 },
						_1 = null,
						_2 = null,
					},
					[1233] = new Feature
					{
						_0 = new int[] { 1072, 774 },
						_1 = null,
						_2 = null,
					},
					[1234] = new Feature
					{
						_0 = new int[] { 1040, 776 },
						_1 = null,
						_2 = null,
					},
					[1235] = new Feature
					{
						_0 = new int[] { 1072, 776 },
						_1 = null,
						_2 = null,
					},
					[1238] = new Feature
					{
						_0 = new int[] { 1045, 774 },
						_1 = null,
						_2 = null,
					},
					[1239] = new Feature
					{
						_0 = new int[] { 1077, 774 },
						_1 = null,
						_2 = null,
					},
					[1240] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1242, },
					},
					[1241] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1243, },
					},
					[1242] = new Feature
					{
						_0 = new int[] { 1240, 776 },
						_1 = null,
						_2 = null,
					},
					[1243] = new Feature
					{
						_0 = new int[] { 1241, 776 },
						_1 = null,
						_2 = null,
					},
					[1244] = new Feature
					{
						_0 = new int[] { 1046, 776 },
						_1 = null,
						_2 = null,
					},
					[1245] = new Feature
					{
						_0 = new int[] { 1078, 776 },
						_1 = null,
						_2 = null,
					},
					[1246] = new Feature
					{
						_0 = new int[] { 1047, 776 },
						_1 = null,
						_2 = null,
					},
					[1247] = new Feature
					{
						_0 = new int[] { 1079, 776 },
						_1 = null,
						_2 = null,
					},
					[1250] = new Feature
					{
						_0 = new int[] { 1048, 772 },
						_1 = null,
						_2 = null,
					},
					[1251] = new Feature
					{
						_0 = new int[] { 1080, 772 },
						_1 = null,
						_2 = null,
					},
					[1252] = new Feature
					{
						_0 = new int[] { 1048, 776 },
						_1 = null,
						_2 = null,
					},
					[1253] = new Feature
					{
						_0 = new int[] { 1080, 776 },
						_1 = null,
						_2 = null,
					},
					[1254] = new Feature
					{
						_0 = new int[] { 1054, 776 },
						_1 = null,
						_2 = null,
					},
					[1255] = new Feature
					{
						_0 = new int[] { 1086, 776 },
						_1 = null,
						_2 = null,
					},
					[1256] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1258, },
					},
					[1257] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [776] = 1259, },
					},
					[1258] = new Feature
					{
						_0 = new int[] { 1256, 776 },
						_1 = null,
						_2 = null,
					},
					[1259] = new Feature
					{
						_0 = new int[] { 1257, 776 },
						_1 = null,
						_2 = null,
					},
					[1260] = new Feature
					{
						_0 = new int[] { 1069, 776 },
						_1 = null,
						_2 = null,
					},
					[1261] = new Feature
					{
						_0 = new int[] { 1101, 776 },
						_1 = null,
						_2 = null,
					},
					[1262] = new Feature
					{
						_0 = new int[] { 1059, 772 },
						_1 = null,
						_2 = null,
					},
					[1263] = new Feature
					{
						_0 = new int[] { 1091, 772 },
						_1 = null,
						_2 = null,
					},
					[1264] = new Feature
					{
						_0 = new int[] { 1059, 776 },
						_1 = null,
						_2 = null,
					},
					[1265] = new Feature
					{
						_0 = new int[] { 1091, 776 },
						_1 = null,
						_2 = null,
					},
					[1266] = new Feature
					{
						_0 = new int[] { 1059, 779 },
						_1 = null,
						_2 = null,
					},
					[1267] = new Feature
					{
						_0 = new int[] { 1091, 779 },
						_1 = null,
						_2 = null,
					},
					[1268] = new Feature
					{
						_0 = new int[] { 1063, 776 },
						_1 = null,
						_2 = null,
					},
					[1269] = new Feature
					{
						_0 = new int[] { 1095, 776 },
						_1 = null,
						_2 = null,
					},
					[1272] = new Feature
					{
						_0 = new int[] { 1067, 776 },
						_1 = null,
						_2 = null,
					},
					[1273] = new Feature
					{
						_0 = new int[] { 1099, 776 },
						_1 = null,
						_2 = null,
					},
				},
				[1280] = new Dictionary<int, Feature>
				{
					[1415] = new Feature
					{
						_0 = new int[] { 1381, 1410 },
						_1 = 256,
						_2 = null,
					},
					[1425] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1426] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1427] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1428] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1429] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1430] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1431] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1432] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1433] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1434] = new Feature
					{
						_0 = null,
						_1 = 222,
						_2 = null,
					},
					[1435] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1436] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1437] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1438] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1439] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1440] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1441] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1442] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1443] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1444] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1445] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1446] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1447] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1448] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1449] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1450] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1451] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1452] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1453] = new Feature
					{
						_0 = null,
						_1 = 222,
						_2 = null,
					},
					[1454] = new Feature
					{
						_0 = null,
						_1 = 228,
						_2 = null,
					},
					[1455] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1456] = new Feature
					{
						_0 = null,
						_1 = 10,
						_2 = null,
					},
					[1457] = new Feature
					{
						_0 = null,
						_1 = 11,
						_2 = null,
					},
					[1458] = new Feature
					{
						_0 = null,
						_1 = 12,
						_2 = null,
					},
					[1459] = new Feature
					{
						_0 = null,
						_1 = 13,
						_2 = null,
					},
					[1460] = new Feature
					{
						_0 = null,
						_1 = 14,
						_2 = null,
					},
					[1461] = new Feature
					{
						_0 = null,
						_1 = 15,
						_2 = null,
					},
					[1462] = new Feature
					{
						_0 = null,
						_1 = 16,
						_2 = null,
					},
					[1463] = new Feature
					{
						_0 = null,
						_1 = 17,
						_2 = null,
					},
					[1464] = new Feature
					{
						_0 = null,
						_1 = 18,
						_2 = null,
					},
					[1465] = new Feature
					{
						_0 = null,
						_1 = 19,
						_2 = null,
					},
					[1466] = new Feature
					{
						_0 = null,
						_1 = 19,
						_2 = null,
					},
					[1467] = new Feature
					{
						_0 = null,
						_1 = 20,
						_2 = null,
					},
					[1468] = new Feature
					{
						_0 = null,
						_1 = 21,
						_2 = null,
					},
					[1469] = new Feature
					{
						_0 = null,
						_1 = 22,
						_2 = null,
					},
					[1471] = new Feature
					{
						_0 = null,
						_1 = 23,
						_2 = null,
					},
					[1473] = new Feature
					{
						_0 = null,
						_1 = 24,
						_2 = null,
					},
					[1474] = new Feature
					{
						_0 = null,
						_1 = 25,
						_2 = null,
					},
					[1476] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1477] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1479] = new Feature
					{
						_0 = null,
						_1 = 18,
						_2 = null,
					},
				},
				[1536] = new Dictionary<int, Feature>
				{
					[1552] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1553] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1554] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1555] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1556] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1557] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1558] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1559] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1560] = new Feature
					{
						_0 = null,
						_1 = 30,
						_2 = null,
					},
					[1561] = new Feature
					{
						_0 = null,
						_1 = 31,
						_2 = null,
					},
					[1562] = new Feature
					{
						_0 = null,
						_1 = 32,
						_2 = null,
					},
					[1570] = new Feature
					{
						_0 = new int[] { 1575, 1619 },
						_1 = null,
						_2 = null,
					},
					[1571] = new Feature
					{
						_0 = new int[] { 1575, 1620 },
						_1 = null,
						_2 = null,
					},
					[1572] = new Feature
					{
						_0 = new int[] { 1608, 1620 },
						_1 = null,
						_2 = null,
					},
					[1573] = new Feature
					{
						_0 = new int[] { 1575, 1621 },
						_1 = null,
						_2 = null,
					},
					[1574] = new Feature
					{
						_0 = new int[] { 1610, 1620 },
						_1 = null,
						_2 = null,
					},
					[1575] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [1619] = 1570, [1620] = 1571, [1621] = 1573, },
					},
					[1608] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [1620] = 1572, },
					},
					[1610] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [1620] = 1574, },
					},
					[1611] = new Feature
					{
						_0 = null,
						_1 = 27,
						_2 = null,
					},
					[1612] = new Feature
					{
						_0 = null,
						_1 = 28,
						_2 = null,
					},
					[1613] = new Feature
					{
						_0 = null,
						_1 = 29,
						_2 = null,
					},
					[1614] = new Feature
					{
						_0 = null,
						_1 = 30,
						_2 = null,
					},
					[1615] = new Feature
					{
						_0 = null,
						_1 = 31,
						_2 = null,
					},
					[1616] = new Feature
					{
						_0 = null,
						_1 = 32,
						_2 = null,
					},
					[1617] = new Feature
					{
						_0 = null,
						_1 = 33,
						_2 = null,
					},
					[1618] = new Feature
					{
						_0 = null,
						_1 = 34,
						_2 = null,
					},
					[1619] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1620] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1621] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1622] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1623] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1624] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1625] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1626] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1627] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1628] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1629] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1630] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1631] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1648] = new Feature
					{
						_0 = null,
						_1 = 35,
						_2 = null,
					},
					[1653] = new Feature
					{
						_0 = new int[] { 1575, 1652 },
						_1 = 256,
						_2 = null,
					},
					[1654] = new Feature
					{
						_0 = new int[] { 1608, 1652 },
						_1 = 256,
						_2 = null,
					},
					[1655] = new Feature
					{
						_0 = new int[] { 1735, 1652 },
						_1 = 256,
						_2 = null,
					},
					[1656] = new Feature
					{
						_0 = new int[] { 1610, 1652 },
						_1 = 256,
						_2 = null,
					},
					[1728] = new Feature
					{
						_0 = new int[] { 1749, 1620 },
						_1 = null,
						_2 = null,
					},
					[1729] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [1620] = 1730, },
					},
					[1730] = new Feature
					{
						_0 = new int[] { 1729, 1620 },
						_1 = null,
						_2 = null,
					},
					[1746] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [1620] = 1747, },
					},
					[1747] = new Feature
					{
						_0 = new int[] { 1746, 1620 },
						_1 = null,
						_2 = null,
					},
					[1749] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [1620] = 1728, },
					},
					[1750] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1751] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1752] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1753] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1754] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1755] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1756] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1759] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1760] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1761] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1762] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1763] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1764] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1767] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1768] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1770] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1771] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1772] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1773] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[1792] = new Dictionary<int, Feature>
				{
					[1809] = new Feature
					{
						_0 = null,
						_1 = 36,
						_2 = null,
					},
					[1840] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1841] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1842] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1843] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1844] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1845] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1846] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1847] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1848] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1849] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1850] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1851] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1852] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1853] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1854] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1855] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1856] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1857] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1858] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1859] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1860] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1861] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1862] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1863] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1864] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[1865] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[1866] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2027] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2028] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2029] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2030] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2031] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2032] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2033] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2034] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2035] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[2048] = new Dictionary<int, Feature>
				{
					[2070] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2071] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2072] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2073] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2075] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2076] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2077] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2078] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2079] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2080] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2081] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2082] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2083] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2085] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2086] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2087] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2089] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2090] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2091] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2092] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2093] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2137] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2138] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2139] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2275] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2276] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2277] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2278] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2279] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2280] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2281] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2282] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2283] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2284] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2285] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2286] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2287] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2288] = new Feature
					{
						_0 = null,
						_1 = 27,
						_2 = null,
					},
					[2289] = new Feature
					{
						_0 = null,
						_1 = 28,
						_2 = null,
					},
					[2290] = new Feature
					{
						_0 = null,
						_1 = 29,
						_2 = null,
					},
					[2291] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2292] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2293] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2294] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2295] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2296] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2297] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2298] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2299] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2300] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2301] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2302] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2303] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[2304] = new Dictionary<int, Feature>
				{
					[2344] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [2364] = 2345, },
					},
					[2345] = new Feature
					{
						_0 = new int[] { 2344, 2364 },
						_1 = null,
						_2 = null,
					},
					[2352] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [2364] = 2353, },
					},
					[2353] = new Feature
					{
						_0 = new int[] { 2352, 2364 },
						_1 = null,
						_2 = null,
					},
					[2355] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [2364] = 2356, },
					},
					[2356] = new Feature
					{
						_0 = new int[] { 2355, 2364 },
						_1 = null,
						_2 = null,
					},
					[2364] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[2381] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[2385] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2386] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[2387] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2388] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[2392] = new Feature
					{
						_0 = new int[] { 2325, 2364 },
						_1 = 512,
						_2 = null,
					},
					[2393] = new Feature
					{
						_0 = new int[] { 2326, 2364 },
						_1 = 512,
						_2 = null,
					},
					[2394] = new Feature
					{
						_0 = new int[] { 2327, 2364 },
						_1 = 512,
						_2 = null,
					},
					[2395] = new Feature
					{
						_0 = new int[] { 2332, 2364 },
						_1 = 512,
						_2 = null,
					},
					[2396] = new Feature
					{
						_0 = new int[] { 2337, 2364 },
						_1 = 512,
						_2 = null,
					},
					[2397] = new Feature
					{
						_0 = new int[] { 2338, 2364 },
						_1 = 512,
						_2 = null,
					},
					[2398] = new Feature
					{
						_0 = new int[] { 2347, 2364 },
						_1 = 512,
						_2 = null,
					},
					[2399] = new Feature
					{
						_0 = new int[] { 2351, 2364 },
						_1 = 512,
						_2 = null,
					},
					[2492] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[2503] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [2494] = 2507, [2519] = 2508, },
					},
					[2507] = new Feature
					{
						_0 = new int[] { 2503, 2494 },
						_1 = null,
						_2 = null,
					},
					[2508] = new Feature
					{
						_0 = new int[] { 2503, 2519 },
						_1 = null,
						_2 = null,
					},
					[2509] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[2524] = new Feature
					{
						_0 = new int[] { 2465, 2492 },
						_1 = 512,
						_2 = null,
					},
					[2525] = new Feature
					{
						_0 = new int[] { 2466, 2492 },
						_1 = 512,
						_2 = null,
					},
					[2527] = new Feature
					{
						_0 = new int[] { 2479, 2492 },
						_1 = 512,
						_2 = null,
					},
				},
				[2560] = new Dictionary<int, Feature>
				{
					[2611] = new Feature
					{
						_0 = new int[] { 2610, 2620 },
						_1 = 512,
						_2 = null,
					},
					[2614] = new Feature
					{
						_0 = new int[] { 2616, 2620 },
						_1 = 512,
						_2 = null,
					},
					[2620] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[2637] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[2649] = new Feature
					{
						_0 = new int[] { 2582, 2620 },
						_1 = 512,
						_2 = null,
					},
					[2650] = new Feature
					{
						_0 = new int[] { 2583, 2620 },
						_1 = 512,
						_2 = null,
					},
					[2651] = new Feature
					{
						_0 = new int[] { 2588, 2620 },
						_1 = 512,
						_2 = null,
					},
					[2654] = new Feature
					{
						_0 = new int[] { 2603, 2620 },
						_1 = 512,
						_2 = null,
					},
					[2748] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[2765] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[68109] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[68111] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[68152] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[68153] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[68154] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[68159] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[68325] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[68326] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[2816] = new Dictionary<int, Feature>
				{
					[2876] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[2887] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [2878] = 2891, [2902] = 2888, [2903] = 2892, },
					},
					[2888] = new Feature
					{
						_0 = new int[] { 2887, 2902 },
						_1 = null,
						_2 = null,
					},
					[2891] = new Feature
					{
						_0 = new int[] { 2887, 2878 },
						_1 = null,
						_2 = null,
					},
					[2892] = new Feature
					{
						_0 = new int[] { 2887, 2903 },
						_1 = null,
						_2 = null,
					},
					[2893] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[2908] = new Feature
					{
						_0 = new int[] { 2849, 2876 },
						_1 = 512,
						_2 = null,
					},
					[2909] = new Feature
					{
						_0 = new int[] { 2850, 2876 },
						_1 = 512,
						_2 = null,
					},
					[2962] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3031] = 2964, },
					},
					[2964] = new Feature
					{
						_0 = new int[] { 2962, 3031 },
						_1 = null,
						_2 = null,
					},
					[3014] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3006] = 3018, [3031] = 3020, },
					},
					[3015] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3006] = 3019, },
					},
					[3018] = new Feature
					{
						_0 = new int[] { 3014, 3006 },
						_1 = null,
						_2 = null,
					},
					[3019] = new Feature
					{
						_0 = new int[] { 3015, 3006 },
						_1 = null,
						_2 = null,
					},
					[3020] = new Feature
					{
						_0 = new int[] { 3014, 3031 },
						_1 = null,
						_2 = null,
					},
					[3021] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
				},
				[3072] = new Dictionary<int, Feature>
				{
					[3142] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3158] = 3144, },
					},
					[3144] = new Feature
					{
						_0 = new int[] { 3142, 3158 },
						_1 = null,
						_2 = null,
					},
					[3149] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[3157] = new Feature
					{
						_0 = null,
						_1 = 84,
						_2 = null,
					},
					[3158] = new Feature
					{
						_0 = null,
						_1 = 91,
						_2 = null,
					},
					[3260] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[3263] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3285] = 3264, },
					},
					[3264] = new Feature
					{
						_0 = new int[] { 3263, 3285 },
						_1 = null,
						_2 = null,
					},
					[3270] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3266] = 3274, [3285] = 3271, [3286] = 3272, },
					},
					[3271] = new Feature
					{
						_0 = new int[] { 3270, 3285 },
						_1 = null,
						_2 = null,
					},
					[3272] = new Feature
					{
						_0 = new int[] { 3270, 3286 },
						_1 = null,
						_2 = null,
					},
					[3274] = new Feature
					{
						_0 = new int[] { 3270, 3266 },
						_1 = null,
						_2 = new Dictionary<int, int> { [3285] = 3275, },
					},
					[3275] = new Feature
					{
						_0 = new int[] { 3274, 3285 },
						_1 = null,
						_2 = null,
					},
					[3277] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
				},
				[3328] = new Dictionary<int, Feature>
				{
					[3398] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3390] = 3402, [3415] = 3404, },
					},
					[3399] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3390] = 3403, },


					},
					[3402] = new Feature
					{
						_0 = new int[] { 3398, 3390 },
						_1 = null,
						_2 = null,
					},
					[3403] = new Feature
					{
						_0 = new int[] { 3399, 3390 },
						_1 = null,
						_2 = null,
					},
					[3404] = new Feature
					{
						_0 = new int[] { 3398, 3415 },
						_1 = null,
						_2 = null,
					},
					[3405] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[3530] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[3545] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [3530] = 3546, [3535] = 3548, [3551] = 3550, },
					},
					[3546] = new Feature
					{
						_0 = new int[] { 3545, 3530 },
						_1 = null,
						_2 = null,
					},
					[3548] = new Feature
					{
						_0 = new int[] { 3545, 3535 },
						_1 = null,
						_2 = new Dictionary<int, int> { [3530] = 3549, },
					},
					[3549] = new Feature
					{
						_0 = new int[] { 3548, 3530 },
						_1 = null,
						_2 = null,
					},
					[3550] = new Feature
					{
						_0 = new int[] { 3545, 3551 },
						_1 = null,
						_2 = null,
					},
				},
				[3584] = new Dictionary<int, Feature>
				{
					[3635] = new Feature
					{
						_0 = new int[] { 3661, 3634 },
						_1 = 256,
						_2 = null,
					},
					[3640] = new Feature
					{
						_0 = null,
						_1 = 103,
						_2 = null,
					},
					[3641] = new Feature
					{
						_0 = null,
						_1 = 103,
						_2 = null,
					},
					[3642] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[3656] = new Feature
					{
						_0 = null,
						_1 = 107,
						_2 = null,
					},
					[3657] = new Feature
					{
						_0 = null,
						_1 = 107,
						_2 = null,
					},
					[3658] = new Feature
					{
						_0 = null,
						_1 = 107,
						_2 = null,
					},
					[3659] = new Feature
					{
						_0 = null,
						_1 = 107,
						_2 = null,
					},
					[3763] = new Feature
					{
						_0 = new int[] { 3789, 3762 },
						_1 = 256,
						_2 = null,
					},
					[3768] = new Feature
					{
						_0 = null,
						_1 = 118,
						_2 = null,
					},
					[3769] = new Feature
					{
						_0 = null,
						_1 = 118,
						_2 = null,
					},
					[3784] = new Feature
					{
						_0 = null,
						_1 = 122,
						_2 = null,
					},
					[3785] = new Feature
					{
						_0 = null,
						_1 = 122,
						_2 = null,
					},
					[3786] = new Feature
					{
						_0 = null,
						_1 = 122,
						_2 = null,
					},
					[3787] = new Feature
					{
						_0 = null,
						_1 = 122,
						_2 = null,
					},
					[3804] = new Feature
					{
						_0 = new int[] { 3755, 3737 },
						_1 = 256,
						_2 = null,
					},
					[3805] = new Feature
					{
						_0 = new int[] { 3755, 3745 },
						_1 = 256,
						_2 = null,
					},
				},
				[3840] = new Dictionary<int, Feature>
				{
					[3852] = new Feature
					{
						_0 = new int[] { 3851 },
						_1 = 256,
						_2 = null,
					},
					[3864] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[3865] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[3893] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[3895] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[3897] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[3907] = new Feature
					{
						_0 = new int[] { 3906, 4023 },
						_1 = 512,
						_2 = null,
					},
					[3917] = new Feature
					{
						_0 = new int[] { 3916, 4023 },
						_1 = 512,
						_2 = null,
					},
					[3922] = new Feature
					{
						_0 = new int[] { 3921, 4023 },
						_1 = 512,
						_2 = null,
					},
					[3927] = new Feature
					{
						_0 = new int[] { 3926, 4023 },
						_1 = 512,
						_2 = null,
					},
					[3932] = new Feature
					{
						_0 = new int[] { 3931, 4023 },
						_1 = 512,
						_2 = null,
					},
					[3945] = new Feature
					{
						_0 = new int[] { 3904, 4021 },
						_1 = 512,
						_2 = null,
					},
					[3953] = new Feature
					{
						_0 = null,
						_1 = 129,
						_2 = null,
					},
					[3954] = new Feature
					{
						_0 = null,
						_1 = 130,
						_2 = null,
					},
					[3955] = new Feature
					{
						_0 = new int[] { 3953, 3954 },
						_1 = 512,
						_2 = null,
					},
					[3956] = new Feature
					{
						_0 = null,
						_1 = 132,
						_2 = null,
					},
					[3957] = new Feature
					{
						_0 = new int[] { 3953, 3956 },
						_1 = 512,
						_2 = null,
					},
					[3958] = new Feature
					{
						_0 = new int[] { 4018, 3968 },
						_1 = 512,
						_2 = null,
					},
					[3959] = new Feature
					{
						_0 = new int[] { 4018, 3969 },
						_1 = 256,
						_2 = null,
					},
					[3960] = new Feature
					{
						_0 = new int[] { 4019, 3968 },
						_1 = 512,
						_2 = null,
					},
					[3961] = new Feature
					{
						_0 = new int[] { 4019, 3969 },
						_1 = 256,
						_2 = null,
					},
					[3962] = new Feature
					{
						_0 = null,
						_1 = 130,
						_2 = null,
					},
					[3963] = new Feature
					{
						_0 = null,
						_1 = 130,
						_2 = null,
					},
					[3964] = new Feature
					{
						_0 = null,
						_1 = 130,
						_2 = null,
					},
					[3965] = new Feature
					{
						_0 = null,
						_1 = 130,
						_2 = null,
					},
					[3968] = new Feature
					{
						_0 = null,
						_1 = 130,
						_2 = null,
					},
					[3969] = new Feature
					{
						_0 = new int[] { 3953, 3968 },
						_1 = 512,
						_2 = null,
					},
					[3970] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[3971] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[3972] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[3974] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[3975] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[3987] = new Feature
					{
						_0 = new int[] { 3986, 4023 },
						_1 = 512,
						_2 = null,
					},
					[3997] = new Feature
					{
						_0 = new int[] { 3996, 4023 },
						_1 = 512,
						_2 = null,
					},
					[4002] = new Feature
					{
						_0 = new int[] { 4001, 4023 },
						_1 = 512,
						_2 = null,
					},
					[4007] = new Feature
					{
						_0 = new int[] { 4006, 4023 },
						_1 = 512,
						_2 = null,
					},
					[4012] = new Feature
					{
						_0 = new int[] { 4011, 4023 },
						_1 = 512,
						_2 = null,
					},
					[4025] = new Feature
					{
						_0 = new int[] { 3984, 4021 },
						_1 = 512,
						_2 = null,
					},
					[4038] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[4096] = new Dictionary<int, Feature>
				{
					[4133] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [4142] = 4134, },
					},
					[4134] = new Feature
					{
						_0 = new int[] { 4133, 4142 },
						_1 = null,
						_2 = null,
					},
					[4151] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[4153] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[4154] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[4237] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[4348] = new Feature
					{
						_0 = new int[] { 4316 },
						_1 = 256,
						_2 = null,
					},
					[69702] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[69759] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[69785] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [69818] = 69786, },
					},
					[69786] = new Feature
					{
						_0 = new int[] { 69785, 69818 },
						_1 = null,
						_2 = null,
					},
					[69787] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [69818] = 69788, },
					},
					[69788] = new Feature
					{
						_0 = new int[] { 69787, 69818 },
						_1 = null,
						_2 = null,
					},
					[69797] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [69818] = 69803, },
					},
					[69803] = new Feature
					{
						_0 = new int[] { 69797, 69818 },
						_1 = null,
						_2 = null,
					},
					[69817] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[69818] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
				},
				[4352] = new Dictionary<int, Feature>
				{
					[69888] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[69889] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[69890] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[69934] = new Feature
					{
						_0 = new int[] { 69937, 69927 },
						_1 = null,
						_2 = null,
					},
					[69935] = new Feature
					{
						_0 = new int[] { 69938, 69927 },
						_1 = null,
						_2 = null,
					},
					[69937] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [69927] = 69934, },
					},
					[69938] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [69927] = 69935, },
					},
					[69939] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[69940] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[70003] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[70080] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[70090] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
				},
				[4608] = new Dictionary<int, Feature>
				{
					[70197] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[70198] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[70377] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[70378] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
				},
				[4864] = new Dictionary<int, Feature>
				{
					[4957] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[4958] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[4959] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70460] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[70471] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [70462] = 70475, [70487] = 70476, },
					},
					[70475] = new Feature
					{
						_0 = new int[] { 70471, 70462 },
						_1 = null,
						_2 = null,
					},
					[70476] = new Feature
					{
						_0 = new int[] { 70471, 70487 },
						_1 = null,
						_2 = null,
					},
					[70477] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[70502] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70503] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70504] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70505] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70506] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70507] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70508] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70512] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70513] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70514] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70515] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[70516] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[5120] = new Dictionary<int, Feature>
				{
					[70841] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [70832] = 70844, [70842] = 70843, [70845] = 70846, },
					},
					[70843] = new Feature
					{
						_0 = new int[] { 70841, 70842 },
						_1 = null,
						_2 = null,
					},
					[70844] = new Feature
					{
						_0 = new int[] { 70841, 70832 },
						_1 = null,
						_2 = null,
					},
					[70846] = new Feature
					{
						_0 = new int[] { 70841, 70845 },
						_1 = null,
						_2 = null,
					},
					[70850] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[70851] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
				},
				[5376] = new Dictionary<int, Feature>
				{
					[71096] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [71087] = 71098, },
					},
					[71097] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [71087] = 71099, },
					},
					[71098] = new Feature
					{
						_0 = new int[] { 71096, 71087 },
						_1 = null,
						_2 = null,
					},
					[71099] = new Feature
					{
						_0 = new int[] { 71097, 71087 },
						_1 = null,
						_2 = null,
					},
					[71103] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[71104] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
				},
				[5632] = new Dictionary<int, Feature>
				{
					[71231] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[71350] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[71351] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
				},
				[5888] = new Dictionary<int, Feature>
				{
					[5908] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[5940] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[6098] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[6109] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[71467] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
				},
				[6144] = new Dictionary<int, Feature>
				{
					[6313] = new Feature
					{
						_0 = null,
						_1 = 228,
						_2 = null,
					},
				},
				[6400] = new Dictionary<int, Feature>
				{
					[6457] = new Feature
					{
						_0 = null,
						_1 = 222,
						_2 = null,
					},
					[6458] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6459] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[6656] = new Dictionary<int, Feature>
				{
					[6679] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6680] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[6752] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[6773] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6774] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6775] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6776] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6777] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6778] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6779] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6780] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6783] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[6832] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6833] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6834] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6835] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6836] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6837] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[6838] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[6839] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[6840] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[6841] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[6842] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[6843] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6844] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[6845] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[6912] = new Dictionary<int, Feature>
				{
					[6917] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6918, },
					},
					[6918] = new Feature
					{
						_0 = new int[] { 6917, 6965 },
						_1 = null,
						_2 = null,
					},
					[6919] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6920, },
					},
					[6920] = new Feature
					{
						_0 = new int[] { 6919, 6965 },
						_1 = null,
						_2 = null,
					},
					[6921] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6922, },
					},
					[6922] = new Feature
					{
						_0 = new int[] { 6921, 6965 },
						_1 = null,
						_2 = null,
					},
					[6923] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6924, },
					},
					[6924] = new Feature
					{
						_0 = new int[] { 6923, 6965 },
						_1 = null,
						_2 = null,
					},
					[6925] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6926, },
					},
					[6926] = new Feature
					{
						_0 = new int[] { 6925, 6965 },
						_1 = null,
						_2 = null,
					},
					[6929] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6930, },
					},
					[6930] = new Feature
					{
						_0 = new int[] { 6929, 6965 },
						_1 = null,
						_2 = null,
					},
					[6964] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[6970] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6971, },
					},
					[6971] = new Feature
					{
						_0 = new int[] { 6970, 6965 },
						_1 = null,
						_2 = null,
					},
					[6972] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6973, },
					},
					[6973] = new Feature
					{
						_0 = new int[] { 6972, 6965 },
						_1 = null,
						_2 = null,
					},
					[6974] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6976, },
					},
					[6975] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6977, },
					},
					[6976] = new Feature
					{
						_0 = new int[] { 6974, 6965 },
						_1 = null,
						_2 = null,
					},
					[6977] = new Feature
					{
						_0 = new int[] { 6975, 6965 },
						_1 = null,
						_2 = null,
					},
					[6978] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [6965] = 6979, },
					},
					[6979] = new Feature
					{
						_0 = new int[] { 6978, 6965 },
						_1 = null,
						_2 = null,
					},
					[6980] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[7019] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7020] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7021] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7022] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7023] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7024] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7025] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7026] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7027] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7082] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[7083] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[7142] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[7154] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[7155] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
				},
				[7168] = new Dictionary<int, Feature>
				{
					[7223] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[7376] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7377] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7378] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7380] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[7381] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7382] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7383] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7384] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7385] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7386] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7387] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7388] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7389] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7390] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7391] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7392] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7394] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[7395] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[7396] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[7397] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[7398] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[7399] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[7400] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[7405] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7412] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7416] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7417] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[7424] = new Dictionary<int, Feature>
				{
					[7468] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[7469] = new Feature
					{
						_0 = new int[] { 198 },
						_1 = 256,
						_2 = null,
					},
					[7470] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[7472] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[7473] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[7474] = new Feature
					{
						_0 = new int[] { 398 },
						_1 = 256,
						_2 = null,
					},
					[7475] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[7476] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[7477] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[7478] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[7479] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[7480] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[7481] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[7482] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[7484] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[7485] = new Feature
					{
						_0 = new int[] { 546 },
						_1 = 256,
						_2 = null,
					},
					[7486] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[7487] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[7488] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[7489] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[7490] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[7491] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[7492] = new Feature
					{
						_0 = new int[] { 592 },
						_1 = 256,
						_2 = null,
					},
					[7493] = new Feature
					{
						_0 = new int[] { 593 },
						_1 = 256,
						_2 = null,
					},
					[7494] = new Feature
					{
						_0 = new int[] { 7426 },
						_1 = 256,
						_2 = null,
					},
					[7495] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[7496] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[7497] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[7498] = new Feature
					{
						_0 = new int[] { 601 },
						_1 = 256,
						_2 = null,
					},
					[7499] = new Feature
					{
						_0 = new int[] { 603 },
						_1 = 256,
						_2 = null,
					},
					[7500] = new Feature
					{
						_0 = new int[] { 604 },
						_1 = 256,
						_2 = null,
					},
					[7501] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[7503] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[7504] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[7505] = new Feature
					{
						_0 = new int[] { 331 },
						_1 = 256,
						_2 = null,
					},
					[7506] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[7507] = new Feature
					{
						_0 = new int[] { 596 },
						_1 = 256,
						_2 = null,
					},
					[7508] = new Feature
					{
						_0 = new int[] { 7446 },
						_1 = 256,
						_2 = null,
					},
					[7509] = new Feature
					{
						_0 = new int[] { 7447 },
						_1 = 256,
						_2 = null,
					},
					[7510] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[7511] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[7512] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[7513] = new Feature
					{
						_0 = new int[] { 7453 },
						_1 = 256,
						_2 = null,
					},
					[7514] = new Feature
					{
						_0 = new int[] { 623 },
						_1 = 256,
						_2 = null,
					},
					[7515] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[7516] = new Feature
					{
						_0 = new int[] { 7461 },
						_1 = 256,
						_2 = null,
					},
					[7517] = new Feature
					{
						_0 = new int[] { 946 },
						_1 = 256,
						_2 = null,
					},
					[7518] = new Feature
					{
						_0 = new int[] { 947 },
						_1 = 256,
						_2 = null,
					},
					[7519] = new Feature
					{
						_0 = new int[] { 948 },
						_1 = 256,
						_2 = null,
					},
					[7520] = new Feature
					{
						_0 = new int[] { 966 },
						_1 = 256,
						_2 = null,
					},
					[7521] = new Feature
					{
						_0 = new int[] { 967 },
						_1 = 256,
						_2 = null,
					},
					[7522] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[7523] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[7524] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[7525] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[7526] = new Feature
					{
						_0 = new int[] { 946 },
						_1 = 256,
						_2 = null,
					},
					[7527] = new Feature
					{
						_0 = new int[] { 947 },
						_1 = 256,
						_2 = null,
					},
					[7528] = new Feature
					{
						_0 = new int[] { 961 },
						_1 = 256,
						_2 = null,
					},
					[7529] = new Feature
					{
						_0 = new int[] { 966 },
						_1 = 256,
						_2 = null,
					},
					[7530] = new Feature
					{
						_0 = new int[] { 967 },
						_1 = 256,
						_2 = null,
					},
					[7544] = new Feature
					{
						_0 = new int[] { 1085 },
						_1 = 256,
						_2 = null,
					},
					[7579] = new Feature
					{
						_0 = new int[] { 594 },
						_1 = 256,
						_2 = null,
					},
					[7580] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[7581] = new Feature
					{
						_0 = new int[] { 597 },
						_1 = 256,
						_2 = null,
					},
					[7582] = new Feature
					{
						_0 = new int[] { 240 },
						_1 = 256,
						_2 = null,
					},
					[7583] = new Feature
					{
						_0 = new int[] { 604 },
						_1 = 256,
						_2 = null,
					},
					[7584] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[7585] = new Feature
					{
						_0 = new int[] { 607 },
						_1 = 256,
						_2 = null,
					},
					[7586] = new Feature
					{
						_0 = new int[] { 609 },
						_1 = 256,
						_2 = null,
					},
					[7587] = new Feature
					{
						_0 = new int[] { 613 },
						_1 = 256,
						_2 = null,
					},
					[7588] = new Feature
					{
						_0 = new int[] { 616 },
						_1 = 256,
						_2 = null,
					},
					[7589] = new Feature
					{
						_0 = new int[] { 617 },
						_1 = 256,
						_2 = null,
					},
					[7590] = new Feature
					{
						_0 = new int[] { 618 },
						_1 = 256,
						_2 = null,
					},
					[7591] = new Feature
					{
						_0 = new int[] { 7547 },
						_1 = 256,
						_2 = null,
					},
					[7592] = new Feature
					{
						_0 = new int[] { 669 },
						_1 = 256,
						_2 = null,
					},
					[7593] = new Feature
					{
						_0 = new int[] { 621 },
						_1 = 256,
						_2 = null,
					},
					[7594] = new Feature
					{
						_0 = new int[] { 7557 },
						_1 = 256,
						_2 = null,
					},
					[7595] = new Feature
					{
						_0 = new int[] { 671 },
						_1 = 256,
						_2 = null,
					},
					[7596] = new Feature
					{
						_0 = new int[] { 625 },
						_1 = 256,
						_2 = null,
					},
					[7597] = new Feature
					{
						_0 = new int[] { 624 },
						_1 = 256,
						_2 = null,
					},
					[7598] = new Feature
					{
						_0 = new int[] { 626 },
						_1 = 256,
						_2 = null,
					},
					[7599] = new Feature
					{
						_0 = new int[] { 627 },
						_1 = 256,
						_2 = null,
					},
					[7600] = new Feature
					{
						_0 = new int[] { 628 },
						_1 = 256,
						_2 = null,
					},
					[7601] = new Feature
					{
						_0 = new int[] { 629 },
						_1 = 256,
						_2 = null,
					},
					[7602] = new Feature
					{
						_0 = new int[] { 632 },
						_1 = 256,
						_2 = null,
					},
					[7603] = new Feature
					{
						_0 = new int[] { 642 },
						_1 = 256,
						_2 = null,
					},
					[7604] = new Feature
					{
						_0 = new int[] { 643 },
						_1 = 256,
						_2 = null,
					},
					[7605] = new Feature
					{
						_0 = new int[] { 427 },
						_1 = 256,
						_2 = null,
					},
					[7606] = new Feature
					{
						_0 = new int[] { 649 },
						_1 = 256,
						_2 = null,
					},
					[7607] = new Feature
					{
						_0 = new int[] { 650 },
						_1 = 256,
						_2 = null,
					},
					[7608] = new Feature
					{
						_0 = new int[] { 7452 },
						_1 = 256,
						_2 = null,
					},
					[7609] = new Feature
					{
						_0 = new int[] { 651 },
						_1 = 256,
						_2 = null,
					},
					[7610] = new Feature
					{
						_0 = new int[] { 652 },
						_1 = 256,
						_2 = null,
					},
					[7611] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[7612] = new Feature
					{
						_0 = new int[] { 656 },
						_1 = 256,
						_2 = null,
					},
					[7613] = new Feature
					{
						_0 = new int[] { 657 },
						_1 = 256,
						_2 = null,
					},
					[7614] = new Feature
					{
						_0 = new int[] { 658 },
						_1 = 256,
						_2 = null,
					},
					[7615] = new Feature
					{
						_0 = new int[] { 952 },
						_1 = 256,
						_2 = null,
					},
					[7616] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7617] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7618] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7619] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7620] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7621] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7622] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7623] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7624] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7625] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7626] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7627] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7628] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7629] = new Feature
					{
						_0 = null,
						_1 = 234,
						_2 = null,
					},
					[7630] = new Feature
					{
						_0 = null,
						_1 = 214,
						_2 = null,
					},
					[7631] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7632] = new Feature
					{
						_0 = null,
						_1 = 202,
						_2 = null,
					},
					[7633] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7634] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7635] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7636] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7637] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7638] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7639] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7640] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7641] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7642] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7643] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7644] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7645] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7646] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7647] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7648] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7649] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7650] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7651] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7652] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7653] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7654] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7655] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7656] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7657] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7658] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7659] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7660] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7661] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7662] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7663] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7664] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7665] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7666] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7667] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7668] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7669] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7676] = new Feature
					{
						_0 = null,
						_1 = 233,
						_2 = null,
					},
					[7677] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[7678] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[7679] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[7680] = new Dictionary<int, Feature>
				{
					[7680] = new Feature
					{
						_0 = new int[] { 65, 805 },
						_1 = null,
						_2 = null,
					},
					[7681] = new Feature
					{
						_0 = new int[] { 97, 805 },
						_1 = null,
						_2 = null,
					},
					[7682] = new Feature
					{
						_0 = new int[] { 66, 775 },
						_1 = null,
						_2 = null,
					},
					[7683] = new Feature
					{
						_0 = new int[] { 98, 775 },
						_1 = null,
						_2 = null,
					},
					[7684] = new Feature
					{
						_0 = new int[] { 66, 803 },
						_1 = null,
						_2 = null,
					},
					[7685] = new Feature
					{
						_0 = new int[] { 98, 803 },
						_1 = null,
						_2 = null,
					},
					[7686] = new Feature
					{
						_0 = new int[] { 66, 817 },
						_1 = null,
						_2 = null,
					},
					[7687] = new Feature
					{
						_0 = new int[] { 98, 817 },
						_1 = null,
						_2 = null,
					},
					[7688] = new Feature
					{
						_0 = new int[] { 199, 769 },
						_1 = null,
						_2 = null,
					},
					[7689] = new Feature
					{
						_0 = new int[] { 231, 769 },
						_1 = null,
						_2 = null,
					},
					[7690] = new Feature
					{
						_0 = new int[] { 68, 775 },
						_1 = null,
						_2 = null,
					},
					[7691] = new Feature
					{
						_0 = new int[] { 100, 775 },
						_1 = null,
						_2 = null,
					},
					[7692] = new Feature
					{
						_0 = new int[] { 68, 803 },
						_1 = null,
						_2 = null,
					},
					[7693] = new Feature
					{
						_0 = new int[] { 100, 803 },
						_1 = null,
						_2 = null,
					},
					[7694] = new Feature
					{
						_0 = new int[] { 68, 817 },
						_1 = null,
						_2 = null,
					},
					[7695] = new Feature
					{
						_0 = new int[] { 100, 817 },
						_1 = null,
						_2 = null,
					},
					[7696] = new Feature
					{
						_0 = new int[] { 68, 807 },
						_1 = null,
						_2 = null,
					},
					[7697] = new Feature
					{
						_0 = new int[] { 100, 807 },
						_1 = null,
						_2 = null,
					},
					[7698] = new Feature
					{
						_0 = new int[] { 68, 813 },
						_1 = null,
						_2 = null,
					},
					[7699] = new Feature
					{
						_0 = new int[] { 100, 813 },
						_1 = null,
						_2 = null,
					},
					[7700] = new Feature
					{
						_0 = new int[] { 274, 768 },
						_1 = null,
						_2 = null,
					},
					[7701] = new Feature
					{
						_0 = new int[] { 275, 768 },
						_1 = null,
						_2 = null,
					},
					[7702] = new Feature
					{
						_0 = new int[] { 274, 769 },
						_1 = null,
						_2 = null,
					},
					[7703] = new Feature
					{
						_0 = new int[] { 275, 769 },
						_1 = null,
						_2 = null,
					},
					[7704] = new Feature
					{
						_0 = new int[] { 69, 813 },
						_1 = null,
						_2 = null,
					},
					[7705] = new Feature
					{
						_0 = new int[] { 101, 813 },
						_1 = null,
						_2 = null,
					},
					[7706] = new Feature
					{
						_0 = new int[] { 69, 816 },
						_1 = null,
						_2 = null,
					},
					[7707] = new Feature
					{
						_0 = new int[] { 101, 816 },
						_1 = null,
						_2 = null,
					},
					[7708] = new Feature
					{
						_0 = new int[] { 552, 774 },
						_1 = null,
						_2 = null,
					},
					[7709] = new Feature
					{
						_0 = new int[] { 553, 774 },
						_1 = null,
						_2 = null,
					},
					[7710] = new Feature
					{
						_0 = new int[] { 70, 775 },
						_1 = null,
						_2 = null,
					},
					[7711] = new Feature
					{
						_0 = new int[] { 102, 775 },
						_1 = null,
						_2 = null,
					},
					[7712] = new Feature
					{
						_0 = new int[] { 71, 772 },
						_1 = null,
						_2 = null,
					},
					[7713] = new Feature
					{
						_0 = new int[] { 103, 772 },
						_1 = null,
						_2 = null,
					},
					[7714] = new Feature
					{
						_0 = new int[] { 72, 775 },
						_1 = null,
						_2 = null,
					},
					[7715] = new Feature
					{
						_0 = new int[] { 104, 775 },
						_1 = null,
						_2 = null,
					},
					[7716] = new Feature
					{
						_0 = new int[] { 72, 803 },
						_1 = null,
						_2 = null,
					},
					[7717] = new Feature
					{
						_0 = new int[] { 104, 803 },
						_1 = null,
						_2 = null,
					},
					[7718] = new Feature
					{
						_0 = new int[] { 72, 776 },
						_1 = null,
						_2 = null,
					},
					[7719] = new Feature
					{
						_0 = new int[] { 104, 776 },
						_1 = null,
						_2 = null,
					},
					[7720] = new Feature
					{
						_0 = new int[] { 72, 807 },
						_1 = null,
						_2 = null,
					},
					[7721] = new Feature
					{
						_0 = new int[] { 104, 807 },
						_1 = null,
						_2 = null,
					},
					[7722] = new Feature
					{
						_0 = new int[] { 72, 814 },
						_1 = null,
						_2 = null,
					},
					[7723] = new Feature
					{
						_0 = new int[] { 104, 814 },
						_1 = null,
						_2 = null,
					},
					[7724] = new Feature
					{
						_0 = new int[] { 73, 816 },
						_1 = null,
						_2 = null,
					},
					[7725] = new Feature
					{
						_0 = new int[] { 105, 816 },
						_1 = null,
						_2 = null,
					},
					[7726] = new Feature
					{
						_0 = new int[] { 207, 769 },
						_1 = null,
						_2 = null,
					},
					[7727] = new Feature
					{
						_0 = new int[] { 239, 769 },
						_1 = null,
						_2 = null,
					},
					[7728] = new Feature
					{
						_0 = new int[] { 75, 769 },
						_1 = null,
						_2 = null,
					},
					[7729] = new Feature
					{
						_0 = new int[] { 107, 769 },
						_1 = null,
						_2 = null,
					},
					[7730] = new Feature
					{
						_0 = new int[] { 75, 803 },
						_1 = null,
						_2 = null,
					},
					[7731] = new Feature
					{
						_0 = new int[] { 107, 803 },
						_1 = null,
						_2 = null,
					},
					[7732] = new Feature
					{
						_0 = new int[] { 75, 817 },
						_1 = null,
						_2 = null,
					},
					[7733] = new Feature
					{
						_0 = new int[] { 107, 817 },
						_1 = null,
						_2 = null,
					},
					[7734] = new Feature
					{
						_0 = new int[] { 76, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 7736, },
					},
					[7735] = new Feature
					{
						_0 = new int[] { 108, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 7737, },
					},
					[7736] = new Feature
					{
						_0 = new int[] { 7734, 772 },
						_1 = null,
						_2 = null,
					},
					[7737] = new Feature
					{
						_0 = new int[] { 7735, 772 },
						_1 = null,
						_2 = null,
					},
					[7738] = new Feature
					{
						_0 = new int[] { 76, 817 },
						_1 = null,
						_2 = null,
					},
					[7739] = new Feature
					{
						_0 = new int[] { 108, 817 },
						_1 = null,
						_2 = null,
					},
					[7740] = new Feature
					{
						_0 = new int[] { 76, 813 },
						_1 = null,
						_2 = null,
					},
					[7741] = new Feature
					{
						_0 = new int[] { 108, 813 },
						_1 = null,
						_2 = null,
					},
					[7742] = new Feature
					{
						_0 = new int[] { 77, 769 },
						_1 = null,
						_2 = null,
					},
					[7743] = new Feature
					{
						_0 = new int[] { 109, 769 },
						_1 = null,
						_2 = null,
					},
					[7744] = new Feature
					{
						_0 = new int[] { 77, 775 },
						_1 = null,
						_2 = null,
					},
					[7745] = new Feature
					{
						_0 = new int[] { 109, 775 },
						_1 = null,
						_2 = null,
					},
					[7746] = new Feature
					{
						_0 = new int[] { 77, 803 },
						_1 = null,
						_2 = null,
					},
					[7747] = new Feature
					{
						_0 = new int[] { 109, 803 },
						_1 = null,
						_2 = null,
					},
					[7748] = new Feature
					{
						_0 = new int[] { 78, 775 },
						_1 = null,
						_2 = null,
					},
					[7749] = new Feature
					{
						_0 = new int[] { 110, 775 },
						_1 = null,
						_2 = null,
					},
					[7750] = new Feature
					{
						_0 = new int[] { 78, 803 },
						_1 = null,
						_2 = null,
					},
					[7751] = new Feature
					{
						_0 = new int[] { 110, 803 },
						_1 = null,
						_2 = null,
					},
					[7752] = new Feature
					{
						_0 = new int[] { 78, 817 },
						_1 = null,
						_2 = null,
					},
					[7753] = new Feature
					{
						_0 = new int[] { 110, 817 },
						_1 = null,
						_2 = null,
					},
					[7754] = new Feature
					{
						_0 = new int[] { 78, 813 },
						_1 = null,
						_2 = null,
					},
					[7755] = new Feature
					{
						_0 = new int[] { 110, 813 },
						_1 = null,
						_2 = null,
					},
					[7756] = new Feature
					{
						_0 = new int[] { 213, 769 },
						_1 = null,
						_2 = null,
					},
					[7757] = new Feature
					{
						_0 = new int[] { 245, 769 },
						_1 = null,
						_2 = null,
					},
					[7758] = new Feature
					{
						_0 = new int[] { 213, 776 },
						_1 = null,
						_2 = null,
					},
					[7759] = new Feature
					{
						_0 = new int[] { 245, 776 },
						_1 = null,
						_2 = null,
					},
					[7760] = new Feature
					{
						_0 = new int[] { 332, 768 },
						_1 = null,
						_2 = null,
					},
					[7761] = new Feature
					{
						_0 = new int[] { 333, 768 },
						_1 = null,
						_2 = null,
					},
					[7762] = new Feature
					{
						_0 = new int[] { 332, 769 },
						_1 = null,
						_2 = null,
					},
					[7763] = new Feature
					{
						_0 = new int[] { 333, 769 },
						_1 = null,
						_2 = null,
					},
					[7764] = new Feature
					{
						_0 = new int[] { 80, 769 },
						_1 = null,
						_2 = null,
					},
					[7765] = new Feature
					{
						_0 = new int[] { 112, 769 },
						_1 = null,
						_2 = null,
					},
					[7766] = new Feature
					{
						_0 = new int[] { 80, 775 },
						_1 = null,
						_2 = null,
					},
					[7767] = new Feature
					{
						_0 = new int[] { 112, 775 },
						_1 = null,
						_2 = null,
					},
					[7768] = new Feature
					{
						_0 = new int[] { 82, 775 },
						_1 = null,
						_2 = null,
					},
					[7769] = new Feature
					{
						_0 = new int[] { 114, 775 },
						_1 = null,
						_2 = null,
					},
					[7770] = new Feature
					{
						_0 = new int[] { 82, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 7772, },
					},
					[7771] = new Feature
					{
						_0 = new int[] { 114, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [772] = 7773, },


					},
					[7772] = new Feature
					{
						_0 = new int[] { 7770, 772 },
						_1 = null,
						_2 = null,
					},
					[7773] = new Feature
					{
						_0 = new int[] { 7771, 772 },
						_1 = null,
						_2 = null,
					},
					[7774] = new Feature
					{
						_0 = new int[] { 82, 817 },
						_1 = null,
						_2 = null,
					},
					[7775] = new Feature
					{
						_0 = new int[] { 114, 817 },
						_1 = null,
						_2 = null,
					},
					[7776] = new Feature
					{
						_0 = new int[] { 83, 775 },
						_1 = null,
						_2 = null,
					},
					[7777] = new Feature
					{
						_0 = new int[] { 115, 775 },
						_1 = null,
						_2 = null,
					},
					[7778] = new Feature
					{
						_0 = new int[] { 83, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7784, },
					},
					[7779] = new Feature
					{
						_0 = new int[] { 115, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [775] = 7785, },
					},
					[7780] = new Feature
					{
						_0 = new int[] { 346, 775 },
						_1 = null,
						_2 = null,
					},
					[7781] = new Feature
					{
						_0 = new int[] { 347, 775 },
						_1 = null,
						_2 = null,
					},
					[7782] = new Feature
					{
						_0 = new int[] { 352, 775 },
						_1 = null,
						_2 = null,
					},
					[7783] = new Feature
					{
						_0 = new int[] { 353, 775 },
						_1 = null,
						_2 = null,
					},
					[7784] = new Feature
					{
						_0 = new int[] { 7778, 775 },
						_1 = null,
						_2 = null,
					},
					[7785] = new Feature
					{
						_0 = new int[] { 7779, 775 },
						_1 = null,
						_2 = null,
					},
					[7786] = new Feature
					{
						_0 = new int[] { 84, 775 },
						_1 = null,
						_2 = null,
					},
					[7787] = new Feature
					{
						_0 = new int[] { 116, 775 },
						_1 = null,
						_2 = null,
					},
					[7788] = new Feature
					{
						_0 = new int[] { 84, 803 },
						_1 = null,
						_2 = null,
					},
					[7789] = new Feature
					{
						_0 = new int[] { 116, 803 },
						_1 = null,
						_2 = null,
					},
					[7790] = new Feature
					{
						_0 = new int[] { 84, 817 },
						_1 = null,
						_2 = null,
					},
					[7791] = new Feature
					{
						_0 = new int[] { 116, 817 },
						_1 = null,
						_2 = null,
					},
					[7792] = new Feature
					{
						_0 = new int[] { 84, 813 },
						_1 = null,
						_2 = null,
					},
					[7793] = new Feature
					{
						_0 = new int[] { 116, 813 },
						_1 = null,
						_2 = null,
					},
					[7794] = new Feature
					{
						_0 = new int[] { 85, 804 },
						_1 = null,
						_2 = null,
					},
					[7795] = new Feature
					{
						_0 = new int[] { 117, 804 },
						_1 = null,
						_2 = null,
					},
					[7796] = new Feature
					{
						_0 = new int[] { 85, 816 },
						_1 = null,
						_2 = null,
					},
					[7797] = new Feature
					{
						_0 = new int[] { 117, 816 },
						_1 = null,
						_2 = null,
					},
					[7798] = new Feature
					{
						_0 = new int[] { 85, 813 },
						_1 = null,
						_2 = null,
					},
					[7799] = new Feature
					{
						_0 = new int[] { 117, 813 },
						_1 = null,
						_2 = null,
					},
					[7800] = new Feature
					{
						_0 = new int[] { 360, 769 },
						_1 = null,
						_2 = null,
					},
					[7801] = new Feature
					{
						_0 = new int[] { 361, 769 },
						_1 = null,
						_2 = null,
					},
					[7802] = new Feature
					{
						_0 = new int[] { 362, 776 },
						_1 = null,
						_2 = null,
					},
					[7803] = new Feature
					{
						_0 = new int[] { 363, 776 },
						_1 = null,
						_2 = null,
					},
					[7804] = new Feature
					{
						_0 = new int[] { 86, 771 },
						_1 = null,
						_2 = null,
					},
					[7805] = new Feature
					{
						_0 = new int[] { 118, 771 },
						_1 = null,
						_2 = null,
					},
					[7806] = new Feature
					{
						_0 = new int[] { 86, 803 },
						_1 = null,
						_2 = null,
					},
					[7807] = new Feature
					{
						_0 = new int[] { 118, 803 },
						_1 = null,
						_2 = null,
					},
					[7808] = new Feature
					{
						_0 = new int[] { 87, 768 },
						_1 = null,
						_2 = null,
					},
					[7809] = new Feature
					{
						_0 = new int[] { 119, 768 },
						_1 = null,
						_2 = null,
					},
					[7810] = new Feature
					{
						_0 = new int[] { 87, 769 },
						_1 = null,
						_2 = null,
					},
					[7811] = new Feature
					{
						_0 = new int[] { 119, 769 },
						_1 = null,
						_2 = null,
					},
					[7812] = new Feature
					{
						_0 = new int[] { 87, 776 },
						_1 = null,
						_2 = null,
					},
					[7813] = new Feature
					{
						_0 = new int[] { 119, 776 },
						_1 = null,
						_2 = null,
					},
					[7814] = new Feature
					{
						_0 = new int[] { 87, 775 },
						_1 = null,
						_2 = null,
					},
					[7815] = new Feature
					{
						_0 = new int[] { 119, 775 },
						_1 = null,
						_2 = null,
					},
					[7816] = new Feature
					{
						_0 = new int[] { 87, 803 },
						_1 = null,
						_2 = null,
					},
					[7817] = new Feature
					{
						_0 = new int[] { 119, 803 },
						_1 = null,
						_2 = null,
					},
					[7818] = new Feature
					{
						_0 = new int[] { 88, 775 },
						_1 = null,
						_2 = null,
					},
					[7819] = new Feature
					{
						_0 = new int[] { 120, 775 },
						_1 = null,
						_2 = null,
					},
					[7820] = new Feature
					{
						_0 = new int[] { 88, 776 },
						_1 = null,
						_2 = null,
					},
					[7821] = new Feature
					{
						_0 = new int[] { 120, 776 },
						_1 = null,
						_2 = null,
					},
					[7822] = new Feature
					{
						_0 = new int[] { 89, 775 },
						_1 = null,
						_2 = null,
					},
					[7823] = new Feature
					{
						_0 = new int[] { 121, 775 },
						_1 = null,
						_2 = null,
					},
					[7824] = new Feature
					{
						_0 = new int[] { 90, 770 },
						_1 = null,
						_2 = null,
					},
					[7825] = new Feature
					{
						_0 = new int[] { 122, 770 },
						_1 = null,
						_2 = null,
					},
					[7826] = new Feature
					{
						_0 = new int[] { 90, 803 },
						_1 = null,
						_2 = null,
					},
					[7827] = new Feature
					{
						_0 = new int[] { 122, 803 },
						_1 = null,
						_2 = null,
					},
					[7828] = new Feature
					{
						_0 = new int[] { 90, 817 },
						_1 = null,
						_2 = null,
					},
					[7829] = new Feature
					{
						_0 = new int[] { 122, 817 },
						_1 = null,
						_2 = null,
					},
					[7830] = new Feature
					{
						_0 = new int[] { 104, 817 },
						_1 = null,
						_2 = null,
					},
					[7831] = new Feature
					{
						_0 = new int[] { 116, 776 },
						_1 = null,
						_2 = null,
					},
					[7832] = new Feature
					{
						_0 = new int[] { 119, 778 },
						_1 = null,
						_2 = null,
					},
					[7833] = new Feature
					{
						_0 = new int[] { 121, 778 },
						_1 = null,
						_2 = null,
					},
					[7834] = new Feature
					{
						_0 = new int[] { 97, 702 },
						_1 = 256,
						_2 = null,
					},
					[7835] = new Feature
					{
						_0 = new int[] { 383, 775 },
						_1 = null,
						_2 = null,
					},
					[7840] = new Feature
					{
						_0 = new int[] { 65, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 7852, [774] = 7862, },
					},
					[7841] = new Feature
					{
						_0 = new int[] { 97, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 7853, [774] = 7863, },
					},
					[7842] = new Feature
					{
						_0 = new int[] { 65, 777 },
						_1 = null,
						_2 = null,
					},
					[7843] = new Feature
					{
						_0 = new int[] { 97, 777 },
						_1 = null,
						_2 = null,
					},
					[7844] = new Feature
					{
						_0 = new int[] { 194, 769 },
						_1 = null,
						_2 = null,
					},
					[7845] = new Feature
					{
						_0 = new int[] { 226, 769 },
						_1 = null,
						_2 = null,
					},
					[7846] = new Feature
					{
						_0 = new int[] { 194, 768 },
						_1 = null,
						_2 = null,
					},
					[7847] = new Feature
					{
						_0 = new int[] { 226, 768 },
						_1 = null,
						_2 = null,
					},
					[7848] = new Feature
					{
						_0 = new int[] { 194, 777 },
						_1 = null,
						_2 = null,
					},
					[7849] = new Feature
					{
						_0 = new int[] { 226, 777 },
						_1 = null,
						_2 = null,
					},
					[7850] = new Feature
					{
						_0 = new int[] { 194, 771 },
						_1 = null,
						_2 = null,
					},
					[7851] = new Feature
					{
						_0 = new int[] { 226, 771 },
						_1 = null,
						_2 = null,
					},
					[7852] = new Feature
					{
						_0 = new int[] { 7840, 770 },
						_1 = null,
						_2 = null,
					},
					[7853] = new Feature
					{
						_0 = new int[] { 7841, 770 },
						_1 = null,
						_2 = null,
					},
					[7854] = new Feature
					{
						_0 = new int[] { 258, 769 },
						_1 = null,
						_2 = null,
					},
					[7855] = new Feature
					{
						_0 = new int[] { 259, 769 },
						_1 = null,
						_2 = null,
					},
					[7856] = new Feature
					{
						_0 = new int[] { 258, 768 },
						_1 = null,
						_2 = null,
					},
					[7857] = new Feature
					{
						_0 = new int[] { 259, 768 },
						_1 = null,
						_2 = null,
					},
					[7858] = new Feature
					{
						_0 = new int[] { 258, 777 },
						_1 = null,
						_2 = null,
					},
					[7859] = new Feature
					{
						_0 = new int[] { 259, 777 },
						_1 = null,
						_2 = null,
					},
					[7860] = new Feature
					{
						_0 = new int[] { 258, 771 },
						_1 = null,
						_2 = null,
					},
					[7861] = new Feature
					{
						_0 = new int[] { 259, 771 },
						_1 = null,
						_2 = null,
					},
					[7862] = new Feature
					{
						_0 = new int[] { 7840, 774 },
						_1 = null,
						_2 = null,
					},
					[7863] = new Feature
					{
						_0 = new int[] { 7841, 774 },
						_1 = null,
						_2 = null,
					},
					[7864] = new Feature
					{
						_0 = new int[] { 69, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 7878, },
					},
					[7865] = new Feature
					{
						_0 = new int[] { 101, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 7879, },
					},
					[7866] = new Feature
					{
						_0 = new int[] { 69, 777 },
						_1 = null,
						_2 = null,
					},
					[7867] = new Feature
					{
						_0 = new int[] { 101, 777 },
						_1 = null,
						_2 = null,
					},
					[7868] = new Feature
					{
						_0 = new int[] { 69, 771 },
						_1 = null,
						_2 = null,
					},
					[7869] = new Feature
					{
						_0 = new int[] { 101, 771 },
						_1 = null,
						_2 = null,
					},
					[7870] = new Feature
					{
						_0 = new int[] { 202, 769 },
						_1 = null,
						_2 = null,
					},
					[7871] = new Feature
					{
						_0 = new int[] { 234, 769 },
						_1 = null,
						_2 = null,
					},
					[7872] = new Feature
					{
						_0 = new int[] { 202, 768 },
						_1 = null,
						_2 = null,
					},
					[7873] = new Feature
					{
						_0 = new int[] { 234, 768 },
						_1 = null,
						_2 = null,
					},
					[7874] = new Feature
					{
						_0 = new int[] { 202, 777 },
						_1 = null,
						_2 = null,
					},
					[7875] = new Feature
					{
						_0 = new int[] { 234, 777 },
						_1 = null,
						_2 = null,
					},
					[7876] = new Feature
					{
						_0 = new int[] { 202, 771 },
						_1 = null,
						_2 = null,
					},
					[7877] = new Feature
					{
						_0 = new int[] { 234, 771 },
						_1 = null,
						_2 = null,
					},
					[7878] = new Feature
					{
						_0 = new int[] { 7864, 770 },
						_1 = null,
						_2 = null,
					},
					[7879] = new Feature
					{
						_0 = new int[] { 7865, 770 },
						_1 = null,
						_2 = null,
					},
					[7880] = new Feature
					{
						_0 = new int[] { 73, 777 },
						_1 = null,
						_2 = null,
					},
					[7881] = new Feature
					{
						_0 = new int[] { 105, 777 },
						_1 = null,
						_2 = null,
					},
					[7882] = new Feature
					{
						_0 = new int[] { 73, 803 },
						_1 = null,
						_2 = null,
					},
					[7883] = new Feature
					{
						_0 = new int[] { 105, 803 },
						_1 = null,
						_2 = null,
					},
					[7884] = new Feature
					{
						_0 = new int[] { 79, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 7896, },
					},
					[7885] = new Feature
					{
						_0 = new int[] { 111, 803 },
						_1 = null,
						_2 = new Dictionary<int, int> { [770] = 7897, },
					},
					[7886] = new Feature
					{
						_0 = new int[] { 79, 777 },
						_1 = null,
						_2 = null,
					},
					[7887] = new Feature
					{
						_0 = new int[] { 111, 777 },
						_1 = null,
						_2 = null,
					},
					[7888] = new Feature
					{
						_0 = new int[] { 212, 769 },
						_1 = null,
						_2 = null,
					},
					[7889] = new Feature
					{
						_0 = new int[] { 244, 769 },
						_1 = null,
						_2 = null,
					},
					[7890] = new Feature
					{
						_0 = new int[] { 212, 768 },
						_1 = null,
						_2 = null,
					},
					[7891] = new Feature
					{
						_0 = new int[] { 244, 768 },
						_1 = null,
						_2 = null,
					},
					[7892] = new Feature
					{
						_0 = new int[] { 212, 777 },
						_1 = null,
						_2 = null,
					},
					[7893] = new Feature
					{
						_0 = new int[] { 244, 777 },
						_1 = null,
						_2 = null,
					},
					[7894] = new Feature
					{
						_0 = new int[] { 212, 771 },
						_1 = null,
						_2 = null,
					},
					[7895] = new Feature
					{
						_0 = new int[] { 244, 771 },
						_1 = null,
						_2 = null,
					},
					[7896] = new Feature
					{
						_0 = new int[] { 7884, 770 },
						_1 = null,
						_2 = null,
					},
					[7897] = new Feature
					{
						_0 = new int[] { 7885, 770 },
						_1 = null,
						_2 = null,
					},
					[7898] = new Feature
					{
						_0 = new int[] { 416, 769 },
						_1 = null,
						_2 = null,
					},
					[7899] = new Feature
					{
						_0 = new int[] { 417, 769 },
						_1 = null,
						_2 = null,
					},
					[7900] = new Feature
					{
						_0 = new int[] { 416, 768 },
						_1 = null,
						_2 = null,
					},
					[7901] = new Feature
					{
						_0 = new int[] { 417, 768 },
						_1 = null,
						_2 = null,
					},
					[7902] = new Feature
					{
						_0 = new int[] { 416, 777 },
						_1 = null,
						_2 = null,
					},
					[7903] = new Feature
					{
						_0 = new int[] { 417, 777 },
						_1 = null,
						_2 = null,
					},
					[7904] = new Feature
					{
						_0 = new int[] { 416, 771 },
						_1 = null,
						_2 = null,
					},
					[7905] = new Feature
					{
						_0 = new int[] { 417, 771 },
						_1 = null,
						_2 = null,
					},
					[7906] = new Feature
					{
						_0 = new int[] { 416, 803 },
						_1 = null,
						_2 = null,
					},
					[7907] = new Feature
					{
						_0 = new int[] { 417, 803 },
						_1 = null,
						_2 = null,
					},
					[7908] = new Feature
					{
						_0 = new int[] { 85, 803 },
						_1 = null,
						_2 = null,
					},
					[7909] = new Feature
					{
						_0 = new int[] { 117, 803 },
						_1 = null,
						_2 = null,
					},
					[7910] = new Feature
					{
						_0 = new int[] { 85, 777 },
						_1 = null,
						_2 = null,
					},
					[7911] = new Feature
					{
						_0 = new int[] { 117, 777 },
						_1 = null,
						_2 = null,
					},
					[7912] = new Feature
					{
						_0 = new int[] { 431, 769 },
						_1 = null,
						_2 = null,
					},
					[7913] = new Feature
					{
						_0 = new int[] { 432, 769 },
						_1 = null,
						_2 = null,
					},
					[7914] = new Feature
					{
						_0 = new int[] { 431, 768 },
						_1 = null,
						_2 = null,
					},
					[7915] = new Feature
					{
						_0 = new int[] { 432, 768 },
						_1 = null,
						_2 = null,
					},
					[7916] = new Feature
					{
						_0 = new int[] { 431, 777 },
						_1 = null,
						_2 = null,
					},
					[7917] = new Feature
					{
						_0 = new int[] { 432, 777 },
						_1 = null,
						_2 = null,
					},
					[7918] = new Feature
					{
						_0 = new int[] { 431, 771 },
						_1 = null,
						_2 = null,
					},
					[7919] = new Feature
					{
						_0 = new int[] { 432, 771 },
						_1 = null,
						_2 = null,
					},
					[7920] = new Feature
					{
						_0 = new int[] { 431, 803 },
						_1 = null,
						_2 = null,
					},
					[7921] = new Feature
					{
						_0 = new int[] { 432, 803 },
						_1 = null,
						_2 = null,
					},
					[7922] = new Feature
					{
						_0 = new int[] { 89, 768 },
						_1 = null,
						_2 = null,
					},
					[7923] = new Feature
					{
						_0 = new int[] { 121, 768 },
						_1 = null,
						_2 = null,
					},
					[7924] = new Feature
					{
						_0 = new int[] { 89, 803 },
						_1 = null,
						_2 = null,
					},
					[7925] = new Feature
					{
						_0 = new int[] { 121, 803 },
						_1 = null,
						_2 = null,
					},
					[7926] = new Feature
					{
						_0 = new int[] { 89, 777 },
						_1 = null,
						_2 = null,
					},
					[7927] = new Feature
					{
						_0 = new int[] { 121, 777 },
						_1 = null,
						_2 = null,
					},
					[7928] = new Feature
					{
						_0 = new int[] { 89, 771 },
						_1 = null,
						_2 = null,
					},
					[7929] = new Feature
					{
						_0 = new int[] { 121, 771 },
						_1 = null,
						_2 = null,
					},
				},
				[7936] = new Dictionary<int, Feature>
				{
					[7936] = new Feature
					{
						_0 = new int[] { 945, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7938, [769] = 7940, [834] = 7942, [837] = 8064, },
					},
					[7937] = new Feature
					{
						_0 = new int[] { 945, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7939, [769] = 7941, [834] = 7943, [837] = 8065, },
					},
					[7938] = new Feature
					{
						_0 = new int[] { 7936, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8066, },
					},
					[7939] = new Feature
					{
						_0 = new int[] { 7937, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8067, },
					},
					[7940] = new Feature
					{
						_0 = new int[] { 7936, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8068, },
					},
					[7941] = new Feature
					{
						_0 = new int[] { 7937, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8069, },
					},
					[7942] = new Feature
					{
						_0 = new int[] { 7936, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8070, },
					},
					[7943] = new Feature
					{
						_0 = new int[] { 7937, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8071, },
					},
					[7944] = new Feature
					{
						_0 = new int[] { 913, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7946, [769] = 7948, [834] = 7950, [837] = 8072, },
					},
					[7945] = new Feature
					{
						_0 = new int[] { 913, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7947, [769] = 7949, [834] = 7951, [837] = 8073, },
					},
					[7946] = new Feature
					{
						_0 = new int[] { 7944, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8074, },
					},
					[7947] = new Feature
					{
						_0 = new int[] { 7945, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8075, },
					},
					[7948] = new Feature
					{
						_0 = new int[] { 7944, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8076, },
					},
					[7949] = new Feature
					{
						_0 = new int[] { 7945, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8077, },
					},
					[7950] = new Feature
					{
						_0 = new int[] { 7944, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8078, },
					},
					[7951] = new Feature
					{
						_0 = new int[] { 7945, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8079, },
					},
					[7952] = new Feature
					{
						_0 = new int[] { 949, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7954, [769] = 7956, },
					},
					[7953] = new Feature
					{
						_0 = new int[] { 949, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7955, [769] = 7957, },
					},
					[7954] = new Feature
					{
						_0 = new int[] { 7952, 768 },
						_1 = null,
						_2 = null,
					},
					[7955] = new Feature
					{
						_0 = new int[] { 7953, 768 },
						_1 = null,
						_2 = null,
					},
					[7956] = new Feature
					{
						_0 = new int[] { 7952, 769 },
						_1 = null,
						_2 = null,
					},
					[7957] = new Feature
					{
						_0 = new int[] { 7953, 769 },
						_1 = null,
						_2 = null,
					},
					[7960] = new Feature
					{
						_0 = new int[] { 917, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7962, [769] = 7964, },
					},
					[7961] = new Feature
					{
						_0 = new int[] { 917, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7963, [769] = 7965, },
					},
					[7962] = new Feature
					{
						_0 = new int[] { 7960, 768 },
						_1 = null,
						_2 = null,
					},
					[7963] = new Feature
					{
						_0 = new int[] { 7961, 768 },
						_1 = null,
						_2 = null,
					},
					[7964] = new Feature
					{
						_0 = new int[] { 7960, 769 },
						_1 = null,
						_2 = null,
					},
					[7965] = new Feature
					{
						_0 = new int[] { 7961, 769 },
						_1 = null,
						_2 = null,
					},
					[7968] = new Feature
					{
						_0 = new int[] { 951, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7970, [769] = 7972, [834] = 7974, [837] = 8080, },
					},
					[7969] = new Feature
					{
						_0 = new int[] { 951, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7971, [769] = 7973, [834] = 7975, [837] = 8081, },
					},
					[7970] = new Feature
					{
						_0 = new int[] { 7968, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8082, },
					},
					[7971] = new Feature
					{
						_0 = new int[] { 7969, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8083, },
					},
					[7972] = new Feature
					{
						_0 = new int[] { 7968, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8084, },
					},
					[7973] = new Feature
					{
						_0 = new int[] { 7969, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8085, },
					},
					[7974] = new Feature
					{
						_0 = new int[] { 7968, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8086, },
					},
					[7975] = new Feature
					{
						_0 = new int[] { 7969, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8087, },
					},
					[7976] = new Feature
					{
						_0 = new int[] { 919, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7978, [769] = 7980, [834] = 7982, [837] = 8088, },
					},
					[7977] = new Feature
					{
						_0 = new int[] { 919, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7979, [769] = 7981, [834] = 7983, [837] = 8089, },
					},
					[7978] = new Feature
					{
						_0 = new int[] { 7976, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8090, },
					},
					[7979] = new Feature
					{
						_0 = new int[] { 7977, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8091, },
					},
					[7980] = new Feature
					{
						_0 = new int[] { 7976, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8092, },
					},
					[7981] = new Feature
					{
						_0 = new int[] { 7977, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8093, },
					},
					[7982] = new Feature
					{
						_0 = new int[] { 7976, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8094, },
					},
					[7983] = new Feature
					{
						_0 = new int[] { 7977, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8095, },
					},
					[7984] = new Feature
					{
						_0 = new int[] { 953, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7986, [769] = 7988, [834] = 7990, },
					},
					[7985] = new Feature
					{
						_0 = new int[] { 953, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7987, [769] = 7989, [834] = 7991, },
					},
					[7986] = new Feature
					{
						_0 = new int[] { 7984, 768 },
						_1 = null,
						_2 = null,
					},
					[7987] = new Feature
					{
						_0 = new int[] { 7985, 768 },
						_1 = null,
						_2 = null,
					},
					[7988] = new Feature
					{
						_0 = new int[] { 7984, 769 },
						_1 = null,
						_2 = null,
					},
					[7989] = new Feature
					{
						_0 = new int[] { 7985, 769 },
						_1 = null,
						_2 = null,
					},
					[7990] = new Feature
					{
						_0 = new int[] { 7984, 834 },
						_1 = null,
						_2 = null,
					},
					[7991] = new Feature
					{
						_0 = new int[] { 7985, 834 },
						_1 = null,
						_2 = null,
					},
					[7992] = new Feature
					{
						_0 = new int[] { 921, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7994, [769] = 7996, [834] = 7998, },
					},
					[7993] = new Feature
					{
						_0 = new int[] { 921, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 7995, [769] = 7997, [834] = 7999, },
					},
					[7994] = new Feature
					{
						_0 = new int[] { 7992, 768 },
						_1 = null,
						_2 = null,
					},
					[7995] = new Feature
					{
						_0 = new int[] { 7993, 768 },
						_1 = null,
						_2 = null,
					},
					[7996] = new Feature
					{
						_0 = new int[] { 7992, 769 },
						_1 = null,
						_2 = null,
					},
					[7997] = new Feature
					{
						_0 = new int[] { 7993, 769 },
						_1 = null,
						_2 = null,
					},
					[7998] = new Feature
					{
						_0 = new int[] { 7992, 834 },
						_1 = null,
						_2 = null,
					},
					[7999] = new Feature
					{
						_0 = new int[] { 7993, 834 },
						_1 = null,
						_2 = null,
					},
					[8000] = new Feature
					{
						_0 = new int[] { 959, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8002, [769] = 8004, },
					},
					[8001] = new Feature
					{
						_0 = new int[] { 959, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8003, [769] = 8005, },
					},
					[8002] = new Feature
					{
						_0 = new int[] { 8000, 768 },
						_1 = null,
						_2 = null,
					},
					[8003] = new Feature
					{
						_0 = new int[] { 8001, 768 },
						_1 = null,
						_2 = null,
					},
					[8004] = new Feature
					{
						_0 = new int[] { 8000, 769 },
						_1 = null,
						_2 = null,
					},
					[8005] = new Feature
					{
						_0 = new int[] { 8001, 769 },
						_1 = null,
						_2 = null,
					},
					[8008] = new Feature
					{
						_0 = new int[] { 927, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8010, [769] = 8012, },
					},
					[8009] = new Feature
					{
						_0 = new int[] { 927, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8011, [769] = 8013, },
					},
					[8010] = new Feature
					{
						_0 = new int[] { 8008, 768 },
						_1 = null,
						_2 = null,
					},
					[8011] = new Feature
					{
						_0 = new int[] { 8009, 768 },
						_1 = null,
						_2 = null,
					},
					[8012] = new Feature
					{
						_0 = new int[] { 8008, 769 },
						_1 = null,
						_2 = null,
					},
					[8013] = new Feature
					{
						_0 = new int[] { 8009, 769 },
						_1 = null,
						_2 = null,
					},
					[8016] = new Feature
					{
						_0 = new int[] { 965, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8018, [769] = 8020, [834] = 8022, },
					},
					[8017] = new Feature
					{
						_0 = new int[] { 965, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8019, [769] = 8021, [834] = 8023, },
					},
					[8018] = new Feature
					{
						_0 = new int[] { 8016, 768 },
						_1 = null,
						_2 = null,
					},
					[8019] = new Feature
					{
						_0 = new int[] { 8017, 768 },
						_1 = null,
						_2 = null,
					},
					[8020] = new Feature
					{
						_0 = new int[] { 8016, 769 },
						_1 = null,
						_2 = null,
					},
					[8021] = new Feature
					{
						_0 = new int[] { 8017, 769 },
						_1 = null,
						_2 = null,
					},
					[8022] = new Feature
					{
						_0 = new int[] { 8016, 834 },
						_1 = null,
						_2 = null,
					},
					[8023] = new Feature
					{
						_0 = new int[] { 8017, 834 },
						_1 = null,
						_2 = null,
					},
					[8025] = new Feature
					{
						_0 = new int[] { 933, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8027, [769] = 8029, [834] = 8031, },
					},
					[8027] = new Feature
					{
						_0 = new int[] { 8025, 768 },
						_1 = null,
						_2 = null,
					},
					[8029] = new Feature
					{
						_0 = new int[] { 8025, 769 },
						_1 = null,
						_2 = null,
					},
					[8031] = new Feature
					{
						_0 = new int[] { 8025, 834 },
						_1 = null,
						_2 = null,
					},
					[8032] = new Feature
					{
						_0 = new int[] { 969, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8034, [769] = 8036, [834] = 8038, [837] = 8096, },
					},
					[8033] = new Feature
					{
						_0 = new int[] { 969, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8035, [769] = 8037, [834] = 8039, [837] = 8097, },
					},
					[8034] = new Feature
					{
						_0 = new int[] { 8032, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8098, },
					},
					[8035] = new Feature
					{
						_0 = new int[] { 8033, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8099, },
					},
					[8036] = new Feature
					{
						_0 = new int[] { 8032, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8100, },
					},
					[8037] = new Feature
					{
						_0 = new int[] { 8033, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8101, },
					},
					[8038] = new Feature
					{
						_0 = new int[] { 8032, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8102, },
					},
					[8039] = new Feature
					{
						_0 = new int[] { 8033, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8103, },
					},
					[8040] = new Feature
					{
						_0 = new int[] { 937, 787 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8042, [769] = 8044, [834] = 8046, [837] = 8104, },
					},
					[8041] = new Feature
					{
						_0 = new int[] { 937, 788 },
						_1 = null,
						_2 = new Dictionary<int, int> { [768] = 8043, [769] = 8045, [834] = 8047, [837] = 8105, },
					},
					[8042] = new Feature
					{
						_0 = new int[] { 8040, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8106, },
					},
					[8043] = new Feature
					{
						_0 = new int[] { 8041, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8107, },
					},
					[8044] = new Feature
					{
						_0 = new int[] { 8040, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8108, },
					},
					[8045] = new Feature
					{
						_0 = new int[] { 8041, 769 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8109, },
					},
					[8046] = new Feature
					{
						_0 = new int[] { 8040, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8110, },
					},
					[8047] = new Feature
					{
						_0 = new int[] { 8041, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8111, },
					},
					[8048] = new Feature
					{
						_0 = new int[] { 945, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8114, },
					},
					[8049] = new Feature
					{
						_0 = new int[] { 940 },
						_1 = null,
						_2 = null,
					},
					[8050] = new Feature
					{
						_0 = new int[] { 949, 768 },
						_1 = null,
						_2 = null,
					},
					[8051] = new Feature
					{
						_0 = new int[] { 941 },
						_1 = null,
						_2 = null,
					},
					[8052] = new Feature
					{
						_0 = new int[] { 951, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8130, },
					},
					[8053] = new Feature
					{
						_0 = new int[] { 942 },
						_1 = null,
						_2 = null,
					},
					[8054] = new Feature
					{
						_0 = new int[] { 953, 768 },
						_1 = null,
						_2 = null,
					},
					[8055] = new Feature
					{
						_0 = new int[] { 943 },
						_1 = null,
						_2 = null,
					},
					[8056] = new Feature
					{
						_0 = new int[] { 959, 768 },
						_1 = null,
						_2 = null,
					},
					[8057] = new Feature
					{
						_0 = new int[] { 972 },
						_1 = null,
						_2 = null,
					},
					[8058] = new Feature
					{
						_0 = new int[] { 965, 768 },
						_1 = null,
						_2 = null,
					},
					[8059] = new Feature
					{
						_0 = new int[] { 973 },
						_1 = null,
						_2 = null,
					},
					[8060] = new Feature
					{
						_0 = new int[] { 969, 768 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8178, },
					},
					[8061] = new Feature
					{
						_0 = new int[] { 974 },
						_1 = null,
						_2 = null,
					},
					[8064] = new Feature
					{
						_0 = new int[] { 7936, 837 },
						_1 = null,
						_2 = null,
					},
					[8065] = new Feature
					{
						_0 = new int[] { 7937, 837 },
						_1 = null,
						_2 = null,
					},
					[8066] = new Feature
					{
						_0 = new int[] { 7938, 837 },
						_1 = null,
						_2 = null,
					},
					[8067] = new Feature
					{
						_0 = new int[] { 7939, 837 },
						_1 = null,
						_2 = null,
					},
					[8068] = new Feature
					{
						_0 = new int[] { 7940, 837 },
						_1 = null,
						_2 = null,
					},
					[8069] = new Feature
					{
						_0 = new int[] { 7941, 837 },
						_1 = null,
						_2 = null,
					},
					[8070] = new Feature
					{
						_0 = new int[] { 7942, 837 },
						_1 = null,
						_2 = null,
					},
					[8071] = new Feature
					{
						_0 = new int[] { 7943, 837 },
						_1 = null,
						_2 = null,
					},
					[8072] = new Feature
					{
						_0 = new int[] { 7944, 837 },
						_1 = null,
						_2 = null,
					},
					[8073] = new Feature
					{
						_0 = new int[] { 7945, 837 },
						_1 = null,
						_2 = null,
					},
					[8074] = new Feature
					{
						_0 = new int[] { 7946, 837 },
						_1 = null,
						_2 = null,
					},
					[8075] = new Feature
					{
						_0 = new int[] { 7947, 837 },
						_1 = null,
						_2 = null,
					},
					[8076] = new Feature
					{
						_0 = new int[] { 7948, 837 },
						_1 = null,
						_2 = null,
					},
					[8077] = new Feature
					{
						_0 = new int[] { 7949, 837 },
						_1 = null,
						_2 = null,
					},
					[8078] = new Feature
					{
						_0 = new int[] { 7950, 837 },
						_1 = null,
						_2 = null,
					},
					[8079] = new Feature
					{
						_0 = new int[] { 7951, 837 },
						_1 = null,
						_2 = null,
					},
					[8080] = new Feature
					{
						_0 = new int[] { 7968, 837 },
						_1 = null,
						_2 = null,
					},
					[8081] = new Feature
					{
						_0 = new int[] { 7969, 837 },
						_1 = null,
						_2 = null,
					},
					[8082] = new Feature
					{
						_0 = new int[] { 7970, 837 },
						_1 = null,
						_2 = null,
					},
					[8083] = new Feature
					{
						_0 = new int[] { 7971, 837 },
						_1 = null,
						_2 = null,
					},
					[8084] = new Feature
					{
						_0 = new int[] { 7972, 837 },
						_1 = null,
						_2 = null,
					},
					[8085] = new Feature
					{
						_0 = new int[] { 7973, 837 },
						_1 = null,
						_2 = null,
					},
					[8086] = new Feature
					{
						_0 = new int[] { 7974, 837 },
						_1 = null,
						_2 = null,
					},
					[8087] = new Feature
					{
						_0 = new int[] { 7975, 837 },
						_1 = null,
						_2 = null,
					},
					[8088] = new Feature
					{
						_0 = new int[] { 7976, 837 },
						_1 = null,
						_2 = null,
					},
					[8089] = new Feature
					{
						_0 = new int[] { 7977, 837 },
						_1 = null,
						_2 = null,
					},
					[8090] = new Feature
					{
						_0 = new int[] { 7978, 837 },
						_1 = null,
						_2 = null,
					},
					[8091] = new Feature
					{
						_0 = new int[] { 7979, 837 },
						_1 = null,
						_2 = null,
					},
					[8092] = new Feature
					{
						_0 = new int[] { 7980, 837 },
						_1 = null,
						_2 = null,
					},
					[8093] = new Feature
					{
						_0 = new int[] { 7981, 837 },
						_1 = null,
						_2 = null,
					},
					[8094] = new Feature
					{
						_0 = new int[] { 7982, 837 },
						_1 = null,
						_2 = null,
					},
					[8095] = new Feature
					{
						_0 = new int[] { 7983, 837 },
						_1 = null,
						_2 = null,
					},
					[8096] = new Feature
					{
						_0 = new int[] { 8032, 837 },
						_1 = null,
						_2 = null,
					},
					[8097] = new Feature
					{
						_0 = new int[] { 8033, 837 },
						_1 = null,
						_2 = null,
					},
					[8098] = new Feature
					{
						_0 = new int[] { 8034, 837 },
						_1 = null,
						_2 = null,
					},
					[8099] = new Feature
					{
						_0 = new int[] { 8035, 837 },
						_1 = null,
						_2 = null,
					},
					[8100] = new Feature
					{
						_0 = new int[] { 8036, 837 },
						_1 = null,
						_2 = null,
					},
					[8101] = new Feature
					{
						_0 = new int[] { 8037, 837 },
						_1 = null,
						_2 = null,
					},
					[8102] = new Feature
					{
						_0 = new int[] { 8038, 837 },
						_1 = null,
						_2 = null,
					},
					[8103] = new Feature
					{
						_0 = new int[] { 8039, 837 },
						_1 = null,
						_2 = null,
					},
					[8104] = new Feature
					{
						_0 = new int[] { 8040, 837 },
						_1 = null,
						_2 = null,
					},
					[8105] = new Feature
					{
						_0 = new int[] { 8041, 837 },
						_1 = null,
						_2 = null,
					},
					[8106] = new Feature
					{
						_0 = new int[] { 8042, 837 },
						_1 = null,
						_2 = null,
					},
					[8107] = new Feature
					{
						_0 = new int[] { 8043, 837 },
						_1 = null,
						_2 = null,
					},
					[8108] = new Feature
					{
						_0 = new int[] { 8044, 837 },
						_1 = null,
						_2 = null,
					},
					[8109] = new Feature
					{
						_0 = new int[] { 8045, 837 },
						_1 = null,
						_2 = null,
					},
					[8110] = new Feature
					{
						_0 = new int[] { 8046, 837 },
						_1 = null,
						_2 = null,
					},
					[8111] = new Feature
					{
						_0 = new int[] { 8047, 837 },
						_1 = null,
						_2 = null,
					},
					[8112] = new Feature
					{
						_0 = new int[] { 945, 774 },
						_1 = null,
						_2 = null,
					},
					[8113] = new Feature
					{
						_0 = new int[] { 945, 772 },
						_1 = null,
						_2 = null,
					},
					[8114] = new Feature
					{
						_0 = new int[] { 8048, 837 },
						_1 = null,
						_2 = null,
					},
					[8115] = new Feature
					{
						_0 = new int[] { 945, 837 },
						_1 = null,
						_2 = null,
					},
					[8116] = new Feature
					{
						_0 = new int[] { 940, 837 },
						_1 = null,
						_2 = null,
					},
					[8118] = new Feature
					{
						_0 = new int[] { 945, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8119, },
					},
					[8119] = new Feature
					{
						_0 = new int[] { 8118, 837 },
						_1 = null,
						_2 = null,
					},
					[8120] = new Feature
					{
						_0 = new int[] { 913, 774 },
						_1 = null,
						_2 = null,
					},
					[8121] = new Feature
					{
						_0 = new int[] { 913, 772 },
						_1 = null,
						_2 = null,
					},
					[8122] = new Feature
					{
						_0 = new int[] { 913, 768 },
						_1 = null,
						_2 = null,
					},
					[8123] = new Feature
					{
						_0 = new int[] { 902 },
						_1 = null,
						_2 = null,
					},
					[8124] = new Feature
					{
						_0 = new int[] { 913, 837 },
						_1 = null,
						_2 = null,
					},
					[8125] = new Feature
					{
						_0 = new int[] { 32, 787 },
						_1 = 256,
						_2 = null,
					},
					[8126] = new Feature
					{
						_0 = new int[] { 953 },
						_1 = null,
						_2 = null,
					},
					[8127] = new Feature
					{
						_0 = new int[] { 32, 787 },
						_1 = 256,
						_2 = new Dictionary<int, int> { [768] = 8141, [769] = 8142, [834] = 8143, },
					},
					[8128] = new Feature
					{
						_0 = new int[] { 32, 834 },
						_1 = 256,
						_2 = null,
					},
					[8129] = new Feature
					{
						_0 = new int[] { 168, 834 },
						_1 = null,
						_2 = null,
					},
					[8130] = new Feature
					{
						_0 = new int[] { 8052, 837 },
						_1 = null,
						_2 = null,
					},
					[8131] = new Feature
					{
						_0 = new int[] { 951, 837 },
						_1 = null,
						_2 = null,
					},
					[8132] = new Feature
					{
						_0 = new int[] { 942, 837 },
						_1 = null,
						_2 = null,
					},
					[8134] = new Feature
					{
						_0 = new int[] { 951, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8135, },
					},
					[8135] = new Feature
					{
						_0 = new int[] { 8134, 837 },
						_1 = null,
						_2 = null,
					},
					[8136] = new Feature
					{
						_0 = new int[] { 917, 768 },
						_1 = null,
						_2 = null,
					},
					[8137] = new Feature
					{
						_0 = new int[] { 904 },
						_1 = null,
						_2 = null,
					},
					[8138] = new Feature
					{
						_0 = new int[] { 919, 768 },
						_1 = null,
						_2 = null,
					},
					[8139] = new Feature
					{
						_0 = new int[] { 905 },
						_1 = null,
						_2 = null,
					},
					[8140] = new Feature
					{
						_0 = new int[] { 919, 837 },
						_1 = null,
						_2 = null,
					},
					[8141] = new Feature
					{
						_0 = new int[] { 8127, 768 },
						_1 = null,
						_2 = null,
					},
					[8142] = new Feature
					{
						_0 = new int[] { 8127, 769 },
						_1 = null,
						_2 = null,
					},
					[8143] = new Feature
					{
						_0 = new int[] { 8127, 834 },
						_1 = null,
						_2 = null,
					},
					[8144] = new Feature
					{
						_0 = new int[] { 953, 774 },
						_1 = null,
						_2 = null,
					},
					[8145] = new Feature
					{
						_0 = new int[] { 953, 772 },
						_1 = null,
						_2 = null,
					},
					[8146] = new Feature
					{
						_0 = new int[] { 970, 768 },
						_1 = null,
						_2 = null,
					},
					[8147] = new Feature
					{
						_0 = new int[] { 912 },
						_1 = null,
						_2 = null,
					},
					[8150] = new Feature
					{
						_0 = new int[] { 953, 834 },
						_1 = null,
						_2 = null,
					},
					[8151] = new Feature
					{
						_0 = new int[] { 970, 834 },
						_1 = null,
						_2 = null,
					},
					[8152] = new Feature
					{
						_0 = new int[] { 921, 774 },
						_1 = null,
						_2 = null,
					},
					[8153] = new Feature
					{
						_0 = new int[] { 921, 772 },
						_1 = null,
						_2 = null,
					},
					[8154] = new Feature
					{
						_0 = new int[] { 921, 768 },
						_1 = null,
						_2 = null,
					},
					[8155] = new Feature
					{
						_0 = new int[] { 906 },
						_1 = null,
						_2 = null,
					},
					[8157] = new Feature
					{
						_0 = new int[] { 8190, 768 },
						_1 = null,
						_2 = null,
					},
					[8158] = new Feature
					{
						_0 = new int[] { 8190, 769 },
						_1 = null,
						_2 = null,
					},
					[8159] = new Feature
					{
						_0 = new int[] { 8190, 834 },
						_1 = null,
						_2 = null,
					},
					[8160] = new Feature
					{
						_0 = new int[] { 965, 774 },
						_1 = null,
						_2 = null,
					},
					[8161] = new Feature
					{
						_0 = new int[] { 965, 772 },
						_1 = null,
						_2 = null,
					},
					[8162] = new Feature
					{
						_0 = new int[] { 971, 768 },
						_1 = null,
						_2 = null,
					},
					[8163] = new Feature
					{
						_0 = new int[] { 944 },
						_1 = null,
						_2 = null,
					},
					[8164] = new Feature
					{
						_0 = new int[] { 961, 787 },
						_1 = null,
						_2 = null,
					},
					[8165] = new Feature
					{
						_0 = new int[] { 961, 788 },
						_1 = null,
						_2 = null,
					},
					[8166] = new Feature
					{
						_0 = new int[] { 965, 834 },
						_1 = null,
						_2 = null,
					},
					[8167] = new Feature
					{
						_0 = new int[] { 971, 834 },
						_1 = null,
						_2 = null,
					},
					[8168] = new Feature
					{
						_0 = new int[] { 933, 774 },
						_1 = null,
						_2 = null,
					},
					[8169] = new Feature
					{
						_0 = new int[] { 933, 772 },
						_1 = null,
						_2 = null,
					},
					[8170] = new Feature
					{
						_0 = new int[] { 933, 768 },
						_1 = null,
						_2 = null,
					},
					[8171] = new Feature
					{
						_0 = new int[] { 910 },
						_1 = null,
						_2 = null,
					},
					[8172] = new Feature
					{
						_0 = new int[] { 929, 788 },
						_1 = null,
						_2 = null,
					},
					[8173] = new Feature
					{
						_0 = new int[] { 168, 768 },
						_1 = null,
						_2 = null,
					},
					[8174] = new Feature
					{
						_0 = new int[] { 901 },
						_1 = null,
						_2 = null,
					},
					[8175] = new Feature
					{
						_0 = new int[] { 96 },
						_1 = null,
						_2 = null,
					},
					[8178] = new Feature
					{
						_0 = new int[] { 8060, 837 },
						_1 = null,
						_2 = null,
					},
					[8179] = new Feature
					{
						_0 = new int[] { 969, 837 },
						_1 = null,
						_2 = null,
					},
					[8180] = new Feature
					{
						_0 = new int[] { 974, 837 },
						_1 = null,
						_2 = null,
					},
					[8182] = new Feature
					{
						_0 = new int[] { 969, 834 },
						_1 = null,
						_2 = new Dictionary<int, int> { [837] = 8183, },
					},
					[8183] = new Feature
					{
						_0 = new int[] { 8182, 837 },
						_1 = null,
						_2 = null,
					},
					[8184] = new Feature
					{
						_0 = new int[] { 927, 768 },
						_1 = null,
						_2 = null,
					},
					[8185] = new Feature
					{
						_0 = new int[] { 908 },
						_1 = null,
						_2 = null,
					},
					[8186] = new Feature
					{
						_0 = new int[] { 937, 768 },
						_1 = null,
						_2 = null,
					},
					[8187] = new Feature
					{
						_0 = new int[] { 911 },
						_1 = null,
						_2 = null,
					},
					[8188] = new Feature
					{
						_0 = new int[] { 937, 837 },
						_1 = null,
						_2 = null,
					},
					[8189] = new Feature
					{
						_0 = new int[] { 180 },
						_1 = null,
						_2 = null,
					},
					[8190] = new Feature
					{
						_0 = new int[] { 32, 788 },
						_1 = 256,
						_2 = new Dictionary<int, int> { [768] = 8157, [769] = 8158, [834] = 8159, },
					},
				},
				[8192] = new Dictionary<int, Feature>
				{
					[8192] = new Feature
					{
						_0 = new int[] { 8194 },
						_1 = null,
						_2 = null,
					},
					[8193] = new Feature
					{
						_0 = new int[] { 8195 },
						_1 = null,
						_2 = null,
					},
					[8194] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8195] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8196] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8197] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8198] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8199] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8200] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8201] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8202] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8209] = new Feature
					{
						_0 = new int[] { 8208 },
						_1 = 256,
						_2 = null,
					},
					[8215] = new Feature
					{
						_0 = new int[] { 32, 819 },
						_1 = 256,
						_2 = null,
					},
					[8228] = new Feature
					{
						_0 = new int[] { 46 },
						_1 = 256,
						_2 = null,
					},
					[8229] = new Feature
					{
						_0 = new int[] { 46, 46 },
						_1 = 256,
						_2 = null,
					},
					[8230] = new Feature
					{
						_0 = new int[] { 46, 46, 46 },
						_1 = 256,
						_2 = null,
					},
					[8239] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8243] = new Feature
					{
						_0 = new int[] { 8242, 8242 },
						_1 = 256,
						_2 = null,
					},
					[8244] = new Feature
					{
						_0 = new int[] { 8242, 8242, 8242 },
						_1 = 256,
						_2 = null,
					},
					[8246] = new Feature
					{
						_0 = new int[] { 8245, 8245 },
						_1 = 256,
						_2 = null,
					},
					[8247] = new Feature
					{
						_0 = new int[] { 8245, 8245, 8245 },
						_1 = 256,
						_2 = null,
					},
					[8252] = new Feature
					{
						_0 = new int[] { 33, 33 },
						_1 = 256,
						_2 = null,
					},
					[8254] = new Feature
					{
						_0 = new int[] { 32, 773 },
						_1 = 256,
						_2 = null,
					},
					[8263] = new Feature
					{
						_0 = new int[] { 63, 63 },
						_1 = 256,
						_2 = null,
					},
					[8264] = new Feature
					{
						_0 = new int[] { 63, 33 },
						_1 = 256,
						_2 = null,
					},
					[8265] = new Feature
					{
						_0 = new int[] { 33, 63 },
						_1 = 256,
						_2 = null,
					},
					[8279] = new Feature
					{
						_0 = new int[] { 8242, 8242, 8242, 8242 },
						_1 = 256,
						_2 = null,
					},
					[8287] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[8304] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
					[8305] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[8308] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[8309] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[8310] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[8311] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[8312] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[8313] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
					[8314] = new Feature
					{
						_0 = new int[] { 43 },
						_1 = 256,
						_2 = null,
					},
					[8315] = new Feature
					{
						_0 = new int[] { 8722 },
						_1 = 256,
						_2 = null,
					},
					[8316] = new Feature
					{
						_0 = new int[] { 61 },
						_1 = 256,
						_2 = null,
					},
					[8317] = new Feature
					{
						_0 = new int[] { 40 },
						_1 = 256,
						_2 = null,
					},
					[8318] = new Feature
					{
						_0 = new int[] { 41 },
						_1 = 256,
						_2 = null,
					},
					[8319] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[8320] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
					[8321] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[8322] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[8323] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[8324] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[8325] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[8326] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[8327] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[8328] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[8329] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
					[8330] = new Feature
					{
						_0 = new int[] { 43 },
						_1 = 256,
						_2 = null,
					},
					[8331] = new Feature
					{
						_0 = new int[] { 8722 },
						_1 = 256,
						_2 = null,
					},
					[8332] = new Feature
					{
						_0 = new int[] { 61 },
						_1 = 256,
						_2 = null,
					},
					[8333] = new Feature
					{
						_0 = new int[] { 40 },
						_1 = 256,
						_2 = null,
					},
					[8334] = new Feature
					{
						_0 = new int[] { 41 },
						_1 = 256,
						_2 = null,
					},
					[8336] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[8337] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[8338] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[8339] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[8340] = new Feature
					{
						_0 = new int[] { 601 },
						_1 = 256,
						_2 = null,
					},
					[8341] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[8342] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[8343] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},


					[8344] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[8345] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[8346] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[8347] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[8348] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[8360] = new Feature
					{
						_0 = new int[] { 82, 115 },
						_1 = 256,
						_2 = null,
					},
					[8400] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8401] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8402] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8403] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8404] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8405] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8406] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8407] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8408] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8409] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8410] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8411] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8412] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8417] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8421] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8422] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8423] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8424] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[8425] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[8426] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8427] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[8428] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[8429] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[8430] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[8431] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[8432] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[8448] = new Dictionary<int, Feature>
				{
					[8448] = new Feature
					{
						_0 = new int[] { 97, 47, 99 },
						_1 = 256,
						_2 = null,
					},
					[8449] = new Feature
					{
						_0 = new int[] { 97, 47, 115 },
						_1 = 256,
						_2 = null,
					},
					[8450] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[8451] = new Feature
					{
						_0 = new int[] { 176, 67 },
						_1 = 256,
						_2 = null,
					},
					[8453] = new Feature
					{
						_0 = new int[] { 99, 47, 111 },
						_1 = 256,
						_2 = null,
					},
					[8454] = new Feature
					{
						_0 = new int[] { 99, 47, 117 },
						_1 = 256,
						_2 = null,
					},
					[8455] = new Feature
					{
						_0 = new int[] { 400 },
						_1 = 256,
						_2 = null,
					},
					[8457] = new Feature
					{
						_0 = new int[] { 176, 70 },
						_1 = 256,
						_2 = null,
					},
					[8458] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[8459] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[8460] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[8461] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[8462] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[8463] = new Feature
					{
						_0 = new int[] { 295 },
						_1 = 256,
						_2 = null,
					},
					[8464] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[8465] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[8466] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[8467] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[8469] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[8470] = new Feature
					{
						_0 = new int[] { 78, 111 },
						_1 = 256,
						_2 = null,
					},
					[8473] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[8474] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[8475] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[8476] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[8477] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[8480] = new Feature
					{
						_0 = new int[] { 83, 77 },
						_1 = 256,
						_2 = null,
					},
					[8481] = new Feature
					{
						_0 = new int[] { 84, 69, 76 },
						_1 = 256,
						_2 = null,
					},
					[8482] = new Feature
					{
						_0 = new int[] { 84, 77 },
						_1 = 256,
						_2 = null,
					},
					[8484] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[8486] = new Feature
					{
						_0 = new int[] { 937 },
						_1 = null,
						_2 = null,
					},
					[8488] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[8490] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = null,
						_2 = null,
					},
					[8491] = new Feature
					{
						_0 = new int[] { 197 },
						_1 = null,
						_2 = null,
					},
					[8492] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[8493] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[8495] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[8496] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[8497] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[8499] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[8500] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[8501] = new Feature
					{
						_0 = new int[] { 1488 },
						_1 = 256,
						_2 = null,
					},
					[8502] = new Feature
					{
						_0 = new int[] { 1489 },
						_1 = 256,
						_2 = null,
					},
					[8503] = new Feature
					{
						_0 = new int[] { 1490 },
						_1 = 256,
						_2 = null,
					},
					[8504] = new Feature
					{
						_0 = new int[] { 1491 },
						_1 = 256,
						_2 = null,
					},
					[8505] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[8507] = new Feature
					{
						_0 = new int[] { 70, 65, 88 },
						_1 = 256,
						_2 = null,
					},
					[8508] = new Feature
					{
						_0 = new int[] { 960 },
						_1 = 256,
						_2 = null,
					},
					[8509] = new Feature
					{
						_0 = new int[] { 947 },
						_1 = 256,
						_2 = null,
					},
					[8510] = new Feature
					{
						_0 = new int[] { 915 },
						_1 = 256,
						_2 = null,
					},
					[8511] = new Feature
					{
						_0 = new int[] { 928 },
						_1 = 256,
						_2 = null,
					},
					[8512] = new Feature
					{
						_0 = new int[] { 8721 },
						_1 = 256,
						_2 = null,
					},
					[8517] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[8518] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[8519] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[8520] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[8521] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[8528] = new Feature
					{
						_0 = new int[] { 49, 8260, 55 },
						_1 = 256,
						_2 = null,
					},
					[8529] = new Feature
					{
						_0 = new int[] { 49, 8260, 57 },
						_1 = 256,
						_2 = null,
					},
					[8530] = new Feature
					{
						_0 = new int[] { 49, 8260, 49, 48 },
						_1 = 256,
						_2 = null,
					},
					[8531] = new Feature
					{
						_0 = new int[] { 49, 8260, 51 },
						_1 = 256,
						_2 = null,
					},
					[8532] = new Feature
					{
						_0 = new int[] { 50, 8260, 51 },
						_1 = 256,
						_2 = null,
					},
					[8533] = new Feature
					{
						_0 = new int[] { 49, 8260, 53 },
						_1 = 256,
						_2 = null,
					},
					[8534] = new Feature
					{
						_0 = new int[] { 50, 8260, 53 },
						_1 = 256,
						_2 = null,
					},
					[8535] = new Feature
					{
						_0 = new int[] { 51, 8260, 53 },
						_1 = 256,
						_2 = null,
					},
					[8536] = new Feature
					{
						_0 = new int[] { 52, 8260, 53 },
						_1 = 256,
						_2 = null,
					},
					[8537] = new Feature
					{
						_0 = new int[] { 49, 8260, 54 },
						_1 = 256,
						_2 = null,
					},
					[8538] = new Feature
					{
						_0 = new int[] { 53, 8260, 54 },
						_1 = 256,
						_2 = null,
					},
					[8539] = new Feature
					{
						_0 = new int[] { 49, 8260, 56 },
						_1 = 256,
						_2 = null,
					},
					[8540] = new Feature
					{
						_0 = new int[] { 51, 8260, 56 },
						_1 = 256,
						_2 = null,
					},
					[8541] = new Feature
					{
						_0 = new int[] { 53, 8260, 56 },
						_1 = 256,
						_2 = null,
					},
					[8542] = new Feature
					{
						_0 = new int[] { 55, 8260, 56 },
						_1 = 256,
						_2 = null,
					},
					[8543] = new Feature
					{
						_0 = new int[] { 49, 8260 },
						_1 = 256,
						_2 = null,
					},
					[8544] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[8545] = new Feature
					{
						_0 = new int[] { 73, 73 },
						_1 = 256,
						_2 = null,
					},
					[8546] = new Feature
					{
						_0 = new int[] { 73, 73, 73 },
						_1 = 256,
						_2 = null,
					},
					[8547] = new Feature
					{
						_0 = new int[] { 73, 86 },
						_1 = 256,
						_2 = null,
					},
					[8548] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[8549] = new Feature
					{
						_0 = new int[] { 86, 73 },
						_1 = 256,
						_2 = null,
					},
					[8550] = new Feature
					{
						_0 = new int[] { 86, 73, 73 },
						_1 = 256,
						_2 = null,
					},
					[8551] = new Feature
					{
						_0 = new int[] { 86, 73, 73, 73 },
						_1 = 256,
						_2 = null,
					},
					[8552] = new Feature
					{
						_0 = new int[] { 73, 88 },
						_1 = 256,
						_2 = null,
					},
					[8553] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[8554] = new Feature
					{
						_0 = new int[] { 88, 73 },
						_1 = 256,
						_2 = null,
					},
					[8555] = new Feature
					{
						_0 = new int[] { 88, 73, 73 },
						_1 = 256,
						_2 = null,
					},
					[8556] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[8557] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[8558] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[8559] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[8560] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[8561] = new Feature
					{
						_0 = new int[] { 105, 105 },
						_1 = 256,
						_2 = null,
					},
					[8562] = new Feature
					{
						_0 = new int[] { 105, 105, 105 },
						_1 = 256,
						_2 = null,
					},
					[8563] = new Feature
					{
						_0 = new int[] { 105, 118 },
						_1 = 256,
						_2 = null,
					},
					[8564] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[8565] = new Feature
					{
						_0 = new int[] { 118, 105 },
						_1 = 256,
						_2 = null,
					},
					[8566] = new Feature
					{
						_0 = new int[] { 118, 105, 105 },
						_1 = 256,
						_2 = null,
					},
					[8567] = new Feature
					{
						_0 = new int[] { 118, 105, 105, 105 },
						_1 = 256,
						_2 = null,
					},
					[8568] = new Feature
					{
						_0 = new int[] { 105, 120 },
						_1 = 256,
						_2 = null,
					},
					[8569] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[8570] = new Feature
					{
						_0 = new int[] { 120, 105 },
						_1 = 256,
						_2 = null,
					},
					[8571] = new Feature
					{
						_0 = new int[] { 120, 105, 105 },
						_1 = 256,
						_2 = null,
					},
					[8572] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[8573] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[8574] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[8575] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[8585] = new Feature
					{
						_0 = new int[] { 48, 8260, 51 },
						_1 = 256,
						_2 = null,
					},
					[8592] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8602, },
					},
					[8594] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8603, },
					},
					[8596] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8622, },
					},
					[8602] = new Feature
					{
						_0 = new int[] { 8592, 824 },
						_1 = null,
						_2 = null,
					},
					[8603] = new Feature
					{
						_0 = new int[] { 8594, 824 },
						_1 = null,
						_2 = null,
					},
					[8622] = new Feature
					{
						_0 = new int[] { 8596, 824 },
						_1 = null,
						_2 = null,
					},
					[8653] = new Feature
					{
						_0 = new int[] { 8656, 824 },
						_1 = null,
						_2 = null,
					},
					[8654] = new Feature
					{
						_0 = new int[] { 8660, 824 },
						_1 = null,
						_2 = null,
					},
					[8655] = new Feature
					{
						_0 = new int[] { 8658, 824 },
						_1 = null,
						_2 = null,
					},
					[8656] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8653, },
					},
					[8658] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8655, },
					},
					[8660] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8654, },
					},
				},
				[8704] = new Dictionary<int, Feature>
				{
					[8707] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8708, },
					},
					[8708] = new Feature
					{
						_0 = new int[] { 8707, 824 },
						_1 = null,
						_2 = null,
					},
					[8712] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8713, },
					},
					[8713] = new Feature
					{
						_0 = new int[] { 8712, 824 },
						_1 = null,
						_2 = null,
					},
					[8715] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8716, },
					},
					[8716] = new Feature
					{
						_0 = new int[] { 8715, 824 },
						_1 = null,
						_2 = null,
					},
					[8739] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8740, },
					},
					[8740] = new Feature
					{
						_0 = new int[] { 8739, 824 },
						_1 = null,
						_2 = null,
					},
					[8741] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8742, },
					},
					[8742] = new Feature
					{
						_0 = new int[] { 8741, 824 },
						_1 = null,
						_2 = null,
					},
					[8748] = new Feature
					{
						_0 = new int[] { 8747, 8747 },
						_1 = 256,
						_2 = null,
					},
					[8749] = new Feature
					{
						_0 = new int[] { 8747, 8747, 8747 },
						_1 = 256,
						_2 = null,
					},
					[8751] = new Feature
					{
						_0 = new int[] { 8750, 8750 },
						_1 = 256,
						_2 = null,
					},
					[8752] = new Feature
					{
						_0 = new int[] { 8750, 8750, 8750 },
						_1 = 256,
						_2 = null,
					},
					[8764] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8769, },
					},
					[8769] = new Feature
					{
						_0 = new int[] { 8764, 824 },
						_1 = null,
						_2 = null,
					},
					[8771] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8772, },
					},
					[8772] = new Feature
					{
						_0 = new int[] { 8771, 824 },
						_1 = null,
						_2 = null,
					},
					[8773] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8775, },
					},
					[8775] = new Feature
					{
						_0 = new int[] { 8773, 824 },
						_1 = null,
						_2 = null,
					},
					[8776] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8777, },
					},
					[8777] = new Feature
					{
						_0 = new int[] { 8776, 824 },
						_1 = null,
						_2 = null,
					},
					[8781] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8813, },
					},
					[8800] = new Feature
					{
						_0 = new int[] { 61, 824 },
						_1 = null,
						_2 = null,
					},
					[8801] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8802, },
					},
					[8802] = new Feature
					{
						_0 = new int[] { 8801, 824 },
						_1 = null,
						_2 = null,
					},
					[8804] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8816, },
					},
					[8805] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8817, },
					},
					[8813] = new Feature
					{
						_0 = new int[] { 8781, 824 },
						_1 = null,
						_2 = null,
					},
					[8814] = new Feature
					{
						_0 = new int[] { 60, 824 },
						_1 = null,
						_2 = null,
					},
					[8815] = new Feature
					{
						_0 = new int[] { 62, 824 },
						_1 = null,
						_2 = null,
					},
					[8816] = new Feature
					{
						_0 = new int[] { 8804, 824 },
						_1 = null,
						_2 = null,
					},
					[8817] = new Feature
					{
						_0 = new int[] { 8805, 824 },
						_1 = null,
						_2 = null,
					},
					[8818] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8820, },
					},
					[8819] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8821, },
					},
					[8820] = new Feature
					{
						_0 = new int[] { 8818, 824 },
						_1 = null,
						_2 = null,
					},
					[8821] = new Feature
					{
						_0 = new int[] { 8819, 824 },
						_1 = null,
						_2 = null,
					},
					[8822] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8824, },
					},
					[8823] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8825, },
					},
					[8824] = new Feature
					{
						_0 = new int[] { 8822, 824 },
						_1 = null,
						_2 = null,
					},
					[8825] = new Feature
					{
						_0 = new int[] { 8823, 824 },
						_1 = null,
						_2 = null,
					},
					[8826] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8832, },
					},
					[8827] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8833, },
					},
					[8828] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8928, },
					},
					[8829] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8929, },
					},
					[8832] = new Feature
					{
						_0 = new int[] { 8826, 824 },
						_1 = null,
						_2 = null,
					},
					[8833] = new Feature
					{
						_0 = new int[] { 8827, 824 },
						_1 = null,
						_2 = null,
					},
					[8834] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8836, },
					},
					[8835] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8837, },
					},
					[8836] = new Feature
					{
						_0 = new int[] { 8834, 824 },
						_1 = null,
						_2 = null,
					},
					[8837] = new Feature
					{
						_0 = new int[] { 8835, 824 },
						_1 = null,
						_2 = null,
					},
					[8838] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8840, },
					},
					[8839] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8841, },
					},
					[8840] = new Feature
					{
						_0 = new int[] { 8838, 824 },
						_1 = null,
						_2 = null,
					},
					[8841] = new Feature
					{
						_0 = new int[] { 8839, 824 },
						_1 = null,
						_2 = null,
					},
					[8849] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8930, },
					},
					[8850] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8931, },
					},
					[8866] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8876, },
					},
					[8872] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8877, },
					},
					[8873] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8878, },
					},
					[8875] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8879, },
					},
					[8876] = new Feature
					{
						_0 = new int[] { 8866, 824 },
						_1 = null,
						_2 = null,
					},
					[8877] = new Feature
					{
						_0 = new int[] { 8872, 824 },
						_1 = null,
						_2 = null,
					},
					[8878] = new Feature
					{
						_0 = new int[] { 8873, 824 },
						_1 = null,
						_2 = null,
					},
					[8879] = new Feature
					{
						_0 = new int[] { 8875, 824 },
						_1 = null,
						_2 = null,
					},
					[8882] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8938, },
					},
					[8883] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8939, },
					},
					[8884] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8940, },
					},
					[8885] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [824] = 8941, },
					},
					[8928] = new Feature
					{
						_0 = new int[] { 8828, 824 },
						_1 = null,
						_2 = null,
					},
					[8929] = new Feature
					{
						_0 = new int[] { 8829, 824 },
						_1 = null,
						_2 = null,
					},
					[8930] = new Feature
					{
						_0 = new int[] { 8849, 824 },
						_1 = null,
						_2 = null,
					},
					[8931] = new Feature
					{
						_0 = new int[] { 8850, 824 },
						_1 = null,
						_2 = null,
					},
					[8938] = new Feature
					{
						_0 = new int[] { 8882, 824 },
						_1 = null,
						_2 = null,
					},
					[8939] = new Feature
					{
						_0 = new int[] { 8883, 824 },
						_1 = null,
						_2 = null,
					},
					[8940] = new Feature
					{
						_0 = new int[] { 8884, 824 },
						_1 = null,
						_2 = null,
					},
					[8941] = new Feature
					{
						_0 = new int[] { 8885, 824 },
						_1 = null,
						_2 = null,
					},
				},
				[8960] = new Dictionary<int, Feature>
				{
					[9001] = new Feature
					{
						_0 = new int[] { 12296 },
						_1 = null,
						_2 = null,
					},
					[9002] = new Feature
					{
						_0 = new int[] { 12297 },
						_1 = null,
						_2 = null,
					},
				},
				[9216] = new Dictionary<int, Feature>
				{
					[9312] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[9313] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[9314] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[9315] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[9316] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[9317] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[9318] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[9319] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[9320] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
					[9321] = new Feature
					{
						_0 = new int[] { 49, 48 },
						_1 = 256,
						_2 = null,
					},
					[9322] = new Feature
					{
						_0 = new int[] { 49, 49 },
						_1 = 256,
						_2 = null,
					},
					[9323] = new Feature
					{
						_0 = new int[] { 49, 50 },
						_1 = 256,
						_2 = null,
					},
					[9324] = new Feature
					{
						_0 = new int[] { 49, 51 },
						_1 = 256,
						_2 = null,
					},
					[9325] = new Feature
					{
						_0 = new int[] { 49, 52 },
						_1 = 256,
						_2 = null,
					},
					[9326] = new Feature
					{
						_0 = new int[] { 49, 53 },
						_1 = 256,
						_2 = null,
					},
					[9327] = new Feature
					{
						_0 = new int[] { 49, 54 },
						_1 = 256,
						_2 = null,
					},
					[9328] = new Feature
					{
						_0 = new int[] { 49, 55 },
						_1 = 256,
						_2 = null,
					},
					[9329] = new Feature
					{
						_0 = new int[] { 49, 56 },
						_1 = 256,
						_2 = null,
					},
					[9330] = new Feature
					{
						_0 = new int[] { 49, 57 },
						_1 = 256,
						_2 = null,
					},
					[9331] = new Feature
					{
						_0 = new int[] { 50, 48 },
						_1 = 256,
						_2 = null,
					},
					[9332] = new Feature
					{
						_0 = new int[] { 40, 49, 41 },
						_1 = 256,
						_2 = null,
					},
					[9333] = new Feature
					{
						_0 = new int[] { 40, 50, 41 },
						_1 = 256,
						_2 = null,
					},
					[9334] = new Feature
					{
						_0 = new int[] { 40, 51, 41 },
						_1 = 256,
						_2 = null,
					},
					[9335] = new Feature
					{
						_0 = new int[] { 40, 52, 41 },
						_1 = 256,
						_2 = null,
					},
					[9336] = new Feature
					{
						_0 = new int[] { 40, 53, 41 },
						_1 = 256,
						_2 = null,
					},
					[9337] = new Feature
					{
						_0 = new int[] { 40, 54, 41 },
						_1 = 256,
						_2 = null,
					},
					[9338] = new Feature
					{
						_0 = new int[] { 40, 55, 41 },
						_1 = 256,
						_2 = null,
					},
					[9339] = new Feature
					{
						_0 = new int[] { 40, 56, 41 },
						_1 = 256,
						_2 = null,
					},
					[9340] = new Feature
					{
						_0 = new int[] { 40, 57, 41 },
						_1 = 256,
						_2 = null,
					},
					[9341] = new Feature
					{
						_0 = new int[] { 40, 49, 48, 41 },
						_1 = 256,
						_2 = null,
					},
					[9342] = new Feature
					{
						_0 = new int[] { 40, 49, 49, 41 },
						_1 = 256,
						_2 = null,
					},
					[9343] = new Feature
					{
						_0 = new int[] { 40, 49, 50, 41 },
						_1 = 256,
						_2 = null,
					},
					[9344] = new Feature
					{
						_0 = new int[] { 40, 49, 51, 41 },
						_1 = 256,
						_2 = null,
					},
					[9345] = new Feature
					{
						_0 = new int[] { 40, 49, 52, 41 },
						_1 = 256,
						_2 = null,
					},
					[9346] = new Feature
					{
						_0 = new int[] { 40, 49, 53, 41 },
						_1 = 256,
						_2 = null,
					},
					[9347] = new Feature
					{
						_0 = new int[] { 40, 49, 54, 41 },
						_1 = 256,
						_2 = null,
					},
					[9348] = new Feature
					{
						_0 = new int[] { 40, 49, 55, 41 },
						_1 = 256,
						_2 = null,
					},
					[9349] = new Feature
					{
						_0 = new int[] { 40, 49, 56, 41 },
						_1 = 256,
						_2 = null,
					},
					[9350] = new Feature
					{
						_0 = new int[] { 40, 49, 57, 41 },
						_1 = 256,
						_2 = null,
					},
					[9351] = new Feature
					{
						_0 = new int[] { 40, 50, 48, 41 },
						_1 = 256,
						_2 = null,
					},
					[9352] = new Feature
					{
						_0 = new int[] { 49, 46 },
						_1 = 256,
						_2 = null,
					},
					[9353] = new Feature
					{
						_0 = new int[] { 50, 46 },
						_1 = 256,
						_2 = null,
					},
					[9354] = new Feature
					{
						_0 = new int[] { 51, 46 },
						_1 = 256,
						_2 = null,
					},
					[9355] = new Feature
					{
						_0 = new int[] { 52, 46 },
						_1 = 256,
						_2 = null,
					},
					[9356] = new Feature
					{
						_0 = new int[] { 53, 46 },
						_1 = 256,
						_2 = null,
					},
					[9357] = new Feature
					{
						_0 = new int[] { 54, 46 },
						_1 = 256,
						_2 = null,
					},
					[9358] = new Feature
					{
						_0 = new int[] { 55, 46 },
						_1 = 256,
						_2 = null,
					},
					[9359] = new Feature
					{
						_0 = new int[] { 56, 46 },
						_1 = 256,
						_2 = null,
					},
					[9360] = new Feature
					{
						_0 = new int[] { 57, 46 },
						_1 = 256,
						_2 = null,
					},
					[9361] = new Feature
					{
						_0 = new int[] { 49, 48, 46 },
						_1 = 256,
						_2 = null,
					},
					[9362] = new Feature
					{
						_0 = new int[] { 49, 49, 46 },
						_1 = 256,
						_2 = null,
					},
					[9363] = new Feature
					{
						_0 = new int[] { 49, 50, 46 },
						_1 = 256,
						_2 = null,
					},
					[9364] = new Feature
					{
						_0 = new int[] { 49, 51, 46 },
						_1 = 256,
						_2 = null,
					},
					[9365] = new Feature
					{
						_0 = new int[] { 49, 52, 46 },
						_1 = 256,
						_2 = null,
					},
					[9366] = new Feature
					{
						_0 = new int[] { 49, 53, 46 },
						_1 = 256,
						_2 = null,
					},
					[9367] = new Feature
					{
						_0 = new int[] { 49, 54, 46 },
						_1 = 256,
						_2 = null,
					},
					[9368] = new Feature
					{
						_0 = new int[] { 49, 55, 46 },
						_1 = 256,
						_2 = null,
					},
					[9369] = new Feature
					{
						_0 = new int[] { 49, 56, 46 },
						_1 = 256,
						_2 = null,
					},
					[9370] = new Feature
					{
						_0 = new int[] { 49, 57, 46 },
						_1 = 256,
						_2 = null,
					},
					[9371] = new Feature
					{
						_0 = new int[] { 50, 48, 46 },
						_1 = 256,
						_2 = null,
					},
					[9372] = new Feature
					{
						_0 = new int[] { 40, 97, 41 },
						_1 = 256,
						_2 = null,
					},
					[9373] = new Feature
					{
						_0 = new int[] { 40, 98, 41 },
						_1 = 256,
						_2 = null,
					},
					[9374] = new Feature
					{
						_0 = new int[] { 40, 99, 41 },
						_1 = 256,
						_2 = null,
					},
					[9375] = new Feature
					{
						_0 = new int[] { 40, 100, 41 },
						_1 = 256,
						_2 = null,
					},
					[9376] = new Feature
					{
						_0 = new int[] { 40, 101, 41 },
						_1 = 256,
						_2 = null,
					},
					[9377] = new Feature
					{
						_0 = new int[] { 40, 102, 41 },
						_1 = 256,
						_2 = null,
					},
					[9378] = new Feature
					{
						_0 = new int[] { 40, 103, 41 },
						_1 = 256,
						_2 = null,
					},
					[9379] = new Feature
					{
						_0 = new int[] { 40, 104, 41 },
						_1 = 256,
						_2 = null,
					},
					[9380] = new Feature
					{
						_0 = new int[] { 40, 105, 41 },
						_1 = 256,
						_2 = null,
					},
					[9381] = new Feature
					{
						_0 = new int[] { 40, 106, 41 },
						_1 = 256,
						_2 = null,
					},
					[9382] = new Feature
					{
						_0 = new int[] { 40, 107, 41 },
						_1 = 256,
						_2 = null,
					},
					[9383] = new Feature
					{
						_0 = new int[] { 40, 108, 41 },
						_1 = 256,
						_2 = null,
					},
					[9384] = new Feature
					{
						_0 = new int[] { 40, 109, 41 },
						_1 = 256,
						_2 = null,
					},
					[9385] = new Feature
					{
						_0 = new int[] { 40, 110, 41 },
						_1 = 256,
						_2 = null,
					},
					[9386] = new Feature
					{
						_0 = new int[] { 40, 111, 41 },
						_1 = 256,
						_2 = null,
					},
					[9387] = new Feature
					{
						_0 = new int[] { 40, 112, 41 },
						_1 = 256,
						_2 = null,
					},
					[9388] = new Feature
					{
						_0 = new int[] { 40, 113, 41 },
						_1 = 256,
						_2 = null,
					},
					[9389] = new Feature
					{
						_0 = new int[] { 40, 114, 41 },
						_1 = 256,
						_2 = null,
					},
					[9390] = new Feature
					{
						_0 = new int[] { 40, 115, 41 },
						_1 = 256,
						_2 = null,
					},
					[9391] = new Feature
					{
						_0 = new int[] { 40, 116, 41 },
						_1 = 256,
						_2 = null,
					},
					[9392] = new Feature
					{
						_0 = new int[] { 40, 117, 41 },
						_1 = 256,
						_2 = null,
					},
					[9393] = new Feature
					{
						_0 = new int[] { 40, 118, 41 },
						_1 = 256,
						_2 = null,
					},
					[9394] = new Feature
					{
						_0 = new int[] { 40, 119, 41 },
						_1 = 256,
						_2 = null,
					},
					[9395] = new Feature
					{
						_0 = new int[] { 40, 120, 41 },
						_1 = 256,
						_2 = null,
					},
					[9396] = new Feature
					{
						_0 = new int[] { 40, 121, 41 },
						_1 = 256,
						_2 = null,
					},
					[9397] = new Feature
					{
						_0 = new int[] { 40, 122, 41 },
						_1 = 256,
						_2 = null,
					},
					[9398] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[9399] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[9400] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[9401] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[9402] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[9403] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[9404] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[9405] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[9406] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[9407] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[9408] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[9409] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[9410] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[9411] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[9412] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[9413] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[9414] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[9415] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[9416] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[9417] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[9418] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[9419] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[9420] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[9421] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[9422] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[9423] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[9424] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[9425] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[9426] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[9427] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[9428] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[9429] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[9430] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[9431] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[9432] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[9433] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[9434] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[9435] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[9436] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[9437] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[9438] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[9439] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[9440] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[9441] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[9442] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[9443] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[9444] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[9445] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[9446] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[9447] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[9448] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[9449] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[9450] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
				},
				[10752] = new Dictionary<int, Feature>
				{
					[10764] = new Feature
					{
						_0 = new int[] { 8747, 8747, 8747, 8747 },
						_1 = 256,
						_2 = null,
					},
					[10868] = new Feature
					{
						_0 = new int[] { 58, 58, 61 },
						_1 = 256,
						_2 = null,
					},
					[10869] = new Feature
					{
						_0 = new int[] { 61, 61 },
						_1 = 256,
						_2 = null,
					},
					[10870] = new Feature
					{
						_0 = new int[] { 61, 61, 61 },
						_1 = 256,
						_2 = null,
					},
					[10972] = new Feature
					{
						_0 = new int[] { 10973, 824 },
						_1 = 512,
						_2 = null,
					},
				},
				[11264] = new Dictionary<int, Feature>
				{
					[11388] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[11389] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[11503] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11504] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11505] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[11520] = new Dictionary<int, Feature>
				{
					[11631] = new Feature
					{
						_0 = new int[] { 11617 },
						_1 = 256,
						_2 = null,
					},
					[11647] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[11744] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11745] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11746] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11747] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11748] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11749] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11750] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11751] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11752] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11753] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11754] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11755] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11756] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11757] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11758] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11759] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11760] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11761] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11762] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11763] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11764] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11765] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11766] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11767] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11768] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11769] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11770] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11771] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11772] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11773] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11774] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[11775] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[11776] = new Dictionary<int, Feature>
				{
					[11935] = new Feature
					{
						_0 = new int[] { 27597 },
						_1 = 256,
						_2 = null,
					},
					[12019] = new Feature
					{
						_0 = new int[] { 40863 },
						_1 = 256,
						_2 = null,
					},
				},
				[12032] = new Dictionary<int, Feature>
				{
					[12032] = new Feature
					{
						_0 = new int[] { 19968 },
						_1 = 256,
						_2 = null,
					},
					[12033] = new Feature
					{
						_0 = new int[] { 20008 },
						_1 = 256,
						_2 = null,
					},
					[12034] = new Feature
					{
						_0 = new int[] { 20022 },
						_1 = 256,
						_2 = null,
					},
					[12035] = new Feature
					{
						_0 = new int[] { 20031 },
						_1 = 256,
						_2 = null,
					},
					[12036] = new Feature
					{
						_0 = new int[] { 20057 },
						_1 = 256,
						_2 = null,
					},
					[12037] = new Feature
					{
						_0 = new int[] { 20101 },
						_1 = 256,
						_2 = null,
					},
					[12038] = new Feature
					{
						_0 = new int[] { 20108 },
						_1 = 256,
						_2 = null,
					},
					[12039] = new Feature
					{
						_0 = new int[] { 20128 },
						_1 = 256,
						_2 = null,
					},
					[12040] = new Feature
					{
						_0 = new int[] { 20154 },
						_1 = 256,
						_2 = null,
					},
					[12041] = new Feature
					{
						_0 = new int[] { 20799 },
						_1 = 256,
						_2 = null,
					},
					[12042] = new Feature
					{
						_0 = new int[] { 20837 },
						_1 = 256,
						_2 = null,
					},
					[12043] = new Feature
					{
						_0 = new int[] { 20843 },
						_1 = 256,
						_2 = null,
					},
					[12044] = new Feature
					{
						_0 = new int[] { 20866 },
						_1 = 256,
						_2 = null,
					},
					[12045] = new Feature
					{
						_0 = new int[] { 20886 },
						_1 = 256,
						_2 = null,
					},
					[12046] = new Feature
					{
						_0 = new int[] { 20907 },
						_1 = 256,
						_2 = null,
					},
					[12047] = new Feature
					{
						_0 = new int[] { 20960 },
						_1 = 256,
						_2 = null,
					},
					[12048] = new Feature
					{
						_0 = new int[] { 20981 },
						_1 = 256,
						_2 = null,
					},
					[12049] = new Feature
					{
						_0 = new int[] { 20992 },
						_1 = 256,
						_2 = null,
					},
					[12050] = new Feature
					{
						_0 = new int[] { 21147 },
						_1 = 256,
						_2 = null,
					},
					[12051] = new Feature
					{
						_0 = new int[] { 21241 },
						_1 = 256,
						_2 = null,
					},
					[12052] = new Feature
					{
						_0 = new int[] { 21269 },
						_1 = 256,
						_2 = null,
					},
					[12053] = new Feature
					{
						_0 = new int[] { 21274 },
						_1 = 256,
						_2 = null,
					},
					[12054] = new Feature
					{
						_0 = new int[] { 21304 },
						_1 = 256,
						_2 = null,
					},
					[12055] = new Feature
					{
						_0 = new int[] { 21313 },
						_1 = 256,
						_2 = null,
					},
					[12056] = new Feature
					{
						_0 = new int[] { 21340 },
						_1 = 256,
						_2 = null,
					},
					[12057] = new Feature
					{
						_0 = new int[] { 21353 },
						_1 = 256,
						_2 = null,
					},
					[12058] = new Feature
					{
						_0 = new int[] { 21378 },
						_1 = 256,
						_2 = null,
					},
					[12059] = new Feature
					{
						_0 = new int[] { 21430 },
						_1 = 256,
						_2 = null,
					},
					[12060] = new Feature
					{
						_0 = new int[] { 21448 },
						_1 = 256,
						_2 = null,
					},
					[12061] = new Feature
					{
						_0 = new int[] { 21475 },
						_1 = 256,
						_2 = null,
					},
					[12062] = new Feature
					{
						_0 = new int[] { 22231 },
						_1 = 256,
						_2 = null,
					},
					[12063] = new Feature
					{
						_0 = new int[] { 22303 },
						_1 = 256,
						_2 = null,
					},
					[12064] = new Feature
					{
						_0 = new int[] { 22763 },
						_1 = 256,
						_2 = null,
					},
					[12065] = new Feature
					{
						_0 = new int[] { 22786 },
						_1 = 256,
						_2 = null,
					},
					[12066] = new Feature
					{
						_0 = new int[] { 22794 },
						_1 = 256,
						_2 = null,
					},
					[12067] = new Feature
					{
						_0 = new int[] { 22805 },
						_1 = 256,
						_2 = null,
					},
					[12068] = new Feature
					{
						_0 = new int[] { 22823 },
						_1 = 256,
						_2 = null,
					},
					[12069] = new Feature
					{
						_0 = new int[] { 22899 },
						_1 = 256,
						_2 = null,
					},
					[12070] = new Feature
					{
						_0 = new int[] { 23376 },
						_1 = 256,
						_2 = null,
					},
					[12071] = new Feature
					{
						_0 = new int[] { 23424 },
						_1 = 256,
						_2 = null,
					},
					[12072] = new Feature
					{
						_0 = new int[] { 23544 },
						_1 = 256,
						_2 = null,
					},
					[12073] = new Feature
					{
						_0 = new int[] { 23567 },
						_1 = 256,
						_2 = null,
					},
					[12074] = new Feature
					{
						_0 = new int[] { 23586 },
						_1 = 256,
						_2 = null,
					},
					[12075] = new Feature
					{
						_0 = new int[] { 23608 },
						_1 = 256,
						_2 = null,
					},
					[12076] = new Feature
					{
						_0 = new int[] { 23662 },
						_1 = 256,
						_2 = null,
					},
					[12077] = new Feature
					{
						_0 = new int[] { 23665 },
						_1 = 256,
						_2 = null,
					},
					[12078] = new Feature
					{
						_0 = new int[] { 24027 },
						_1 = 256,
						_2 = null,
					},
					[12079] = new Feature
					{
						_0 = new int[] { 24037 },
						_1 = 256,
						_2 = null,
					},
					[12080] = new Feature
					{
						_0 = new int[] { 24049 },
						_1 = 256,
						_2 = null,
					},
					[12081] = new Feature
					{
						_0 = new int[] { 24062 },
						_1 = 256,
						_2 = null,
					},
					[12082] = new Feature
					{
						_0 = new int[] { 24178 },
						_1 = 256,
						_2 = null,
					},
					[12083] = new Feature
					{
						_0 = new int[] { 24186 },
						_1 = 256,
						_2 = null,
					},
					[12084] = new Feature
					{
						_0 = new int[] { 24191 },
						_1 = 256,
						_2 = null,
					},
					[12085] = new Feature
					{
						_0 = new int[] { 24308 },
						_1 = 256,
						_2 = null,
					},
					[12086] = new Feature
					{
						_0 = new int[] { 24318 },
						_1 = 256,
						_2 = null,
					},
					[12087] = new Feature
					{
						_0 = new int[] { 24331 },
						_1 = 256,
						_2 = null,
					},
					[12088] = new Feature
					{
						_0 = new int[] { 24339 },
						_1 = 256,
						_2 = null,
					},
					[12089] = new Feature
					{
						_0 = new int[] { 24400 },
						_1 = 256,
						_2 = null,
					},
					[12090] = new Feature
					{
						_0 = new int[] { 24417 },
						_1 = 256,
						_2 = null,
					},
					[12091] = new Feature
					{
						_0 = new int[] { 24435 },


						_1 = 256,
						_2 = null,
					},
					[12092] = new Feature
					{
						_0 = new int[] { 24515 },
						_1 = 256,
						_2 = null,
					},
					[12093] = new Feature
					{
						_0 = new int[] { 25096 },
						_1 = 256,
						_2 = null,
					},
					[12094] = new Feature
					{
						_0 = new int[] { 25142 },
						_1 = 256,
						_2 = null,
					},
					[12095] = new Feature
					{
						_0 = new int[] { 25163 },
						_1 = 256,
						_2 = null,
					},
					[12096] = new Feature
					{
						_0 = new int[] { 25903 },
						_1 = 256,
						_2 = null,
					},
					[12097] = new Feature
					{
						_0 = new int[] { 25908 },
						_1 = 256,
						_2 = null,
					},
					[12098] = new Feature
					{
						_0 = new int[] { 25991 },
						_1 = 256,
						_2 = null,
					},
					[12099] = new Feature
					{
						_0 = new int[] { 26007 },
						_1 = 256,
						_2 = null,
					},
					[12100] = new Feature
					{
						_0 = new int[] { 26020 },
						_1 = 256,
						_2 = null,
					},
					[12101] = new Feature
					{
						_0 = new int[] { 26041 },
						_1 = 256,
						_2 = null,
					},
					[12102] = new Feature
					{
						_0 = new int[] { 26080 },
						_1 = 256,
						_2 = null,
					},
					[12103] = new Feature
					{
						_0 = new int[] { 26085 },
						_1 = 256,
						_2 = null,
					},
					[12104] = new Feature
					{
						_0 = new int[] { 26352 },
						_1 = 256,
						_2 = null,
					},
					[12105] = new Feature
					{
						_0 = new int[] { 26376 },
						_1 = 256,
						_2 = null,
					},
					[12106] = new Feature
					{
						_0 = new int[] { 26408 },
						_1 = 256,
						_2 = null,
					},
					[12107] = new Feature
					{
						_0 = new int[] { 27424 },
						_1 = 256,
						_2 = null,
					},
					[12108] = new Feature
					{
						_0 = new int[] { 27490 },
						_1 = 256,
						_2 = null,
					},
					[12109] = new Feature
					{
						_0 = new int[] { 27513 },
						_1 = 256,
						_2 = null,
					},
					[12110] = new Feature
					{
						_0 = new int[] { 27571 },
						_1 = 256,
						_2 = null,
					},
					[12111] = new Feature
					{
						_0 = new int[] { 27595 },
						_1 = 256,
						_2 = null,
					},
					[12112] = new Feature
					{
						_0 = new int[] { 27604 },
						_1 = 256,
						_2 = null,
					},
					[12113] = new Feature
					{
						_0 = new int[] { 27611 },
						_1 = 256,
						_2 = null,
					},
					[12114] = new Feature
					{
						_0 = new int[] { 27663 },
						_1 = 256,
						_2 = null,
					},
					[12115] = new Feature
					{
						_0 = new int[] { 27668 },
						_1 = 256,
						_2 = null,
					},
					[12116] = new Feature
					{
						_0 = new int[] { 27700 },
						_1 = 256,
						_2 = null,
					},
					[12117] = new Feature
					{
						_0 = new int[] { 28779 },
						_1 = 256,
						_2 = null,
					},
					[12118] = new Feature
					{
						_0 = new int[] { 29226 },
						_1 = 256,
						_2 = null,
					},
					[12119] = new Feature
					{
						_0 = new int[] { 29238 },
						_1 = 256,
						_2 = null,
					},
					[12120] = new Feature
					{
						_0 = new int[] { 29243 },
						_1 = 256,
						_2 = null,
					},
					[12121] = new Feature
					{
						_0 = new int[] { 29247 },
						_1 = 256,
						_2 = null,
					},
					[12122] = new Feature
					{
						_0 = new int[] { 29255 },
						_1 = 256,
						_2 = null,
					},
					[12123] = new Feature
					{
						_0 = new int[] { 29273 },
						_1 = 256,
						_2 = null,
					},
					[12124] = new Feature
					{
						_0 = new int[] { 29275 },
						_1 = 256,
						_2 = null,
					},
					[12125] = new Feature
					{
						_0 = new int[] { 29356 },
						_1 = 256,
						_2 = null,
					},
					[12126] = new Feature
					{
						_0 = new int[] { 29572 },
						_1 = 256,
						_2 = null,
					},
					[12127] = new Feature
					{
						_0 = new int[] { 29577 },
						_1 = 256,
						_2 = null,
					},
					[12128] = new Feature
					{
						_0 = new int[] { 29916 },
						_1 = 256,
						_2 = null,
					},
					[12129] = new Feature
					{
						_0 = new int[] { 29926 },
						_1 = 256,
						_2 = null,
					},
					[12130] = new Feature
					{
						_0 = new int[] { 29976 },
						_1 = 256,
						_2 = null,
					},
					[12131] = new Feature
					{
						_0 = new int[] { 29983 },
						_1 = 256,
						_2 = null,
					},
					[12132] = new Feature
					{
						_0 = new int[] { 29992 },
						_1 = 256,
						_2 = null,
					},
					[12133] = new Feature
					{
						_0 = new int[] { 30000 },
						_1 = 256,
						_2 = null,
					},
					[12134] = new Feature
					{
						_0 = new int[] { 30091 },
						_1 = 256,
						_2 = null,
					},
					[12135] = new Feature
					{
						_0 = new int[] { 30098 },
						_1 = 256,
						_2 = null,
					},
					[12136] = new Feature
					{
						_0 = new int[] { 30326 },
						_1 = 256,
						_2 = null,
					},
					[12137] = new Feature
					{
						_0 = new int[] { 30333 },
						_1 = 256,
						_2 = null,
					},
					[12138] = new Feature
					{
						_0 = new int[] { 30382 },
						_1 = 256,
						_2 = null,
					},
					[12139] = new Feature
					{
						_0 = new int[] { 30399 },
						_1 = 256,
						_2 = null,
					},
					[12140] = new Feature
					{
						_0 = new int[] { 30446 },
						_1 = 256,
						_2 = null,
					},
					[12141] = new Feature
					{
						_0 = new int[] { 30683 },
						_1 = 256,
						_2 = null,
					},
					[12142] = new Feature
					{
						_0 = new int[] { 30690 },
						_1 = 256,
						_2 = null,
					},
					[12143] = new Feature
					{
						_0 = new int[] { 30707 },
						_1 = 256,
						_2 = null,
					},
					[12144] = new Feature
					{
						_0 = new int[] { 31034 },
						_1 = 256,
						_2 = null,
					},
					[12145] = new Feature
					{
						_0 = new int[] { 31160 },
						_1 = 256,
						_2 = null,
					},
					[12146] = new Feature
					{
						_0 = new int[] { 31166 },
						_1 = 256,
						_2 = null,
					},
					[12147] = new Feature
					{
						_0 = new int[] { 31348 },
						_1 = 256,
						_2 = null,
					},
					[12148] = new Feature
					{
						_0 = new int[] { 31435 },
						_1 = 256,
						_2 = null,
					},
					[12149] = new Feature
					{
						_0 = new int[] { 31481 },
						_1 = 256,
						_2 = null,
					},
					[12150] = new Feature
					{
						_0 = new int[] { 31859 },
						_1 = 256,
						_2 = null,
					},
					[12151] = new Feature
					{
						_0 = new int[] { 31992 },
						_1 = 256,
						_2 = null,
					},
					[12152] = new Feature
					{
						_0 = new int[] { 32566 },
						_1 = 256,
						_2 = null,
					},
					[12153] = new Feature
					{
						_0 = new int[] { 32593 },
						_1 = 256,
						_2 = null,
					},
					[12154] = new Feature
					{
						_0 = new int[] { 32650 },
						_1 = 256,
						_2 = null,
					},
					[12155] = new Feature
					{
						_0 = new int[] { 32701 },
						_1 = 256,
						_2 = null,
					},
					[12156] = new Feature
					{
						_0 = new int[] { 32769 },
						_1 = 256,
						_2 = null,
					},
					[12157] = new Feature
					{
						_0 = new int[] { 32780 },
						_1 = 256,
						_2 = null,
					},
					[12158] = new Feature
					{
						_0 = new int[] { 32786 },
						_1 = 256,
						_2 = null,
					},
					[12159] = new Feature
					{
						_0 = new int[] { 32819 },
						_1 = 256,
						_2 = null,
					},
					[12160] = new Feature
					{
						_0 = new int[] { 32895 },
						_1 = 256,
						_2 = null,
					},
					[12161] = new Feature
					{
						_0 = new int[] { 32905 },
						_1 = 256,
						_2 = null,
					},
					[12162] = new Feature
					{
						_0 = new int[] { 33251 },
						_1 = 256,
						_2 = null,
					},
					[12163] = new Feature
					{
						_0 = new int[] { 33258 },
						_1 = 256,
						_2 = null,
					},
					[12164] = new Feature
					{
						_0 = new int[] { 33267 },
						_1 = 256,
						_2 = null,
					},
					[12165] = new Feature
					{
						_0 = new int[] { 33276 },
						_1 = 256,
						_2 = null,
					},
					[12166] = new Feature
					{
						_0 = new int[] { 33292 },
						_1 = 256,
						_2 = null,
					},
					[12167] = new Feature
					{
						_0 = new int[] { 33307 },
						_1 = 256,
						_2 = null,
					},
					[12168] = new Feature
					{
						_0 = new int[] { 33311 },
						_1 = 256,
						_2 = null,
					},
					[12169] = new Feature
					{
						_0 = new int[] { 33390 },
						_1 = 256,
						_2 = null,
					},
					[12170] = new Feature
					{
						_0 = new int[] { 33394 },
						_1 = 256,
						_2 = null,
					},
					[12171] = new Feature
					{
						_0 = new int[] { 33400 },
						_1 = 256,
						_2 = null,
					},
					[12172] = new Feature
					{
						_0 = new int[] { 34381 },
						_1 = 256,
						_2 = null,
					},
					[12173] = new Feature
					{
						_0 = new int[] { 34411 },
						_1 = 256,
						_2 = null,
					},
					[12174] = new Feature
					{
						_0 = new int[] { 34880 },
						_1 = 256,
						_2 = null,
					},
					[12175] = new Feature
					{
						_0 = new int[] { 34892 },
						_1 = 256,
						_2 = null,
					},
					[12176] = new Feature
					{
						_0 = new int[] { 34915 },
						_1 = 256,
						_2 = null,
					},
					[12177] = new Feature
					{
						_0 = new int[] { 35198 },
						_1 = 256,
						_2 = null,
					},
					[12178] = new Feature
					{
						_0 = new int[] { 35211 },
						_1 = 256,
						_2 = null,
					},
					[12179] = new Feature
					{
						_0 = new int[] { 35282 },
						_1 = 256,
						_2 = null,
					},
					[12180] = new Feature
					{
						_0 = new int[] { 35328 },
						_1 = 256,
						_2 = null,
					},
					[12181] = new Feature
					{
						_0 = new int[] { 35895 },
						_1 = 256,
						_2 = null,
					},
					[12182] = new Feature
					{
						_0 = new int[] { 35910 },
						_1 = 256,
						_2 = null,
					},
					[12183] = new Feature
					{
						_0 = new int[] { 35925 },
						_1 = 256,
						_2 = null,
					},
					[12184] = new Feature
					{
						_0 = new int[] { 35960 },
						_1 = 256,
						_2 = null,
					},
					[12185] = new Feature
					{
						_0 = new int[] { 35997 },
						_1 = 256,
						_2 = null,
					},
					[12186] = new Feature
					{
						_0 = new int[] { 36196 },
						_1 = 256,
						_2 = null,
					},
					[12187] = new Feature
					{
						_0 = new int[] { 36208 },
						_1 = 256,
						_2 = null,
					},
					[12188] = new Feature
					{
						_0 = new int[] { 36275 },
						_1 = 256,
						_2 = null,
					},
					[12189] = new Feature
					{
						_0 = new int[] { 36523 },
						_1 = 256,
						_2 = null,
					},
					[12190] = new Feature
					{
						_0 = new int[] { 36554 },
						_1 = 256,
						_2 = null,
					},
					[12191] = new Feature
					{
						_0 = new int[] { 36763 },
						_1 = 256,
						_2 = null,
					},
					[12192] = new Feature
					{
						_0 = new int[] { 36784 },
						_1 = 256,
						_2 = null,
					},
					[12193] = new Feature
					{
						_0 = new int[] { 36789 },
						_1 = 256,
						_2 = null,
					},
					[12194] = new Feature
					{
						_0 = new int[] { 37009 },
						_1 = 256,
						_2 = null,
					},
					[12195] = new Feature
					{
						_0 = new int[] { 37193 },
						_1 = 256,
						_2 = null,
					},
					[12196] = new Feature
					{
						_0 = new int[] { 37318 },
						_1 = 256,
						_2 = null,
					},
					[12197] = new Feature
					{
						_0 = new int[] { 37324 },
						_1 = 256,
						_2 = null,
					},
					[12198] = new Feature
					{
						_0 = new int[] { 37329 },
						_1 = 256,
						_2 = null,
					},
					[12199] = new Feature
					{
						_0 = new int[] { 38263 },
						_1 = 256,
						_2 = null,
					},
					[12200] = new Feature
					{
						_0 = new int[] { 38272 },
						_1 = 256,
						_2 = null,
					},
					[12201] = new Feature
					{
						_0 = new int[] { 38428 },
						_1 = 256,
						_2 = null,
					},
					[12202] = new Feature
					{
						_0 = new int[] { 38582 },
						_1 = 256,
						_2 = null,
					},
					[12203] = new Feature
					{
						_0 = new int[] { 38585 },
						_1 = 256,
						_2 = null,
					},
					[12204] = new Feature
					{
						_0 = new int[] { 38632 },
						_1 = 256,
						_2 = null,
					},
					[12205] = new Feature
					{
						_0 = new int[] { 38737 },
						_1 = 256,
						_2 = null,
					},
					[12206] = new Feature
					{
						_0 = new int[] { 38750 },
						_1 = 256,
						_2 = null,
					},
					[12207] = new Feature
					{
						_0 = new int[] { 38754 },
						_1 = 256,
						_2 = null,
					},
					[12208] = new Feature
					{
						_0 = new int[] { 38761 },
						_1 = 256,
						_2 = null,
					},
					[12209] = new Feature
					{
						_0 = new int[] { 38859 },
						_1 = 256,
						_2 = null,
					},
					[12210] = new Feature
					{
						_0 = new int[] { 38893 },
						_1 = 256,
						_2 = null,
					},
					[12211] = new Feature
					{
						_0 = new int[] { 38899 },
						_1 = 256,
						_2 = null,
					},
					[12212] = new Feature
					{
						_0 = new int[] { 38913 },
						_1 = 256,
						_2 = null,
					},
					[12213] = new Feature
					{
						_0 = new int[] { 39080 },
						_1 = 256,
						_2 = null,
					},
					[12214] = new Feature
					{
						_0 = new int[] { 39131 },
						_1 = 256,
						_2 = null,
					},
					[12215] = new Feature
					{
						_0 = new int[] { 39135 },
						_1 = 256,
						_2 = null,
					},
					[12216] = new Feature
					{
						_0 = new int[] { 39318 },
						_1 = 256,
						_2 = null,
					},
					[12217] = new Feature
					{
						_0 = new int[] { 39321 },
						_1 = 256,
						_2 = null,
					},
					[12218] = new Feature
					{
						_0 = new int[] { 39340 },
						_1 = 256,
						_2 = null,
					},
					[12219] = new Feature
					{
						_0 = new int[] { 39592 },
						_1 = 256,
						_2 = null,
					},
					[12220] = new Feature
					{
						_0 = new int[] { 39640 },
						_1 = 256,
						_2 = null,
					},
					[12221] = new Feature
					{
						_0 = new int[] { 39647 },
						_1 = 256,
						_2 = null,
					},
					[12222] = new Feature
					{
						_0 = new int[] { 39717 },
						_1 = 256,
						_2 = null,
					},
					[12223] = new Feature
					{
						_0 = new int[] { 39727 },
						_1 = 256,
						_2 = null,
					},
					[12224] = new Feature
					{
						_0 = new int[] { 39730 },
						_1 = 256,
						_2 = null,
					},
					[12225] = new Feature
					{
						_0 = new int[] { 39740 },
						_1 = 256,
						_2 = null,
					},
					[12226] = new Feature
					{
						_0 = new int[] { 39770 },
						_1 = 256,
						_2 = null,
					},
					[12227] = new Feature
					{
						_0 = new int[] { 40165 },
						_1 = 256,
						_2 = null,
					},
					[12228] = new Feature
					{
						_0 = new int[] { 40565 },
						_1 = 256,
						_2 = null,
					},
					[12229] = new Feature
					{
						_0 = new int[] { 40575 },
						_1 = 256,
						_2 = null,
					},
					[12230] = new Feature
					{
						_0 = new int[] { 40613 },
						_1 = 256,
						_2 = null,
					},
					[12231] = new Feature
					{
						_0 = new int[] { 40635 },
						_1 = 256,
						_2 = null,
					},
					[12232] = new Feature
					{
						_0 = new int[] { 40643 },
						_1 = 256,
						_2 = null,
					},
					[12233] = new Feature
					{
						_0 = new int[] { 40653 },
						_1 = 256,
						_2 = null,
					},
					[12234] = new Feature
					{
						_0 = new int[] { 40657 },
						_1 = 256,
						_2 = null,
					},
					[12235] = new Feature
					{
						_0 = new int[] { 40697 },
						_1 = 256,
						_2 = null,
					},
					[12236] = new Feature
					{
						_0 = new int[] { 40701 },
						_1 = 256,
						_2 = null,
					},
					[12237] = new Feature
					{
						_0 = new int[] { 40718 },
						_1 = 256,
						_2 = null,
					},
					[12238] = new Feature
					{
						_0 = new int[] { 40723 },
						_1 = 256,
						_2 = null,
					},
					[12239] = new Feature
					{
						_0 = new int[] { 40736 },
						_1 = 256,
						_2 = null,
					},
					[12240] = new Feature
					{
						_0 = new int[] { 40763 },
						_1 = 256,
						_2 = null,
					},
					[12241] = new Feature
					{
						_0 = new int[] { 40778 },
						_1 = 256,
						_2 = null,
					},
					[12242] = new Feature
					{
						_0 = new int[] { 40786 },
						_1 = 256,
						_2 = null,
					},
					[12243] = new Feature
					{
						_0 = new int[] { 40845 },
						_1 = 256,
						_2 = null,
					},
					[12244] = new Feature
					{
						_0 = new int[] { 40860 },
						_1 = 256,
						_2 = null,
					},
					[12245] = new Feature
					{
						_0 = new int[] { 40864 },
						_1 = 256,
						_2 = null,
					},
				},
				[12288] = new Dictionary<int, Feature>
				{
					[12288] = new Feature
					{
						_0 = new int[] { 32 },
						_1 = 256,
						_2 = null,
					},
					[12330] = new Feature
					{
						_0 = null,
						_1 = 218,
						_2 = null,
					},
					[12331] = new Feature
					{
						_0 = null,
						_1 = 228,
						_2 = null,
					},
					[12332] = new Feature
					{
						_0 = null,
						_1 = 232,
						_2 = null,
					},
					[12333] = new Feature
					{
						_0 = null,
						_1 = 222,
						_2 = null,
					},
					[12334] = new Feature
					{
						_0 = null,
						_1 = 224,
						_2 = null,
					},
					[12335] = new Feature
					{
						_0 = null,
						_1 = 224,
						_2 = null,
					},
					[12342] = new Feature
					{
						_0 = new int[] { 12306 },
						_1 = 256,
						_2 = null,
					},
					[12344] = new Feature
					{
						_0 = new int[] { 21313 },
						_1 = 256,
						_2 = null,
					},
					[12345] = new Feature
					{
						_0 = new int[] { 21316 },
						_1 = 256,
						_2 = null,
					},
					[12346] = new Feature
					{
						_0 = new int[] { 21317 },
						_1 = 256,
						_2 = null,
					},
					[12358] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12436, },
					},
					[12363] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12364, },
					},
					[12364] = new Feature
					{
						_0 = new int[] { 12363, 12441 },
						_1 = null,
						_2 = null,
					},
					[12365] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12366, },
					},
					[12366] = new Feature
					{
						_0 = new int[] { 12365, 12441 },
						_1 = null,
						_2 = null,
					},
					[12367] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12368, },
					},
					[12368] = new Feature
					{
						_0 = new int[] { 12367, 12441 },
						_1 = null,
						_2 = null,
					},
					[12369] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12370, },
					},
					[12370] = new Feature
					{
						_0 = new int[] { 12369, 12441 },
						_1 = null,
						_2 = null,
					},
					[12371] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12372, },
					},
					[12372] = new Feature
					{
						_0 = new int[] { 12371, 12441 },
						_1 = null,
						_2 = null,
					},
					[12373] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12374, },
					},
					[12374] = new Feature
					{
						_0 = new int[] { 12373, 12441 },
						_1 = null,
						_2 = null,
					},
					[12375] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12376, },
					},
					[12376] = new Feature
					{
						_0 = new int[] { 12375, 12441 },
						_1 = null,
						_2 = null,
					},
					[12377] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12378, },
					},
					[12378] = new Feature
					{
						_0 = new int[] { 12377, 12441 },
						_1 = null,
						_2 = null,
					},
					[12379] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12380, },
					},
					[12380] = new Feature
					{
						_0 = new int[] { 12379, 12441 },
						_1 = null,
						_2 = null,
					},
					[12381] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12382, },
					},
					[12382] = new Feature
					{
						_0 = new int[] { 12381, 12441 },
						_1 = null,
						_2 = null,
					},
					[12383] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12384, },
					},
					[12384] = new Feature
					{
						_0 = new int[] { 12383, 12441 },
						_1 = null,
						_2 = null,
					},
					[12385] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12386, },
					},
					[12386] = new Feature
					{
						_0 = new int[] { 12385, 12441 },
						_1 = null,
						_2 = null,
					},
					[12388] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12389, },
					},
					[12389] = new Feature
					{
						_0 = new int[] { 12388, 12441 },
						_1 = null,
						_2 = null,
					},
					[12390] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12391, },
					},
					[12391] = new Feature
					{
						_0 = new int[] { 12390, 12441 },
						_1 = null,
						_2 = null,
					},
					[12392] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12393, },
					},
					[12393] = new Feature
					{
						_0 = new int[] { 12392, 12441 },
						_1 = null,
						_2 = null,
					},
					[12399] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12400, [12442] = 12401, },
					},
					[12400] = new Feature
					{
						_0 = new int[] { 12399, 12441 },
						_1 = null,
						_2 = null,
					},
					[12401] = new Feature
					{
						_0 = new int[] { 12399, 12442 },
						_1 = null,
						_2 = null,
					},
					[12402] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12403, [12442] = 12404, },
					},
					[12403] = new Feature
					{
						_0 = new int[] { 12402, 12441 },
						_1 = null,
						_2 = null,
					},
					[12404] = new Feature
					{
						_0 = new int[] { 12402, 12442 },
						_1 = null,
						_2 = null,
					},
					[12405] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12406, [12442] = 12407, },
					},
					[12406] = new Feature
					{
						_0 = new int[] { 12405, 12441 },
						_1 = null,
						_2 = null,
					},
					[12407] = new Feature
					{
						_0 = new int[] { 12405, 12442 },
						_1 = null,
						_2 = null,
					},
					[12408] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12409, [12442] = 12410, },
					},
					[12409] = new Feature
					{
						_0 = new int[] { 12408, 12441 },
						_1 = null,
						_2 = null,
					},
					[12410] = new Feature
					{
						_0 = new int[] { 12408, 12442 },
						_1 = null,
						_2 = null,
					},
					[12411] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12412, [12442] = 12413, },
					},
					[12412] = new Feature
					{
						_0 = new int[] { 12411, 12441 },
						_1 = null,
						_2 = null,
					},
					[12413] = new Feature
					{
						_0 = new int[] { 12411, 12442 },
						_1 = null,
						_2 = null,
					},
					[12436] = new Feature
					{
						_0 = new int[] { 12358, 12441 },
						_1 = null,
						_2 = null,
					},
					[12441] = new Feature
					{
						_0 = null,
						_1 = 8,
						_2 = null,
					},
					[12442] = new Feature
					{
						_0 = null,
						_1 = 8,
						_2 = null,
					},
					[12443] = new Feature
					{
						_0 = new int[] { 32, 12441 },
						_1 = 256,
						_2 = null,
					},
					[12444] = new Feature
					{
						_0 = new int[] { 32, 12442 },
						_1 = 256,
						_2 = null,
					},
					[12445] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12446, },
					},
					[12446] = new Feature
					{
						_0 = new int[] { 12445, 12441 },
						_1 = null,
						_2 = null,
					},
					[12447] = new Feature
					{
						_0 = new int[] { 12424, 12426 },
						_1 = 256,
						_2 = null,
					},
					[12454] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12532, },
					},
					[12459] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12460, },
					},
					[12460] = new Feature
					{
						_0 = new int[] { 12459, 12441 },
						_1 = null,
						_2 = null,
					},
					[12461] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12462, },
					},
					[12462] = new Feature
					{
						_0 = new int[] { 12461, 12441 },
						_1 = null,
						_2 = null,
					},
					[12463] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12464, },
					},
					[12464] = new Feature
					{
						_0 = new int[] { 12463, 12441 },
						_1 = null,
						_2 = null,
					},
					[12465] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12466, },
					},
					[12466] = new Feature
					{
						_0 = new int[] { 12465, 12441 },
						_1 = null,
						_2 = null,
					},
					[12467] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12468, },
					},
					[12468] = new Feature
					{
						_0 = new int[] { 12467, 12441 },
						_1 = null,
						_2 = null,
					},
					[12469] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12470, },
					},
					[12470] = new Feature
					{
						_0 = new int[] { 12469, 12441 },
						_1 = null,
						_2 = null,
					},
					[12471] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12472, },
					},
					[12472] = new Feature
					{
						_0 = new int[] { 12471, 12441 },
						_1 = null,
						_2 = null,
					},
					[12473] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12474, },
					},
					[12474] = new Feature
					{
						_0 = new int[] { 12473, 12441 },
						_1 = null,
						_2 = null,
					},
					[12475] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12476, },
					},
					[12476] = new Feature
					{
						_0 = new int[] { 12475, 12441 },
						_1 = null,
						_2 = null,
					},
					[12477] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12478, },
					},
					[12478] = new Feature
					{
						_0 = new int[] { 12477, 12441 },
						_1 = null,
						_2 = null,
					},
					[12479] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12480, },
					},
					[12480] = new Feature
					{
						_0 = new int[] { 12479, 12441 },
						_1 = null,
						_2 = null,
					},
					[12481] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12482, },
					},
					[12482] = new Feature
					{
						_0 = new int[] { 12481, 12441 },
						_1 = null,
						_2 = null,
					},
					[12484] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12485, },
					},
					[12485] = new Feature
					{
						_0 = new int[] { 12484, 12441 },
						_1 = null,
						_2 = null,
					},
					[12486] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12487, },
					},
					[12487] = new Feature
					{
						_0 = new int[] { 12486, 12441 },
						_1 = null,
						_2 = null,
					},
					[12488] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12489, },
					},
					[12489] = new Feature
					{
						_0 = new int[] { 12488, 12441 },
						_1 = null,
						_2 = null,
					},
					[12495] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12496, [12442] = 12497, },
					},
					[12496] = new Feature
					{
						_0 = new int[] { 12495, 12441 },
						_1 = null,
						_2 = null,
					},
					[12497] = new Feature
					{
						_0 = new int[] { 12495, 12442 },
						_1 = null,
						_2 = null,
					},
					[12498] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12499, [12442] = 12500, },
					},
					[12499] = new Feature
					{
						_0 = new int[] { 12498, 12441 },
						_1 = null,
						_2 = null,
					},
					[12500] = new Feature
					{
						_0 = new int[] { 12498, 12442 },
						_1 = null,
						_2 = null,
					},
					[12501] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12502, [12442] = 12503, },
					},
					[12502] = new Feature
					{
						_0 = new int[] { 12501, 12441 },
						_1 = null,
						_2 = null,
					},
					[12503] = new Feature
					{
						_0 = new int[] { 12501, 12442 },
						_1 = null,
						_2 = null,
					},
					[12504] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12505, [12442] = 12506, },
					},
					[12505] = new Feature
					{
						_0 = new int[] { 12504, 12441 },
						_1 = null,
						_2 = null,
					},
					[12506] = new Feature
					{
						_0 = new int[] { 12504, 12442 },
						_1 = null,
						_2 = null,
					},
					[12507] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12508, [12442] = 12509, },
					},
					[12508] = new Feature
					{
						_0 = new int[] { 12507, 12441 },
						_1 = null,
						_2 = null,
					},
					[12509] = new Feature
					{
						_0 = new int[] { 12507, 12442 },
						_1 = null,
						_2 = null,
					},
					[12527] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12535, },
					},
					[12528] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12536, },
					},
					[12529] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12537, },
					},
					[12530] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12538, },
					},
					[12532] = new Feature
					{
						_0 = new int[] { 12454, 12441 },
						_1 = null,
						_2 = null,
					},
					[12535] = new Feature
					{
						_0 = new int[] { 12527, 12441 },
						_1 = null,
						_2 = null,
					},
					[12536] = new Feature
					{
						_0 = new int[] { 12528, 12441 },
						_1 = null,
						_2 = null,
					},
					[12537] = new Feature
					{
						_0 = new int[] { 12529, 12441 },
						_1 = null,
						_2 = null,
					},
					[12538] = new Feature
					{
						_0 = new int[] { 12530, 12441 },
						_1 = null,
						_2 = null,
					},
					[12541] = new Feature
					{
						_0 = null,
						_1 = null,
						_2 = new Dictionary<int, int> { [12441] = 12542, },
					},
					[12542] = new Feature
					{
						_0 = new int[] { 12541, 12441 },
						_1 = null,
						_2 = null,
					},
					[12543] = new Feature
					{
						_0 = new int[] { 12467, 12488 },
						_1 = 256,
						_2 = null,
					},
				},
				[12544] = new Dictionary<int, Feature>
				{
					[12593] = new Feature
					{
						_0 = new int[] { 4352 },
						_1 = 256,
						_2 = null,
					},
					[12594] = new Feature
					{
						_0 = new int[] { 4353 },
						_1 = 256,
						_2 = null,
					},
					[12595] = new Feature
					{
						_0 = new int[] { 4522 },
						_1 = 256,
						_2 = null,
					},
					[12596] = new Feature
					{
						_0 = new int[] { 4354 },
						_1 = 256,
						_2 = null,
					},
					[12597] = new Feature
					{
						_0 = new int[] { 4524 },
						_1 = 256,
						_2 = null,
					},
					[12598] = new Feature
					{
						_0 = new int[] { 4525 },
						_1 = 256,
						_2 = null,
					},
					[12599] = new Feature
					{
						_0 = new int[] { 4355 },
						_1 = 256,
						_2 = null,
					},
					[12600] = new Feature
					{
						_0 = new int[] { 4356 },
						_1 = 256,
						_2 = null,
					},
					[12601] = new Feature
					{
						_0 = new int[] { 4357 },
						_1 = 256,
						_2 = null,
					},
					[12602] = new Feature
					{
						_0 = new int[] { 4528 },
						_1 = 256,
						_2 = null,
					},
					[12603] = new Feature
					{
						_0 = new int[] { 4529 },
						_1 = 256,
						_2 = null,
					},
					[12604] = new Feature
					{
						_0 = new int[] { 4530 },
						_1 = 256,
						_2 = null,
					},
					[12605] = new Feature
					{
						_0 = new int[] { 4531 },
						_1 = 256,
						_2 = null,
					},
					[12606] = new Feature
					{
						_0 = new int[] { 4532 },
						_1 = 256,
						_2 = null,
					},
					[12607] = new Feature
					{
						_0 = new int[] { 4533 },
						_1 = 256,
						_2 = null,
					},
					[12608] = new Feature
					{
						_0 = new int[] { 4378 },
						_1 = 256,
						_2 = null,
					},
					[12609] = new Feature
					{
						_0 = new int[] { 4358 },
						_1 = 256,
						_2 = null,
					},
					[12610] = new Feature
					{
						_0 = new int[] { 4359 },
						_1 = 256,
						_2 = null,
					},
					[12611] = new Feature
					{
						_0 = new int[] { 4360 },
						_1 = 256,
						_2 = null,
					},
					[12612] = new Feature
					{
						_0 = new int[] { 4385 },
						_1 = 256,
						_2 = null,
					},
					[12613] = new Feature
					{
						_0 = new int[] { 4361 },
						_1 = 256,
						_2 = null,
					},
					[12614] = new Feature
					{
						_0 = new int[] { 4362 },
						_1 = 256,
						_2 = null,
					},
					[12615] = new Feature
					{
						_0 = new int[] { 4363 },
						_1 = 256,
						_2 = null,
					},
					[12616] = new Feature
					{
						_0 = new int[] { 4364 },
						_1 = 256,
						_2 = null,
					},
					[12617] = new Feature
					{
						_0 = new int[] { 4365 },
						_1 = 256,
						_2 = null,
					},
					[12618] = new Feature
					{
						_0 = new int[] { 4366 },
						_1 = 256,
						_2 = null,
					},
					[12619] = new Feature
					{
						_0 = new int[] { 4367 },
						_1 = 256,
						_2 = null,
					},
					[12620] = new Feature
					{
						_0 = new int[] { 4368 },
						_1 = 256,
						_2 = null,
					},
					[12621] = new Feature
					{
						_0 = new int[] { 4369 },
						_1 = 256,
						_2 = null,
					},
					[12622] = new Feature
					{
						_0 = new int[] { 4370 },
						_1 = 256,
						_2 = null,
					},
					[12623] = new Feature
					{
						_0 = new int[] { 4449 },
						_1 = 256,
						_2 = null,
					},
					[12624] = new Feature
					{
						_0 = new int[] { 4450 },
						_1 = 256,
						_2 = null,
					},
					[12625] = new Feature
					{
						_0 = new int[] { 4451 },
						_1 = 256,
						_2 = null,
					},
					[12626] = new Feature
					{
						_0 = new int[] { 4452 },
						_1 = 256,
						_2 = null,
					},
					[12627] = new Feature
					{
						_0 = new int[] { 4453 },
						_1 = 256,
						_2 = null,
					},
					[12628] = new Feature
					{
						_0 = new int[] { 4454 },
						_1 = 256,
						_2 = null,
					},
					[12629] = new Feature
					{
						_0 = new int[] { 4455 },
						_1 = 256,
						_2 = null,
					},
					[12630] = new Feature
					{
						_0 = new int[] { 4456 },
						_1 = 256,
						_2 = null,
					},
					[12631] = new Feature
					{
						_0 = new int[] { 4457 },
						_1 = 256,
						_2 = null,
					},
					[12632] = new Feature
					{
						_0 = new int[] { 4458 },
						_1 = 256,
						_2 = null,
					},
					[12633] = new Feature
					{
						_0 = new int[] { 4459 },
						_1 = 256,
						_2 = null,
					},
					[12634] = new Feature
					{
						_0 = new int[] { 4460 },
						_1 = 256,
						_2 = null,
					},
					[12635] = new Feature
					{
						_0 = new int[] { 4461 },
						_1 = 256,
						_2 = null,
					},
					[12636] = new Feature
					{
						_0 = new int[] { 4462 },
						_1 = 256,
						_2 = null,
					},
					[12637] = new Feature
					{
						_0 = new int[] { 4463 },
						_1 = 256,
						_2 = null,
					},
					[12638] = new Feature
					{
						_0 = new int[] { 4464 },
						_1 = 256,
						_2 = null,
					},
					[12639] = new Feature
					{
						_0 = new int[] { 4465 },
						_1 = 256,
						_2 = null,
					},
					[12640] = new Feature
					{
						_0 = new int[] { 4466 },
						_1 = 256,
						_2 = null,
					},
					[12641] = new Feature
					{
						_0 = new int[] { 4467 },
						_1 = 256,
						_2 = null,
					},
					[12642] = new Feature
					{
						_0 = new int[] { 4468 },
						_1 = 256,
						_2 = null,
					},
					[12643] = new Feature
					{
						_0 = new int[] { 4469 },
						_1 = 256,
						_2 = null,
					},
					[12644] = new Feature
					{
						_0 = new int[] { 4448 },
						_1 = 256,
						_2 = null,
					},
					[12645] = new Feature
					{
						_0 = new int[] { 4372 },
						_1 = 256,
						_2 = null,
					},
					[12646] = new Feature
					{
						_0 = new int[] { 4373 },
						_1 = 256,
						_2 = null,
					},
					[12647] = new Feature
					{
						_0 = new int[] { 4551 },
						_1 = 256,
						_2 = null,
					},
					[12648] = new Feature
					{
						_0 = new int[] { 4552 },
						_1 = 256,
						_2 = null,
					},
					[12649] = new Feature
					{
						_0 = new int[] { 4556 },
						_1 = 256,
						_2 = null,
					},
					[12650] = new Feature
					{
						_0 = new int[] { 4558 },
						_1 = 256,
						_2 = null,
					},
					[12651] = new Feature
					{
						_0 = new int[] { 4563 },
						_1 = 256,
						_2 = null,
					},
					[12652] = new Feature
					{
						_0 = new int[] { 4567 },
						_1 = 256,
						_2 = null,
					},
					[12653] = new Feature
					{
						_0 = new int[] { 4569 },
						_1 = 256,
						_2 = null,
					},
					[12654] = new Feature
					{
						_0 = new int[] { 4380 },
						_1 = 256,
						_2 = null,
					},
					[12655] = new Feature
					{
						_0 = new int[] { 4573 },
						_1 = 256,
						_2 = null,
					},
					[12656] = new Feature
					{
						_0 = new int[] { 4575 },
						_1 = 256,
						_2 = null,
					},
					[12657] = new Feature
					{
						_0 = new int[] { 4381 },
						_1 = 256,
						_2 = null,
					},
					[12658] = new Feature
					{
						_0 = new int[] { 4382 },
						_1 = 256,
						_2 = null,
					},
					[12659] = new Feature
					{
						_0 = new int[] { 4384 },
						_1 = 256,
						_2 = null,
					},
					[12660] = new Feature
					{
						_0 = new int[] { 4386 },
						_1 = 256,
						_2 = null,
					},
					[12661] = new Feature
					{
						_0 = new int[] { 4387 },
						_1 = 256,
						_2 = null,
					},
					[12662] = new Feature
					{
						_0 = new int[] { 4391 },
						_1 = 256,
						_2 = null,
					},
					[12663] = new Feature
					{
						_0 = new int[] { 4393 },
						_1 = 256,
						_2 = null,
					},
					[12664] = new Feature
					{
						_0 = new int[] { 4395 },
						_1 = 256,
						_2 = null,
					},
					[12665] = new Feature
					{
						_0 = new int[] { 4396 },
						_1 = 256,
						_2 = null,
					},
					[12666] = new Feature
					{
						_0 = new int[] { 4397 },
						_1 = 256,
						_2 = null,
					},
					[12667] = new Feature
					{
						_0 = new int[] { 4398 },
						_1 = 256,
						_2 = null,
					},
					[12668] = new Feature
					{
						_0 = new int[] { 4399 },
						_1 = 256,
						_2 = null,
					},
					[12669] = new Feature
					{
						_0 = new int[] { 4402 },
						_1 = 256,
						_2 = null,
					},
					[12670] = new Feature
					{
						_0 = new int[] { 4406 },
						_1 = 256,
						_2 = null,
					},
					[12671] = new Feature
					{
						_0 = new int[] { 4416 },
						_1 = 256,
						_2 = null,
					},
					[12672] = new Feature
					{
						_0 = new int[] { 4423 },
						_1 = 256,
						_2 = null,
					},
					[12673] = new Feature
					{
						_0 = new int[] { 4428 },
						_1 = 256,
						_2 = null,
					},
					[12674] = new Feature
					{
						_0 = new int[] { 4593 },
						_1 = 256,
						_2 = null,
					},
					[12675] = new Feature
					{
						_0 = new int[] { 4594 },
						_1 = 256,
						_2 = null,
					},
					[12676] = new Feature
					{
						_0 = new int[] { 4439 },
						_1 = 256,
						_2 = null,
					},
					[12677] = new Feature
					{
						_0 = new int[] { 4440 },
						_1 = 256,
						_2 = null,
					},
					[12678] = new Feature
					{
						_0 = new int[] { 4441 },
						_1 = 256,
						_2 = null,
					},
					[12679] = new Feature
					{
						_0 = new int[] { 4484 },
						_1 = 256,
						_2 = null,
					},
					[12680] = new Feature
					{
						_0 = new int[] { 4485 },
						_1 = 256,
						_2 = null,
					},
					[12681] = new Feature
					{
						_0 = new int[] { 4488 },
						_1 = 256,
						_2 = null,
					},
					[12682] = new Feature
					{
						_0 = new int[] { 4497 },
						_1 = 256,
						_2 = null,
					},
					[12683] = new Feature
					{
						_0 = new int[] { 4498 },
						_1 = 256,
						_2 = null,
					},
					[12684] = new Feature
					{
						_0 = new int[] { 4500 },
						_1 = 256,
						_2 = null,
					},
					[12685] = new Feature
					{
						_0 = new int[] { 4510 },
						_1 = 256,
						_2 = null,
					},
					[12686] = new Feature
					{
						_0 = new int[] { 4513 },
						_1 = 256,
						_2 = null,
					},
					[12690] = new Feature
					{
						_0 = new int[] { 19968 },
						_1 = 256,
						_2 = null,
					},
					[12691] = new Feature
					{
						_0 = new int[] { 20108 },
						_1 = 256,
						_2 = null,
					},
					[12692] = new Feature
					{
						_0 = new int[] { 19977 },
						_1 = 256,
						_2 = null,
					},
					[12693] = new Feature
					{
						_0 = new int[] { 22235 },
						_1 = 256,
						_2 = null,
					},
					[12694] = new Feature
					{
						_0 = new int[] { 19978 },
						_1 = 256,
						_2 = null,
					},
					[12695] = new Feature
					{
						_0 = new int[] { 20013 },
						_1 = 256,
						_2 = null,
					},
					[12696] = new Feature
					{
						_0 = new int[] { 19979 },
						_1 = 256,
						_2 = null,
					},
					[12697] = new Feature
					{
						_0 = new int[] { 30002 },
						_1 = 256,
						_2 = null,
					},
					[12698] = new Feature
					{
						_0 = new int[] { 20057 },
						_1 = 256,
						_2 = null,
					},
					[12699] = new Feature
					{
						_0 = new int[] { 19993 },
						_1 = 256,
						_2 = null,
					},
					[12700] = new Feature
					{
						_0 = new int[] { 19969 },
						_1 = 256,
						_2 = null,
					},
					[12701] = new Feature
					{
						_0 = new int[] { 22825 },
						_1 = 256,
						_2 = null,
					},
					[12702] = new Feature
					{
						_0 = new int[] { 22320 },
						_1 = 256,
						_2 = null,
					},
					[12703] = new Feature
					{
						_0 = new int[] { 20154 },
						_1 = 256,
						_2 = null,
					},
				},
				[12800] = new Dictionary<int, Feature>
				{
					[12800] = new Feature
					{
						_0 = new int[] { 40, 4352, 41 },
						_1 = 256,
						_2 = null,
					},
					[12801] = new Feature
					{
						_0 = new int[] { 40, 4354, 41 },
						_1 = 256,
						_2 = null,
					},
					[12802] = new Feature
					{
						_0 = new int[] { 40, 4355, 41 },
						_1 = 256,
						_2 = null,
					},
					[12803] = new Feature
					{
						_0 = new int[] { 40, 4357, 41 },
						_1 = 256,
						_2 = null,
					},
					[12804] = new Feature
					{
						_0 = new int[] { 40, 4358, 41 },
						_1 = 256,
						_2 = null,
					},
					[12805] = new Feature
					{
						_0 = new int[] { 40, 4359, 41 },
						_1 = 256,
						_2 = null,
					},
					[12806] = new Feature
					{
						_0 = new int[] { 40, 4361, 41 },
						_1 = 256,
						_2 = null,
					},
					[12807] = new Feature
					{
						_0 = new int[] { 40, 4363, 41 },
						_1 = 256,
						_2 = null,
					},
					[12808] = new Feature
					{
						_0 = new int[] { 40, 4364, 41 },
						_1 = 256,
						_2 = null,
					},
					[12809] = new Feature
					{
						_0 = new int[] { 40, 4366, 41 },
						_1 = 256,
						_2 = null,
					},
					[12810] = new Feature
					{
						_0 = new int[] { 40, 4367, 41 },
						_1 = 256,
						_2 = null,
					},
					[12811] = new Feature
					{
						_0 = new int[] { 40, 4368, 41 },
						_1 = 256,
						_2 = null,
					},
					[12812] = new Feature
					{
						_0 = new int[] { 40, 4369, 41 },
						_1 = 256,
						_2 = null,
					},
					[12813] = new Feature
					{
						_0 = new int[] { 40, 4370, 41 },
						_1 = 256,
						_2 = null,
					},
					[12814] = new Feature
					{
						_0 = new int[] { 40, 4352, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12815] = new Feature
					{
						_0 = new int[] { 40, 4354, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12816] = new Feature
					{
						_0 = new int[] { 40, 4355, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12817] = new Feature
					{
						_0 = new int[] { 40, 4357, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12818] = new Feature
					{
						_0 = new int[] { 40, 4358, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12819] = new Feature
					{
						_0 = new int[] { 40, 4359, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12820] = new Feature
					{
						_0 = new int[] { 40, 4361, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12821] = new Feature
					{
						_0 = new int[] { 40, 4363, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12822] = new Feature
					{
						_0 = new int[] { 40, 4364, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12823] = new Feature
					{
						_0 = new int[] { 40, 4366, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12824] = new Feature
					{
						_0 = new int[] { 40, 4367, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12825] = new Feature
					{
						_0 = new int[] { 40, 4368, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12826] = new Feature
					{
						_0 = new int[] { 40, 4369, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12827] = new Feature
					{
						_0 = new int[] { 40, 4370, 4449, 41 },
						_1 = 256,
						_2 = null,
					},
					[12828] = new Feature
					{
						_0 = new int[] { 40, 4364, 4462, 41 },
						_1 = 256,
						_2 = null,
					},
					[12829] = new Feature
					{
						_0 = new int[] { 40, 4363, 4457, 4364, 4453, 4523, 41 },
						_1 = 256,
						_2 = null,
					},
					[12830] = new Feature
					{
						_0 = new int[] { 40, 4363, 4457, 4370, 4462, 41 },
						_1 = 256,
						_2 = null,
					},
					[12832] = new Feature
					{
						_0 = new int[] { 40, 19968, 41 },
						_1 = 256,
						_2 = null,
					},
					[12833] = new Feature
					{
						_0 = new int[] { 40, 20108, 41 },
						_1 = 256,
						_2 = null,
					},
					[12834] = new Feature
					{
						_0 = new int[] { 40, 19977, 41 },
						_1 = 256,
						_2 = null,
					},
					[12835] = new Feature
					{
						_0 = new int[] { 40, 22235, 41 },
						_1 = 256,
						_2 = null,
					},
					[12836] = new Feature
					{
						_0 = new int[] { 40, 20116, 41 },
						_1 = 256,
						_2 = null,
					},
					[12837] = new Feature
					{
						_0 = new int[] { 40, 20845, 41 },
						_1 = 256,
						_2 = null,
					},
					[12838] = new Feature
					{
						_0 = new int[] { 40, 19971, 41 },
						_1 = 256,
						_2 = null,
					},
					[12839] = new Feature
					{
						_0 = new int[] { 40, 20843, 41 },
						_1 = 256,
						_2 = null,
					},
					[12840] = new Feature
					{
						_0 = new int[] { 40, 20061, 41 },
						_1 = 256,
						_2 = null,
					},
					[12841] = new Feature
					{
						_0 = new int[] { 40, 21313, 41 },
						_1 = 256,
						_2 = null,
					},
					[12842] = new Feature
					{
						_0 = new int[] { 40, 26376, 41 },
						_1 = 256,
						_2 = null,
					},
					[12843] = new Feature
					{
						_0 = new int[] { 40, 28779, 41 },
						_1 = 256,
						_2 = null,
					},
					[12844] = new Feature
					{
						_0 = new int[] { 40, 27700, 41 },
						_1 = 256,
						_2 = null,
					},
					[12845] = new Feature
					{
						_0 = new int[] { 40, 26408, 41 },
						_1 = 256,
						_2 = null,
					},
					[12846] = new Feature
					{
						_0 = new int[] { 40, 37329, 41 },
						_1 = 256,
						_2 = null,
					},
					[12847] = new Feature
					{
						_0 = new int[] { 40, 22303, 41 },
						_1 = 256,
						_2 = null,
					},
					[12848] = new Feature
					{
						_0 = new int[] { 40, 26085, 41 },
						_1 = 256,
						_2 = null,
					},
					[12849] = new Feature
					{
						_0 = new int[] { 40, 26666, 41 },
						_1 = 256,
						_2 = null,
					},
					[12850] = new Feature
					{
						_0 = new int[] { 40, 26377, 41 },
						_1 = 256,
						_2 = null,
					},
					[12851] = new Feature
					{
						_0 = new int[] { 40, 31038, 41 },
						_1 = 256,
						_2 = null,
					},
					[12852] = new Feature
					{
						_0 = new int[] { 40, 21517, 41 },
						_1 = 256,
						_2 = null,
					},
					[12853] = new Feature
					{
						_0 = new int[] { 40, 29305, 41 },
						_1 = 256,
						_2 = null,
					},
					[12854] = new Feature
					{
						_0 = new int[] { 40, 36001, 41 },
						_1 = 256,
						_2 = null,
					},
					[12855] = new Feature
					{
						_0 = new int[] { 40, 31069, 41 },
						_1 = 256,
						_2 = null,
					},
					[12856] = new Feature
					{
						_0 = new int[] { 40, 21172, 41 },
						_1 = 256,
						_2 = null,
					},
					[12857] = new Feature
					{
						_0 = new int[] { 40, 20195, 41 },
						_1 = 256,
						_2 = null,
					},
					[12858] = new Feature
					{
						_0 = new int[] { 40, 21628, 41 },
						_1 = 256,
						_2 = null,
					},
					[12859] = new Feature
					{
						_0 = new int[] { 40, 23398, 41 },
						_1 = 256,
						_2 = null,
					},
					[12860] = new Feature
					{
						_0 = new int[] { 40, 30435, 41 },
						_1 = 256,
						_2 = null,
					},
					[12861] = new Feature
					{
						_0 = new int[] { 40, 20225, 41 },
						_1 = 256,
						_2 = null,
					},
					[12862] = new Feature
					{
						_0 = new int[] { 40, 36039, 41 },
						_1 = 256,
						_2 = null,
					},
					[12863] = new Feature
					{
						_0 = new int[] { 40, 21332, 41 },
						_1 = 256,
						_2 = null,
					},
					[12864] = new Feature
					{
						_0 = new int[] { 40, 31085, 41 },
						_1 = 256,
						_2 = null,
					},
					[12865] = new Feature
					{
						_0 = new int[] { 40, 20241, 41 },
						_1 = 256,
						_2 = null,
					},
					[12866] = new Feature
					{
						_0 = new int[] { 40, 33258, 41 },
						_1 = 256,
						_2 = null,
					},
					[12867] = new Feature
					{
						_0 = new int[] { 40, 33267, 41 },
						_1 = 256,
						_2 = null,
					},
					[12868] = new Feature
					{
						_0 = new int[] { 21839 },
						_1 = 256,
						_2 = null,
					},
					[12869] = new Feature
					{
						_0 = new int[] { 24188 },
						_1 = 256,
						_2 = null,
					},
					[12870] = new Feature
					{
						_0 = new int[] { 25991 },
						_1 = 256,
						_2 = null,
					},
					[12871] = new Feature
					{
						_0 = new int[] { 31631 },
						_1 = 256,
						_2 = null,
					},
					[12880] = new Feature
					{
						_0 = new int[] { 80, 84, 69 },
						_1 = 256,
						_2 = null,
					},
					[12881] = new Feature
					{
						_0 = new int[] { 50, 49 },
						_1 = 256,
						_2 = null,
					},
					[12882] = new Feature
					{
						_0 = new int[] { 50, 50 },
						_1 = 256,
						_2 = null,
					},
					[12883] = new Feature
					{
						_0 = new int[] { 50, 51 },
						_1 = 256,
						_2 = null,
					},
					[12884] = new Feature
					{
						_0 = new int[] { 50, 52 },
						_1 = 256,
						_2 = null,
					},
					[12885] = new Feature
					{
						_0 = new int[] { 50, 53 },
						_1 = 256,
						_2 = null,
					},
					[12886] = new Feature
					{
						_0 = new int[] { 50, 54 },
						_1 = 256,
						_2 = null,
					},
					[12887] = new Feature
					{
						_0 = new int[] { 50, 55 },
						_1 = 256,
						_2 = null,
					},
					[12888] = new Feature
					{
						_0 = new int[] { 50, 56 },


						_1 = 256,
						_2 = null,
					},
					[12889] = new Feature
					{
						_0 = new int[] { 50, 57 },
						_1 = 256,
						_2 = null,
					},
					[12890] = new Feature
					{
						_0 = new int[] { 51, 48 },
						_1 = 256,
						_2 = null,
					},
					[12891] = new Feature
					{
						_0 = new int[] { 51, 49 },
						_1 = 256,
						_2 = null,
					},
					[12892] = new Feature
					{
						_0 = new int[] { 51, 50 },
						_1 = 256,
						_2 = null,
					},
					[12893] = new Feature
					{
						_0 = new int[] { 51, 51 },
						_1 = 256,
						_2 = null,
					},
					[12894] = new Feature
					{
						_0 = new int[] { 51, 52 },
						_1 = 256,
						_2 = null,
					},
					[12895] = new Feature
					{
						_0 = new int[] { 51, 53 },
						_1 = 256,
						_2 = null,
					},
					[12896] = new Feature
					{
						_0 = new int[] { 4352 },
						_1 = 256,
						_2 = null,
					},
					[12897] = new Feature
					{
						_0 = new int[] { 4354 },
						_1 = 256,
						_2 = null,
					},
					[12898] = new Feature
					{
						_0 = new int[] { 4355 },
						_1 = 256,
						_2 = null,
					},
					[12899] = new Feature
					{
						_0 = new int[] { 4357 },
						_1 = 256,
						_2 = null,
					},
					[12900] = new Feature
					{
						_0 = new int[] { 4358 },
						_1 = 256,
						_2 = null,
					},
					[12901] = new Feature
					{
						_0 = new int[] { 4359 },
						_1 = 256,
						_2 = null,
					},
					[12902] = new Feature
					{
						_0 = new int[] { 4361 },
						_1 = 256,
						_2 = null,
					},
					[12903] = new Feature
					{
						_0 = new int[] { 4363 },
						_1 = 256,
						_2 = null,
					},
					[12904] = new Feature
					{
						_0 = new int[] { 4364 },
						_1 = 256,
						_2 = null,
					},
					[12905] = new Feature
					{
						_0 = new int[] { 4366 },
						_1 = 256,
						_2 = null,
					},
					[12906] = new Feature
					{
						_0 = new int[] { 4367 },
						_1 = 256,
						_2 = null,
					},
					[12907] = new Feature
					{
						_0 = new int[] { 4368 },
						_1 = 256,
						_2 = null,
					},
					[12908] = new Feature
					{
						_0 = new int[] { 4369 },
						_1 = 256,
						_2 = null,
					},
					[12909] = new Feature
					{
						_0 = new int[] { 4370 },
						_1 = 256,
						_2 = null,
					},
					[12910] = new Feature
					{
						_0 = new int[] { 4352, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12911] = new Feature
					{
						_0 = new int[] { 4354, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12912] = new Feature
					{
						_0 = new int[] { 4355, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12913] = new Feature
					{
						_0 = new int[] { 4357, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12914] = new Feature
					{
						_0 = new int[] { 4358, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12915] = new Feature
					{
						_0 = new int[] { 4359, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12916] = new Feature
					{
						_0 = new int[] { 4361, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12917] = new Feature
					{
						_0 = new int[] { 4363, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12918] = new Feature
					{
						_0 = new int[] { 4364, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12919] = new Feature
					{
						_0 = new int[] { 4366, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12920] = new Feature
					{
						_0 = new int[] { 4367, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12921] = new Feature
					{
						_0 = new int[] { 4368, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12922] = new Feature
					{
						_0 = new int[] { 4369, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12923] = new Feature
					{
						_0 = new int[] { 4370, 4449 },
						_1 = 256,
						_2 = null,
					},
					[12924] = new Feature
					{
						_0 = new int[] { 4366, 4449, 4535, 4352, 4457 },
						_1 = 256,
						_2 = null,
					},
					[12925] = new Feature
					{
						_0 = new int[] { 4364, 4462, 4363, 4468 },
						_1 = 256,
						_2 = null,
					},
					[12926] = new Feature
					{
						_0 = new int[] { 4363, 4462 },
						_1 = 256,
						_2 = null,
					},
					[12928] = new Feature
					{
						_0 = new int[] { 19968 },
						_1 = 256,
						_2 = null,
					},
					[12929] = new Feature
					{
						_0 = new int[] { 20108 },
						_1 = 256,
						_2 = null,
					},
					[12930] = new Feature
					{
						_0 = new int[] { 19977 },
						_1 = 256,
						_2 = null,
					},
					[12931] = new Feature
					{
						_0 = new int[] { 22235 },
						_1 = 256,
						_2 = null,
					},
					[12932] = new Feature
					{
						_0 = new int[] { 20116 },
						_1 = 256,
						_2 = null,
					},
					[12933] = new Feature
					{
						_0 = new int[] { 20845 },
						_1 = 256,
						_2 = null,
					},
					[12934] = new Feature
					{
						_0 = new int[] { 19971 },
						_1 = 256,
						_2 = null,
					},
					[12935] = new Feature
					{
						_0 = new int[] { 20843 },
						_1 = 256,
						_2 = null,
					},
					[12936] = new Feature
					{
						_0 = new int[] { 20061 },
						_1 = 256,
						_2 = null,
					},
					[12937] = new Feature
					{
						_0 = new int[] { 21313 },
						_1 = 256,
						_2 = null,
					},
					[12938] = new Feature
					{
						_0 = new int[] { 26376 },
						_1 = 256,
						_2 = null,
					},
					[12939] = new Feature
					{
						_0 = new int[] { 28779 },
						_1 = 256,
						_2 = null,
					},
					[12940] = new Feature
					{
						_0 = new int[] { 27700 },
						_1 = 256,
						_2 = null,
					},
					[12941] = new Feature
					{
						_0 = new int[] { 26408 },
						_1 = 256,
						_2 = null,
					},
					[12942] = new Feature
					{
						_0 = new int[] { 37329 },
						_1 = 256,
						_2 = null,
					},
					[12943] = new Feature
					{
						_0 = new int[] { 22303 },
						_1 = 256,
						_2 = null,
					},
					[12944] = new Feature
					{
						_0 = new int[] { 26085 },
						_1 = 256,
						_2 = null,
					},
					[12945] = new Feature
					{
						_0 = new int[] { 26666 },
						_1 = 256,
						_2 = null,
					},
					[12946] = new Feature
					{
						_0 = new int[] { 26377 },
						_1 = 256,
						_2 = null,
					},
					[12947] = new Feature
					{
						_0 = new int[] { 31038 },
						_1 = 256,
						_2 = null,
					},
					[12948] = new Feature
					{
						_0 = new int[] { 21517 },
						_1 = 256,
						_2 = null,
					},
					[12949] = new Feature
					{
						_0 = new int[] { 29305 },
						_1 = 256,
						_2 = null,
					},
					[12950] = new Feature
					{
						_0 = new int[] { 36001 },
						_1 = 256,
						_2 = null,
					},
					[12951] = new Feature
					{
						_0 = new int[] { 31069 },
						_1 = 256,
						_2 = null,
					},
					[12952] = new Feature
					{
						_0 = new int[] { 21172 },
						_1 = 256,
						_2 = null,
					},
					[12953] = new Feature
					{
						_0 = new int[] { 31192 },
						_1 = 256,
						_2 = null,
					},
					[12954] = new Feature
					{
						_0 = new int[] { 30007 },
						_1 = 256,
						_2 = null,
					},
					[12955] = new Feature
					{
						_0 = new int[] { 22899 },
						_1 = 256,
						_2 = null,
					},
					[12956] = new Feature
					{
						_0 = new int[] { 36969 },
						_1 = 256,
						_2 = null,
					},
					[12957] = new Feature
					{
						_0 = new int[] { 20778 },
						_1 = 256,
						_2 = null,
					},
					[12958] = new Feature
					{
						_0 = new int[] { 21360 },
						_1 = 256,
						_2 = null,
					},
					[12959] = new Feature
					{
						_0 = new int[] { 27880 },
						_1 = 256,
						_2 = null,
					},
					[12960] = new Feature
					{
						_0 = new int[] { 38917 },
						_1 = 256,
						_2 = null,
					},
					[12961] = new Feature
					{
						_0 = new int[] { 20241 },
						_1 = 256,
						_2 = null,
					},
					[12962] = new Feature
					{
						_0 = new int[] { 20889 },
						_1 = 256,
						_2 = null,
					},
					[12963] = new Feature
					{
						_0 = new int[] { 27491 },
						_1 = 256,
						_2 = null,
					},
					[12964] = new Feature
					{
						_0 = new int[] { 19978 },
						_1 = 256,
						_2 = null,
					},
					[12965] = new Feature
					{
						_0 = new int[] { 20013 },
						_1 = 256,
						_2 = null,
					},
					[12966] = new Feature
					{
						_0 = new int[] { 19979 },
						_1 = 256,
						_2 = null,
					},
					[12967] = new Feature
					{
						_0 = new int[] { 24038 },
						_1 = 256,
						_2 = null,
					},
					[12968] = new Feature
					{
						_0 = new int[] { 21491 },
						_1 = 256,
						_2 = null,
					},
					[12969] = new Feature
					{
						_0 = new int[] { 21307 },
						_1 = 256,
						_2 = null,
					},
					[12970] = new Feature
					{
						_0 = new int[] { 23447 },
						_1 = 256,
						_2 = null,
					},
					[12971] = new Feature
					{
						_0 = new int[] { 23398 },
						_1 = 256,
						_2 = null,
					},
					[12972] = new Feature
					{
						_0 = new int[] { 30435 },
						_1 = 256,
						_2 = null,
					},
					[12973] = new Feature
					{
						_0 = new int[] { 20225 },
						_1 = 256,
						_2 = null,
					},
					[12974] = new Feature
					{
						_0 = new int[] { 36039 },
						_1 = 256,
						_2 = null,
					},
					[12975] = new Feature
					{
						_0 = new int[] { 21332 },
						_1 = 256,
						_2 = null,
					},
					[12976] = new Feature
					{
						_0 = new int[] { 22812 },
						_1 = 256,
						_2 = null,
					},
					[12977] = new Feature
					{
						_0 = new int[] { 51, 54 },
						_1 = 256,
						_2 = null,
					},
					[12978] = new Feature
					{
						_0 = new int[] { 51, 55 },
						_1 = 256,
						_2 = null,
					},
					[12979] = new Feature
					{
						_0 = new int[] { 51, 56 },
						_1 = 256,
						_2 = null,
					},
					[12980] = new Feature
					{
						_0 = new int[] { 51, 57 },
						_1 = 256,
						_2 = null,
					},
					[12981] = new Feature
					{
						_0 = new int[] { 52, 48 },
						_1 = 256,
						_2 = null,
					},
					[12982] = new Feature
					{
						_0 = new int[] { 52, 49 },
						_1 = 256,
						_2 = null,
					},
					[12983] = new Feature
					{
						_0 = new int[] { 52, 50 },
						_1 = 256,
						_2 = null,
					},
					[12984] = new Feature
					{
						_0 = new int[] { 52, 51 },
						_1 = 256,
						_2 = null,
					},
					[12985] = new Feature
					{
						_0 = new int[] { 52, 52 },
						_1 = 256,
						_2 = null,
					},
					[12986] = new Feature
					{
						_0 = new int[] { 52, 53 },
						_1 = 256,
						_2 = null,
					},
					[12987] = new Feature
					{
						_0 = new int[] { 52, 54 },
						_1 = 256,
						_2 = null,
					},
					[12988] = new Feature
					{
						_0 = new int[] { 52, 55 },
						_1 = 256,
						_2 = null,
					},
					[12989] = new Feature
					{
						_0 = new int[] { 52, 56 },
						_1 = 256,
						_2 = null,
					},
					[12990] = new Feature
					{
						_0 = new int[] { 52, 57 },
						_1 = 256,
						_2 = null,
					},
					[12991] = new Feature
					{
						_0 = new int[] { 53, 48 },
						_1 = 256,
						_2 = null,
					},
					[12992] = new Feature
					{
						_0 = new int[] { 49, 26376 },
						_1 = 256,
						_2 = null,
					},
					[12993] = new Feature
					{
						_0 = new int[] { 50, 26376 },
						_1 = 256,
						_2 = null,
					},
					[12994] = new Feature
					{
						_0 = new int[] { 51, 26376 },
						_1 = 256,
						_2 = null,
					},
					[12995] = new Feature
					{
						_0 = new int[] { 52, 26376 },
						_1 = 256,
						_2 = null,
					},
					[12996] = new Feature
					{
						_0 = new int[] { 53, 26376 },
						_1 = 256,
						_2 = null,
					},
					[12997] = new Feature
					{
						_0 = new int[] { 54, 26376 },
						_1 = 256,
						_2 = null,
					},
					[12998] = new Feature
					{
						_0 = new int[] { 55, 26376 },
						_1 = 256,
						_2 = null,
					},
					[12999] = new Feature
					{
						_0 = new int[] { 56, 26376 },
						_1 = 256,
						_2 = null,
					},
					[13000] = new Feature
					{
						_0 = new int[] { 57, 26376 },
						_1 = 256,
						_2 = null,
					},
					[13001] = new Feature
					{
						_0 = new int[] { 49, 48, 26376 },
						_1 = 256,
						_2 = null,
					},
					[13002] = new Feature
					{
						_0 = new int[] { 49, 49, 26376 },
						_1 = 256,
						_2 = null,
					},
					[13003] = new Feature
					{
						_0 = new int[] { 49, 50, 26376 },
						_1 = 256,
						_2 = null,
					},
					[13004] = new Feature
					{
						_0 = new int[] { 72, 103 },
						_1 = 256,
						_2 = null,
					},
					[13005] = new Feature
					{
						_0 = new int[] { 101, 114, 103 },
						_1 = 256,
						_2 = null,
					},
					[13006] = new Feature
					{
						_0 = new int[] { 101, 86 },
						_1 = 256,
						_2 = null,
					},
					[13007] = new Feature
					{
						_0 = new int[] { 76, 84, 68 },
						_1 = 256,
						_2 = null,
					},
					[13008] = new Feature
					{
						_0 = new int[] { 12450 },
						_1 = 256,
						_2 = null,
					},
					[13009] = new Feature
					{
						_0 = new int[] { 12452 },
						_1 = 256,
						_2 = null,
					},
					[13010] = new Feature
					{
						_0 = new int[] { 12454 },
						_1 = 256,
						_2 = null,
					},
					[13011] = new Feature
					{
						_0 = new int[] { 12456 },
						_1 = 256,
						_2 = null,
					},
					[13012] = new Feature
					{
						_0 = new int[] { 12458 },
						_1 = 256,
						_2 = null,
					},
					[13013] = new Feature
					{
						_0 = new int[] { 12459 },
						_1 = 256,
						_2 = null,
					},
					[13014] = new Feature
					{
						_0 = new int[] { 12461 },
						_1 = 256,
						_2 = null,
					},
					[13015] = new Feature
					{
						_0 = new int[] { 12463 },
						_1 = 256,
						_2 = null,
					},
					[13016] = new Feature
					{
						_0 = new int[] { 12465 },
						_1 = 256,
						_2 = null,
					},
					[13017] = new Feature
					{
						_0 = new int[] { 12467 },
						_1 = 256,
						_2 = null,
					},
					[13018] = new Feature
					{
						_0 = new int[] { 12469 },
						_1 = 256,
						_2 = null,
					},
					[13019] = new Feature
					{
						_0 = new int[] { 12471 },
						_1 = 256,
						_2 = null,
					},
					[13020] = new Feature
					{
						_0 = new int[] { 12473 },
						_1 = 256,
						_2 = null,
					},
					[13021] = new Feature
					{
						_0 = new int[] { 12475 },
						_1 = 256,
						_2 = null,
					},
					[13022] = new Feature
					{
						_0 = new int[] { 12477 },
						_1 = 256,
						_2 = null,
					},
					[13023] = new Feature
					{
						_0 = new int[] { 12479 },
						_1 = 256,
						_2 = null,
					},
					[13024] = new Feature
					{
						_0 = new int[] { 12481 },
						_1 = 256,
						_2 = null,
					},
					[13025] = new Feature
					{
						_0 = new int[] { 12484 },
						_1 = 256,
						_2 = null,
					},
					[13026] = new Feature
					{
						_0 = new int[] { 12486 },
						_1 = 256,
						_2 = null,
					},
					[13027] = new Feature
					{
						_0 = new int[] { 12488 },
						_1 = 256,
						_2 = null,
					},
					[13028] = new Feature
					{
						_0 = new int[] { 12490 },
						_1 = 256,
						_2 = null,
					},
					[13029] = new Feature
					{
						_0 = new int[] { 12491 },
						_1 = 256,
						_2 = null,
					},
					[13030] = new Feature
					{
						_0 = new int[] { 12492 },
						_1 = 256,
						_2 = null,
					},
					[13031] = new Feature
					{
						_0 = new int[] { 12493 },
						_1 = 256,
						_2 = null,
					},
					[13032] = new Feature
					{
						_0 = new int[] { 12494 },
						_1 = 256,
						_2 = null,
					},
					[13033] = new Feature
					{
						_0 = new int[] { 12495 },
						_1 = 256,
						_2 = null,
					},
					[13034] = new Feature
					{
						_0 = new int[] { 12498 },
						_1 = 256,
						_2 = null,
					},
					[13035] = new Feature
					{
						_0 = new int[] { 12501 },
						_1 = 256,
						_2 = null,
					},
					[13036] = new Feature
					{
						_0 = new int[] { 12504 },
						_1 = 256,
						_2 = null,
					},
					[13037] = new Feature
					{
						_0 = new int[] { 12507 },
						_1 = 256,
						_2 = null,
					},
					[13038] = new Feature
					{
						_0 = new int[] { 12510 },
						_1 = 256,
						_2 = null,
					},
					[13039] = new Feature
					{
						_0 = new int[] { 12511 },
						_1 = 256,
						_2 = null,
					},
					[13040] = new Feature
					{
						_0 = new int[] { 12512 },
						_1 = 256,
						_2 = null,
					},
					[13041] = new Feature
					{
						_0 = new int[] { 12513 },
						_1 = 256,
						_2 = null,
					},
					[13042] = new Feature
					{
						_0 = new int[] { 12514 },
						_1 = 256,
						_2 = null,
					},
					[13043] = new Feature
					{
						_0 = new int[] { 12516 },
						_1 = 256,
						_2 = null,
					},
					[13044] = new Feature
					{
						_0 = new int[] { 12518 },
						_1 = 256,
						_2 = null,
					},
					[13045] = new Feature
					{
						_0 = new int[] { 12520 },
						_1 = 256,
						_2 = null,
					},
					[13046] = new Feature
					{
						_0 = new int[] { 12521 },
						_1 = 256,
						_2 = null,
					},
					[13047] = new Feature
					{
						_0 = new int[] { 12522 },
						_1 = 256,
						_2 = null,
					},
					[13048] = new Feature
					{
						_0 = new int[] { 12523 },
						_1 = 256,
						_2 = null,
					},
					[13049] = new Feature
					{
						_0 = new int[] { 12524 },
						_1 = 256,
						_2 = null,
					},
					[13050] = new Feature
					{
						_0 = new int[] { 12525 },
						_1 = 256,
						_2 = null,
					},
					[13051] = new Feature
					{
						_0 = new int[] { 12527 },
						_1 = 256,
						_2 = null,
					},
					[13052] = new Feature
					{
						_0 = new int[] { 12528 },
						_1 = 256,
						_2 = null,
					},
					[13053] = new Feature
					{
						_0 = new int[] { 12529 },
						_1 = 256,
						_2 = null,
					},
					[13054] = new Feature
					{
						_0 = new int[] { 12530 },
						_1 = 256,
						_2 = null,
					},
				},
				[13056] = new Dictionary<int, Feature>
				{
					[13056] = new Feature
					{
						_0 = new int[] { 12450, 12497, 12540, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13057] = new Feature
					{
						_0 = new int[] { 12450, 12523, 12501, 12449 },
						_1 = 256,
						_2 = null,
					},
					[13058] = new Feature
					{
						_0 = new int[] { 12450, 12531, 12506, 12450 },
						_1 = 256,
						_2 = null,
					},
					[13059] = new Feature
					{
						_0 = new int[] { 12450, 12540, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13060] = new Feature
					{
						_0 = new int[] { 12452, 12491, 12531, 12464 },
						_1 = 256,
						_2 = null,
					},
					[13061] = new Feature
					{
						_0 = new int[] { 12452, 12531, 12481 },
						_1 = 256,
						_2 = null,
					},
					[13062] = new Feature
					{
						_0 = new int[] { 12454, 12457, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13063] = new Feature
					{
						_0 = new int[] { 12456, 12473, 12463, 12540, 12489 },
						_1 = 256,
						_2 = null,
					},
					[13064] = new Feature
					{
						_0 = new int[] { 12456, 12540, 12459, 12540 },
						_1 = 256,
						_2 = null,
					},
					[13065] = new Feature
					{
						_0 = new int[] { 12458, 12531, 12473 },
						_1 = 256,
						_2 = null,
					},
					[13066] = new Feature
					{
						_0 = new int[] { 12458, 12540, 12512 },
						_1 = 256,
						_2 = null,
					},
					[13067] = new Feature
					{
						_0 = new int[] { 12459, 12452, 12522 },
						_1 = 256,
						_2 = null,
					},
					[13068] = new Feature
					{
						_0 = new int[] { 12459, 12521, 12483, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13069] = new Feature
					{
						_0 = new int[] { 12459, 12525, 12522, 12540 },
						_1 = 256,
						_2 = null,
					},
					[13070] = new Feature
					{
						_0 = new int[] { 12460, 12525, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13071] = new Feature
					{
						_0 = new int[] { 12460, 12531, 12510 },
						_1 = 256,
						_2 = null,
					},
					[13072] = new Feature
					{
						_0 = new int[] { 12462, 12460 },
						_1 = 256,
						_2 = null,
					},
					[13073] = new Feature
					{
						_0 = new int[] { 12462, 12491, 12540 },
						_1 = 256,
						_2 = null,
					},
					[13074] = new Feature
					{
						_0 = new int[] { 12461, 12517, 12522, 12540 },
						_1 = 256,
						_2 = null,
					},
					[13075] = new Feature
					{
						_0 = new int[] { 12462, 12523, 12480, 12540 },
						_1 = 256,
						_2 = null,
					},
					[13076] = new Feature
					{
						_0 = new int[] { 12461, 12525 },
						_1 = 256,
						_2 = null,
					},
					[13077] = new Feature
					{
						_0 = new int[] { 12461, 12525, 12464, 12521, 12512 },
						_1 = 256,
						_2 = null,
					},
					[13078] = new Feature
					{
						_0 = new int[] { 12461, 12525, 12513, 12540, 12488, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13079] = new Feature
					{
						_0 = new int[] { 12461, 12525, 12527, 12483, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13080] = new Feature
					{
						_0 = new int[] { 12464, 12521, 12512 },
						_1 = 256,
						_2 = null,
					},
					[13081] = new Feature
					{
						_0 = new int[] { 12464, 12521, 12512, 12488, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13082] = new Feature
					{
						_0 = new int[] { 12463, 12523, 12476, 12452, 12525 },
						_1 = 256,
						_2 = null,
					},
					[13083] = new Feature
					{
						_0 = new int[] { 12463, 12525, 12540, 12493 },
						_1 = 256,
						_2 = null,
					},
					[13084] = new Feature
					{
						_0 = new int[] { 12465, 12540, 12473 },
						_1 = 256,
						_2 = null,
					},
					[13085] = new Feature
					{
						_0 = new int[] { 12467, 12523, 12490 },
						_1 = 256,
						_2 = null,
					},
					[13086] = new Feature
					{
						_0 = new int[] { 12467, 12540, 12509 },
						_1 = 256,
						_2 = null,
					},
					[13087] = new Feature
					{
						_0 = new int[] { 12469, 12452, 12463, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13088] = new Feature
					{
						_0 = new int[] { 12469, 12531, 12481, 12540, 12512 },
						_1 = 256,
						_2 = null,
					},
					[13089] = new Feature
					{
						_0 = new int[] { 12471, 12522, 12531, 12464 },
						_1 = 256,
						_2 = null,
					},
					[13090] = new Feature
					{
						_0 = new int[] { 12475, 12531, 12481 },
						_1 = 256,
						_2 = null,
					},
					[13091] = new Feature
					{
						_0 = new int[] { 12475, 12531, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13092] = new Feature
					{
						_0 = new int[] { 12480, 12540, 12473 },
						_1 = 256,
						_2 = null,
					},
					[13093] = new Feature
					{
						_0 = new int[] { 12487, 12471 },
						_1 = 256,
						_2 = null,
					},
					[13094] = new Feature
					{
						_0 = new int[] { 12489, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13095] = new Feature
					{
						_0 = new int[] { 12488, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13096] = new Feature
					{
						_0 = new int[] { 12490, 12494 },
						_1 = 256,
						_2 = null,
					},
					[13097] = new Feature
					{
						_0 = new int[] { 12494, 12483, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13098] = new Feature
					{
						_0 = new int[] { 12495, 12452, 12484 },
						_1 = 256,
						_2 = null,
					},
					[13099] = new Feature
					{
						_0 = new int[] { 12497, 12540, 12475, 12531, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13100] = new Feature
					{
						_0 = new int[] { 12497, 12540, 12484 },
						_1 = 256,
						_2 = null,
					},
					[13101] = new Feature
					{
						_0 = new int[] { 12496, 12540, 12524, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13102] = new Feature
					{
						_0 = new int[] { 12500, 12450, 12473, 12488, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13103] = new Feature
					{
						_0 = new int[] { 12500, 12463, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13104] = new Feature
					{
						_0 = new int[] { 12500, 12467 },
						_1 = 256,
						_2 = null,
					},
					[13105] = new Feature
					{
						_0 = new int[] { 12499, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13106] = new Feature
					{
						_0 = new int[] { 12501, 12449, 12521, 12483, 12489 },
						_1 = 256,
						_2 = null,
					},
					[13107] = new Feature
					{
						_0 = new int[] { 12501, 12451, 12540, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13108] = new Feature
					{
						_0 = new int[] { 12502, 12483, 12471, 12455, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13109] = new Feature
					{
						_0 = new int[] { 12501, 12521, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13110] = new Feature
					{
						_0 = new int[] { 12504, 12463, 12479, 12540, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13111] = new Feature
					{
						_0 = new int[] { 12506, 12477 },
						_1 = 256,
						_2 = null,
					},
					[13112] = new Feature
					{
						_0 = new int[] { 12506, 12491, 12498 },
						_1 = 256,
						_2 = null,
					},
					[13113] = new Feature
					{
						_0 = new int[] { 12504, 12523, 12484 },
						_1 = 256,
						_2 = null,
					},
					[13114] = new Feature
					{
						_0 = new int[] { 12506, 12531, 12473 },
						_1 = 256,
						_2 = null,
					},
					[13115] = new Feature
					{
						_0 = new int[] { 12506, 12540, 12472 },
						_1 = 256,
						_2 = null,
					},
					[13116] = new Feature
					{
						_0 = new int[] { 12505, 12540, 12479 },
						_1 = 256,
						_2 = null,
					},
					[13117] = new Feature
					{
						_0 = new int[] { 12509, 12452, 12531, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13118] = new Feature
					{
						_0 = new int[] { 12508, 12523, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13119] = new Feature
					{
						_0 = new int[] { 12507, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13120] = new Feature
					{
						_0 = new int[] { 12509, 12531, 12489 },
						_1 = 256,
						_2 = null,
					},
					[13121] = new Feature
					{
						_0 = new int[] { 12507, 12540, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13122] = new Feature
					{
						_0 = new int[] { 12507, 12540, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13123] = new Feature
					{
						_0 = new int[] { 12510, 12452, 12463, 12525 },
						_1 = 256,
						_2 = null,
					},
					[13124] = new Feature
					{
						_0 = new int[] { 12510, 12452, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13125] = new Feature
					{
						_0 = new int[] { 12510, 12483, 12495 },
						_1 = 256,
						_2 = null,
					},
					[13126] = new Feature
					{
						_0 = new int[] { 12510, 12523, 12463 },
						_1 = 256,
						_2 = null,
					},
					[13127] = new Feature
					{
						_0 = new int[] { 12510, 12531, 12471, 12519, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13128] = new Feature
					{
						_0 = new int[] { 12511, 12463, 12525, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13129] = new Feature
					{
						_0 = new int[] { 12511, 12522 },
						_1 = 256,
						_2 = null,
					},
					[13130] = new Feature
					{
						_0 = new int[] { 12511, 12522, 12496, 12540, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13131] = new Feature
					{
						_0 = new int[] { 12513, 12460 },
						_1 = 256,
						_2 = null,
					},
					[13132] = new Feature
					{
						_0 = new int[] { 12513, 12460, 12488, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13133] = new Feature
					{
						_0 = new int[] { 12513, 12540, 12488, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13134] = new Feature
					{
						_0 = new int[] { 12516, 12540, 12489 },
						_1 = 256,
						_2 = null,
					},
					[13135] = new Feature
					{
						_0 = new int[] { 12516, 12540, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13136] = new Feature
					{
						_0 = new int[] { 12518, 12450, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13137] = new Feature
					{
						_0 = new int[] { 12522, 12483, 12488, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13138] = new Feature
					{
						_0 = new int[] { 12522, 12521 },
						_1 = 256,
						_2 = null,
					},
					[13139] = new Feature
					{
						_0 = new int[] { 12523, 12500, 12540 },
						_1 = 256,
						_2 = null,
					},
					[13140] = new Feature
					{
						_0 = new int[] { 12523, 12540, 12502, 12523 },
						_1 = 256,
						_2 = null,
					},
					[13141] = new Feature
					{
						_0 = new int[] { 12524, 12512 },
						_1 = 256,
						_2 = null,
					},
					[13142] = new Feature
					{
						_0 = new int[] { 12524, 12531, 12488, 12466, 12531 },
						_1 = 256,
						_2 = null,
					},
					[13143] = new Feature
					{
						_0 = new int[] { 12527, 12483, 12488 },
						_1 = 256,
						_2 = null,
					},
					[13144] = new Feature
					{
						_0 = new int[] { 48, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13145] = new Feature
					{
						_0 = new int[] { 49, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13146] = new Feature
					{
						_0 = new int[] { 50, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13147] = new Feature
					{
						_0 = new int[] { 51, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13148] = new Feature
					{
						_0 = new int[] { 52, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13149] = new Feature
					{
						_0 = new int[] { 53, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13150] = new Feature
					{
						_0 = new int[] { 54, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13151] = new Feature
					{
						_0 = new int[] { 55, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13152] = new Feature
					{
						_0 = new int[] { 56, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13153] = new Feature
					{
						_0 = new int[] { 57, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13154] = new Feature
					{
						_0 = new int[] { 49, 48, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13155] = new Feature
					{
						_0 = new int[] { 49, 49, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13156] = new Feature
					{
						_0 = new int[] { 49, 50, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13157] = new Feature
					{
						_0 = new int[] { 49, 51, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13158] = new Feature
					{
						_0 = new int[] { 49, 52, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13159] = new Feature
					{
						_0 = new int[] { 49, 53, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13160] = new Feature
					{
						_0 = new int[] { 49, 54, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13161] = new Feature
					{
						_0 = new int[] { 49, 55, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13162] = new Feature
					{
						_0 = new int[] { 49, 56, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13163] = new Feature
					{
						_0 = new int[] { 49, 57, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13164] = new Feature
					{
						_0 = new int[] { 50, 48, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13165] = new Feature
					{
						_0 = new int[] { 50, 49, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13166] = new Feature
					{
						_0 = new int[] { 50, 50, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13167] = new Feature
					{
						_0 = new int[] { 50, 51, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13168] = new Feature
					{
						_0 = new int[] { 50, 52, 28857 },
						_1 = 256,
						_2 = null,
					},
					[13169] = new Feature
					{
						_0 = new int[] { 104, 80, 97 },
						_1 = 256,
						_2 = null,
					},
					[13170] = new Feature
					{
						_0 = new int[] { 100, 97 },
						_1 = 256,
						_2 = null,
					},
					[13171] = new Feature
					{
						_0 = new int[] { 65, 85 },
						_1 = 256,
						_2 = null,
					},
					[13172] = new Feature
					{
						_0 = new int[] { 98, 97, 114 },
						_1 = 256,
						_2 = null,
					},
					[13173] = new Feature
					{
						_0 = new int[] { 111, 86 },
						_1 = 256,
						_2 = null,
					},
					[13174] = new Feature
					{
						_0 = new int[] { 112, 99 },
						_1 = 256,
						_2 = null,
					},
					[13175] = new Feature
					{
						_0 = new int[] { 100, 109 },
						_1 = 256,
						_2 = null,
					},
					[13176] = new Feature
					{
						_0 = new int[] { 100, 109, 178 },
						_1 = 256,
						_2 = null,
					},
					[13177] = new Feature
					{
						_0 = new int[] { 100, 109, 179 },
						_1 = 256,
						_2 = null,
					},
					[13178] = new Feature
					{
						_0 = new int[] { 73, 85 },
						_1 = 256,
						_2 = null,
					},
					[13179] = new Feature
					{
						_0 = new int[] { 24179, 25104 },
						_1 = 256,
						_2 = null,
					},
					[13180] = new Feature
					{
						_0 = new int[] { 26157, 21644 },
						_1 = 256,
						_2 = null,
					},
					[13181] = new Feature
					{
						_0 = new int[] { 22823, 27491 },
						_1 = 256,
						_2 = null,
					},
					[13182] = new Feature
					{
						_0 = new int[] { 26126, 27835 },
						_1 = 256,
						_2 = null,
					},
					[13183] = new Feature
					{
						_0 = new int[] { 26666, 24335, 20250, 31038 },
						_1 = 256,
						_2 = null,
					},
					[13184] = new Feature
					{
						_0 = new int[] { 112, 65 },
						_1 = 256,
						_2 = null,
					},
					[13185] = new Feature
					{
						_0 = new int[] { 110, 65 },
						_1 = 256,
						_2 = null,
					},
					[13186] = new Feature
					{
						_0 = new int[] { 956, 65 },
						_1 = 256,
						_2 = null,
					},
					[13187] = new Feature
					{
						_0 = new int[] { 109, 65 },
						_1 = 256,
						_2 = null,
					},
					[13188] = new Feature
					{
						_0 = new int[] { 107, 65 },
						_1 = 256,
						_2 = null,
					},
					[13189] = new Feature
					{
						_0 = new int[] { 75, 66 },
						_1 = 256,
						_2 = null,
					},
					[13190] = new Feature
					{
						_0 = new int[] { 77, 66 },
						_1 = 256,
						_2 = null,
					},
					[13191] = new Feature
					{
						_0 = new int[] { 71, 66 },
						_1 = 256,
						_2 = null,
					},
					[13192] = new Feature
					{
						_0 = new int[] { 99, 97, 108 },
						_1 = 256,
						_2 = null,
					},
					[13193] = new Feature
					{
						_0 = new int[] { 107, 99, 97, 108 },
						_1 = 256,
						_2 = null,
					},
					[13194] = new Feature
					{
						_0 = new int[] { 112, 70 },
						_1 = 256,
						_2 = null,
					},
					[13195] = new Feature
					{
						_0 = new int[] { 110, 70 },
						_1 = 256,
						_2 = null,
					},
					[13196] = new Feature
					{
						_0 = new int[] { 956, 70 },
						_1 = 256,
						_2 = null,
					},
					[13197] = new Feature
					{
						_0 = new int[] { 956, 103 },
						_1 = 256,
						_2 = null,
					},
					[13198] = new Feature
					{
						_0 = new int[] { 109, 103 },
						_1 = 256,
						_2 = null,
					},
					[13199] = new Feature
					{
						_0 = new int[] { 107, 103 },
						_1 = 256,
						_2 = null,
					},
					[13200] = new Feature
					{
						_0 = new int[] { 72, 122 },
						_1 = 256,
						_2 = null,
					},
					[13201] = new Feature
					{
						_0 = new int[] { 107, 72, 122 },
						_1 = 256,
						_2 = null,
					},
					[13202] = new Feature
					{
						_0 = new int[] { 77, 72, 122 },
						_1 = 256,
						_2 = null,
					},
					[13203] = new Feature
					{
						_0 = new int[] { 71, 72, 122 },
						_1 = 256,
						_2 = null,
					},
					[13204] = new Feature
					{
						_0 = new int[] { 84, 72, 122 },
						_1 = 256,
						_2 = null,
					},
					[13205] = new Feature
					{
						_0 = new int[] { 956, 8467 },
						_1 = 256,
						_2 = null,
					},
					[13206] = new Feature
					{
						_0 = new int[] { 109, 8467 },
						_1 = 256,
						_2 = null,
					},
					[13207] = new Feature
					{
						_0 = new int[] { 100, 8467 },
						_1 = 256,
						_2 = null,
					},
					[13208] = new Feature
					{
						_0 = new int[] { 107, 8467 },
						_1 = 256,
						_2 = null,
					},
					[13209] = new Feature
					{
						_0 = new int[] { 102, 109 },
						_1 = 256,
						_2 = null,
					},
					[13210] = new Feature
					{
						_0 = new int[] { 110, 109 },
						_1 = 256,
						_2 = null,
					},
					[13211] = new Feature
					{
						_0 = new int[] { 956, 109 },
						_1 = 256,
						_2 = null,
					},
					[13212] = new Feature
					{
						_0 = new int[] { 109, 109 },
						_1 = 256,
						_2 = null,
					},
					[13213] = new Feature
					{
						_0 = new int[] { 99, 109 },
						_1 = 256,
						_2 = null,
					},
					[13214] = new Feature
					{
						_0 = new int[] { 107, 109 },
						_1 = 256,
						_2 = null,
					},
					[13215] = new Feature
					{
						_0 = new int[] { 109, 109, 178 },
						_1 = 256,
						_2 = null,
					},
					[13216] = new Feature
					{
						_0 = new int[] { 99, 109, 178 },
						_1 = 256,
						_2 = null,
					},
					[13217] = new Feature
					{
						_0 = new int[] { 109, 178 },
						_1 = 256,
						_2 = null,
					},
					[13218] = new Feature
					{
						_0 = new int[] { 107, 109, 178 },
						_1 = 256,
						_2 = null,
					},
					[13219] = new Feature
					{
						_0 = new int[] { 109, 109, 179 },
						_1 = 256,
						_2 = null,
					},
					[13220] = new Feature
					{
						_0 = new int[] { 99, 109, 179 },
						_1 = 256,
						_2 = null,
					},
					[13221] = new Feature
					{
						_0 = new int[] { 109, 179 },
						_1 = 256,
						_2 = null,
					},
					[13222] = new Feature
					{
						_0 = new int[] { 107, 109, 179 },
						_1 = 256,
						_2 = null,
					},
					[13223] = new Feature
					{
						_0 = new int[] { 109, 8725, 115 },
						_1 = 256,
						_2 = null,
					},
					[13224] = new Feature
					{
						_0 = new int[] { 109, 8725, 115, 178 },
						_1 = 256,
						_2 = null,
					},
					[13225] = new Feature
					{
						_0 = new int[] { 80, 97 },
						_1 = 256,
						_2 = null,
					},
					[13226] = new Feature
					{
						_0 = new int[] { 107, 80, 97 },
						_1 = 256,
						_2 = null,
					},
					[13227] = new Feature
					{
						_0 = new int[] { 77, 80, 97 },
						_1 = 256,
						_2 = null,
					},
					[13228] = new Feature
					{
						_0 = new int[] { 71, 80, 97 },
						_1 = 256,
						_2 = null,
					},
					[13229] = new Feature
					{
						_0 = new int[] { 114, 97, 100 },
						_1 = 256,
						_2 = null,
					},
					[13230] = new Feature
					{
						_0 = new int[] { 114, 97, 100, 8725, 115 },
						_1 = 256,
						_2 = null,
					},
					[13231] = new Feature
					{
						_0 = new int[] { 114, 97, 100, 8725, 115, 178 },
						_1 = 256,
						_2 = null,
					},
					[13232] = new Feature
					{
						_0 = new int[] { 112, 115 },
						_1 = 256,
						_2 = null,
					},
					[13233] = new Feature
					{
						_0 = new int[] { 110, 115 },
						_1 = 256,
						_2 = null,
					},
					[13234] = new Feature
					{
						_0 = new int[] { 956, 115 },
						_1 = 256,
						_2 = null,
					},
					[13235] = new Feature
					{
						_0 = new int[] { 109, 115 },
						_1 = 256,
						_2 = null,
					},
					[13236] = new Feature
					{
						_0 = new int[] { 112, 86 },
						_1 = 256,
						_2 = null,
					},
					[13237] = new Feature
					{
						_0 = new int[] { 110, 86 },
						_1 = 256,
						_2 = null,
					},
					[13238] = new Feature
					{
						_0 = new int[] { 956, 86 },
						_1 = 256,
						_2 = null,
					},
					[13239] = new Feature
					{
						_0 = new int[] { 109, 86 },
						_1 = 256,
						_2 = null,
					},
					[13240] = new Feature
					{
						_0 = new int[] { 107, 86 },
						_1 = 256,
						_2 = null,
					},
					[13241] = new Feature
					{
						_0 = new int[] { 77, 86 },
						_1 = 256,
						_2 = null,
					},
					[13242] = new Feature
					{
						_0 = new int[] { 112, 87 },
						_1 = 256,
						_2 = null,
					},
					[13243] = new Feature
					{
						_0 = new int[] { 110, 87 },
						_1 = 256,
						_2 = null,
					},
					[13244] = new Feature
					{
						_0 = new int[] { 956, 87 },
						_1 = 256,
						_2 = null,
					},
					[13245] = new Feature
					{
						_0 = new int[] { 109, 87 },
						_1 = 256,
						_2 = null,
					},
					[13246] = new Feature
					{
						_0 = new int[] { 107, 87 },
						_1 = 256,
						_2 = null,
					},
					[13247] = new Feature
					{
						_0 = new int[] { 77, 87 },
						_1 = 256,
						_2 = null,
					},
					[13248] = new Feature
					{
						_0 = new int[] { 107, 937 },
						_1 = 256,
						_2 = null,
					},
					[13249] = new Feature
					{
						_0 = new int[] { 77, 937 },
						_1 = 256,
						_2 = null,
					},
					[13250] = new Feature
					{
						_0 = new int[] { 97, 46, 109, 46 },
						_1 = 256,
						_2 = null,
					},
					[13251] = new Feature
					{
						_0 = new int[] { 66, 113 },
						_1 = 256,
						_2 = null,
					},
					[13252] = new Feature
					{
						_0 = new int[] { 99, 99 },
						_1 = 256,
						_2 = null,
					},
					[13253] = new Feature
					{
						_0 = new int[] { 99, 100 },
						_1 = 256,
						_2 = null,
					},
					[13254] = new Feature
					{
						_0 = new int[] { 67, 8725, 107, 103 },
						_1 = 256,
						_2 = null,
					},
					[13255] = new Feature
					{
						_0 = new int[] { 67, 111, 46 },
						_1 = 256,
						_2 = null,
					},
					[13256] = new Feature
					{
						_0 = new int[] { 100, 66 },
						_1 = 256,
						_2 = null,
					},
					[13257] = new Feature
					{
						_0 = new int[] { 71, 121 },
						_1 = 256,
						_2 = null,
					},
					[13258] = new Feature
					{
						_0 = new int[] { 104, 97 },
						_1 = 256,
						_2 = null,
					},
					[13259] = new Feature
					{
						_0 = new int[] { 72, 80 },
						_1 = 256,
						_2 = null,
					},
					[13260] = new Feature
					{
						_0 = new int[] { 105, 110 },
						_1 = 256,
						_2 = null,
					},
					[13261] = new Feature
					{
						_0 = new int[] { 75, 75 },
						_1 = 256,
						_2 = null,
					},
					[13262] = new Feature
					{
						_0 = new int[] { 75, 77 },
						_1 = 256,
						_2 = null,
					},
					[13263] = new Feature
					{
						_0 = new int[] { 107, 116 },
						_1 = 256,
						_2 = null,
					},
					[13264] = new Feature
					{
						_0 = new int[] { 108, 109 },
						_1 = 256,
						_2 = null,
					},
					[13265] = new Feature
					{
						_0 = new int[] { 108, 110 },
						_1 = 256,
						_2 = null,
					},
					[13266] = new Feature
					{
						_0 = new int[] { 108, 111, 103 },
						_1 = 256,
						_2 = null,
					},
					[13267] = new Feature
					{
						_0 = new int[] { 108, 120 },
						_1 = 256,
						_2 = null,
					},
					[13268] = new Feature
					{
						_0 = new int[] { 109, 98 },
						_1 = 256,
						_2 = null,
					},
					[13269] = new Feature
					{
						_0 = new int[] { 109, 105, 108 },
						_1 = 256,
						_2 = null,
					},
					[13270] = new Feature
					{
						_0 = new int[] { 109, 111, 108 },
						_1 = 256,
						_2 = null,
					},
					[13271] = new Feature
					{
						_0 = new int[] { 80, 72 },
						_1 = 256,
						_2 = null,
					},
					[13272] = new Feature
					{
						_0 = new int[] { 112, 46, 109, 46 },
						_1 = 256,
						_2 = null,
					},
					[13273] = new Feature
					{
						_0 = new int[] { 80, 80, 77 },
						_1 = 256,
						_2 = null,
					},
					[13274] = new Feature
					{
						_0 = new int[] { 80, 82 },
						_1 = 256,
						_2 = null,
					},
					[13275] = new Feature
					{
						_0 = new int[] { 115, 114 },
						_1 = 256,
						_2 = null,
					},
					[13276] = new Feature
					{
						_0 = new int[] { 83, 118 },
						_1 = 256,
						_2 = null,
					},
					[13277] = new Feature
					{
						_0 = new int[] { 87, 98 },
						_1 = 256,
						_2 = null,
					},
					[13278] = new Feature
					{
						_0 = new int[] { 86, 8725, 109 },
						_1 = 256,
						_2 = null,
					},
					[13279] = new Feature
					{
						_0 = new int[] { 65, 8725, 109 },
						_1 = 256,
						_2 = null,
					},
					[13280] = new Feature
					{
						_0 = new int[] { 49, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13281] = new Feature
					{
						_0 = new int[] { 50, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13282] = new Feature
					{
						_0 = new int[] { 51, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13283] = new Feature
					{
						_0 = new int[] { 52, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13284] = new Feature
					{
						_0 = new int[] { 53, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13285] = new Feature
					{
						_0 = new int[] { 54, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13286] = new Feature
					{
						_0 = new int[] { 55, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13287] = new Feature
					{
						_0 = new int[] { 56, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13288] = new Feature
					{
						_0 = new int[] { 57, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13289] = new Feature
					{
						_0 = new int[] { 49, 48, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13290] = new Feature
					{
						_0 = new int[] { 49, 49, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13291] = new Feature
					{
						_0 = new int[] { 49, 50, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13292] = new Feature
					{
						_0 = new int[] { 49, 51, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13293] = new Feature
					{
						_0 = new int[] { 49, 52, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13294] = new Feature
					{
						_0 = new int[] { 49, 53, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13295] = new Feature
					{
						_0 = new int[] { 49, 54, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13296] = new Feature
					{
						_0 = new int[] { 49, 55, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13297] = new Feature
					{
						_0 = new int[] { 49, 56, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13298] = new Feature
					{
						_0 = new int[] { 49, 57, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13299] = new Feature
					{
						_0 = new int[] { 50, 48, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13300] = new Feature
					{
						_0 = new int[] { 50, 49, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13301] = new Feature
					{
						_0 = new int[] { 50, 50, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13302] = new Feature
					{
						_0 = new int[] { 50, 51, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13303] = new Feature
					{
						_0 = new int[] { 50, 52, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13304] = new Feature
					{
						_0 = new int[] { 50, 53, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13305] = new Feature
					{
						_0 = new int[] { 50, 54, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13306] = new Feature
					{
						_0 = new int[] { 50, 55, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13307] = new Feature
					{
						_0 = new int[] { 50, 56, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13308] = new Feature
					{
						_0 = new int[] { 50, 57, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13309] = new Feature
					{
						_0 = new int[] { 51, 48, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13310] = new Feature
					{
						_0 = new int[] { 51, 49, 26085 },
						_1 = 256,
						_2 = null,
					},
					[13311] = new Feature
					{
						_0 = new int[] { 103, 97, 108 },
						_1 = 256,
						_2 = null,
					},
				},
				[27136] = new Dictionary<int, Feature>
				{
					[92912] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[92913] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[92914] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[92915] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[92916] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
				},
				[27392] = new Dictionary<int, Feature>
				{
					[92976] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[92977] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[92978] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[92979] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[92980] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[92981] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[92982] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[42496] = new Dictionary<int, Feature>
				{
					[42607] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42612] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42613] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42614] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42615] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42616] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42617] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42618] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42619] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42620] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42621] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42652] = new Feature
					{
						_0 = new int[] { 1098 },
						_1 = 256,
						_2 = null,
					},
					[42653] = new Feature
					{
						_0 = new int[] { 1100 },
						_1 = 256,
						_2 = null,
					},
					[42654] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42655] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42736] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[42737] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[42752] = new Dictionary<int, Feature>
				{
					[42864] = new Feature
					{
						_0 = new int[] { 42863 },
						_1 = 256,
						_2 = null,
					},
					[43000] = new Feature
					{
						_0 = new int[] { 294 },
						_1 = 256,
						_2 = null,
					},
					[43001] = new Feature
					{
						_0 = new int[] { 339 },
						_1 = 256,
						_2 = null,
					},
				},
				[43008] = new Dictionary<int, Feature>
				{
					[43014] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[43204] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[43232] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43233] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43234] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43235] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43236] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43237] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43238] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43239] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43240] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43241] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43242] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43243] = new Feature
					{


						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43244] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43245] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43246] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43247] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43248] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43249] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[43264] = new Dictionary<int, Feature>
				{
					[43307] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[43308] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[43309] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[43347] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
					[43443] = new Feature
					{
						_0 = null,
						_1 = 7,
						_2 = null,
					},
					[43456] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
				},
				[43520] = new Dictionary<int, Feature>
				{
					[43696] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43698] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43699] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43700] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[43703] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43704] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43710] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43711] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43713] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[43766] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
				},
				[43776] = new Dictionary<int, Feature>
				{
					[43868] = new Feature
					{
						_0 = new int[] { 42791 },
						_1 = 256,
						_2 = null,
					},
					[43869] = new Feature
					{
						_0 = new int[] { 43831 },
						_1 = 256,
						_2 = null,
					},
					[43870] = new Feature
					{
						_0 = new int[] { 619 },
						_1 = 256,
						_2 = null,
					},
					[43871] = new Feature
					{
						_0 = new int[] { 43858 },
						_1 = 256,
						_2 = null,
					},
					[44013] = new Feature
					{
						_0 = null,
						_1 = 9,
						_2 = null,
					},
				},
				[48128] = new Dictionary<int, Feature>
				{
					[113822] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
				},
				[53504] = new Dictionary<int, Feature>
				{
					[119134] = new Feature
					{
						_0 = new int[] { 119127, 119141 },
						_1 = 512,
						_2 = null,
					},
					[119135] = new Feature
					{
						_0 = new int[] { 119128, 119141 },
						_1 = 512,
						_2 = null,
					},
					[119136] = new Feature
					{
						_0 = new int[] { 119135, 119150 },
						_1 = 512,
						_2 = null,
					},
					[119137] = new Feature
					{
						_0 = new int[] { 119135, 119151 },
						_1 = 512,
						_2 = null,
					},
					[119138] = new Feature
					{
						_0 = new int[] { 119135, 119152 },
						_1 = 512,
						_2 = null,
					},
					[119139] = new Feature
					{
						_0 = new int[] { 119135, 119153 },
						_1 = 512,
						_2 = null,
					},
					[119140] = new Feature
					{
						_0 = new int[] { 119135, 119154 },
						_1 = 512,
						_2 = null,
					},
					[119141] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[119142] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[119143] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[119144] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[119145] = new Feature
					{
						_0 = null,
						_1 = 1,
						_2 = null,
					},
					[119149] = new Feature
					{
						_0 = null,
						_1 = 226,
						_2 = null,
					},
					[119150] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[119151] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[119152] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[119153] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[119154] = new Feature
					{
						_0 = null,
						_1 = 216,
						_2 = null,
					},
					[119163] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119164] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119165] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119166] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119167] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119168] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119169] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119170] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119173] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119174] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119175] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119176] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119177] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119178] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119179] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[119210] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119211] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119212] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119213] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119227] = new Feature
					{
						_0 = new int[] { 119225, 119141 },
						_1 = 512,
						_2 = null,
					},
					[119228] = new Feature
					{
						_0 = new int[] { 119226, 119141 },
						_1 = 512,
						_2 = null,
					},
					[119229] = new Feature
					{
						_0 = new int[] { 119227, 119150 },
						_1 = 512,
						_2 = null,
					},
					[119230] = new Feature
					{
						_0 = new int[] { 119228, 119150 },
						_1 = 512,
						_2 = null,
					},
					[119231] = new Feature
					{
						_0 = new int[] { 119227, 119151 },
						_1 = 512,
						_2 = null,
					},
					[119232] = new Feature
					{
						_0 = new int[] { 119228, 119151 },
						_1 = 512,
						_2 = null,
					},
				},
				[53760] = new Dictionary<int, Feature>
				{
					[119362] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119363] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[119364] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
				},
				[54272] = new Dictionary<int, Feature>
				{
					[119808] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[119809] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[119810] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[119811] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[119812] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[119813] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[119814] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[119815] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[119816] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[119817] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[119818] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[119819] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[119820] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[119821] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[119822] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[119823] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[119824] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[119825] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[119826] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[119827] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[119828] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[119829] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[119830] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[119831] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[119832] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[119833] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[119834] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[119835] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[119836] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[119837] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[119838] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[119839] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[119840] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[119841] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[119842] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[119843] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[119844] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[119845] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[119846] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[119847] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[119848] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[119849] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[119850] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[119851] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[119852] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[119853] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[119854] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[119855] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[119856] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[119857] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[119858] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[119859] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[119860] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[119861] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[119862] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[119863] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[119864] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[119865] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[119866] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[119867] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[119868] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[119869] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[119870] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[119871] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[119872] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[119873] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[119874] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[119875] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[119876] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[119877] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[119878] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[119879] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[119880] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[119881] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[119882] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[119883] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[119884] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[119885] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[119886] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[119887] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[119888] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[119889] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[119890] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[119891] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[119892] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[119894] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[119895] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[119896] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[119897] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[119898] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[119899] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[119900] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[119901] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[119902] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[119903] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[119904] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[119905] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[119906] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[119907] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[119908] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[119909] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[119910] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[119911] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[119912] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[119913] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[119914] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[119915] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[119916] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[119917] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[119918] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[119919] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[119920] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[119921] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[119922] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[119923] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[119924] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[119925] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[119926] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[119927] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[119928] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[119929] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[119930] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[119931] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[119932] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[119933] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[119934] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[119935] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[119936] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[119937] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[119938] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[119939] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[119940] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[119941] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[119942] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[119943] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[119944] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[119945] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[119946] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[119947] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[119948] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[119949] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[119950] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[119951] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[119952] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[119953] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[119954] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[119955] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[119956] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[119957] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[119958] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[119959] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[119960] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[119961] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[119962] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[119963] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[119964] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[119966] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[119967] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[119970] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[119973] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[119974] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[119977] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[119978] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[119979] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[119980] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[119982] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[119983] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[119984] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[119985] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[119986] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[119987] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[119988] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[119989] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[119990] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[119991] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[119992] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[119993] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[119995] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[119997] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[119998] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[119999] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120000] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120001] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120002] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120003] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120005] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120006] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120007] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120008] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120009] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120010] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120011] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120012] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120013] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120014] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120015] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120016] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120017] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120018] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[120019] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120020] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120021] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120022] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120023] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[120024] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[120025] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120026] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120027] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120028] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120029] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[120030] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120031] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[120032] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[120033] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[120034] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120035] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120036] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120037] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120038] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120039] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120040] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120041] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[120042] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120043] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120044] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120045] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120046] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120047] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120048] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120049] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120050] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120051] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120052] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120053] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120054] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120055] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120056] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120057] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120058] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120059] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120060] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120061] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120062] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120063] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
				},
				[54528] = new Dictionary<int, Feature>
				{
					[120064] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120065] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120066] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120067] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120068] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120069] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120071] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120072] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120073] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120074] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120077] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120078] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120079] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120080] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120081] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[120082] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120083] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[120084] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[120086] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120087] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120088] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120089] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120090] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120091] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120092] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120094] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120095] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120096] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120097] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120098] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120099] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120100] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120101] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120102] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120103] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120104] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120105] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120106] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120107] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120108] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120109] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120110] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120111] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120112] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120113] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120114] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120115] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120116] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120117] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120118] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120119] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120120] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120121] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120123] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120124] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120125] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120126] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120128] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[120129] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120130] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120131] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120132] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120134] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120138] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120139] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120140] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120141] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120142] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120143] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120144] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120146] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120147] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120148] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120149] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120150] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120151] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120152] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120153] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120154] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120155] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120156] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120157] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120158] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120159] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120160] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120161] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120162] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120163] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120164] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120165] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120166] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120167] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120168] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120169] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120170] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120171] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120172] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120173] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120174] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[120175] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120176] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120177] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120178] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120179] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[120180] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[120181] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120182] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120183] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120184] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120185] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[120186] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120187] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[120188] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[120189] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[120190] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120191] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120192] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120193] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120194] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120195] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120196] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120197] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[120198] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120199] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120200] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120201] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120202] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120203] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120204] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120205] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120206] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120207] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120208] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120209] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120210] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120211] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120212] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120213] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120214] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120215] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120216] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120217] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120218] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120219] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120220] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120221] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120222] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120223] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120224] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120225] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120226] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[120227] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120228] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120229] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120230] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120231] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[120232] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[120233] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120234] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120235] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120236] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120237] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[120238] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120239] = new Feature


					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[120240] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[120241] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[120242] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120243] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120244] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120245] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120246] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120247] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120248] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120249] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[120250] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120251] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120252] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120253] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120254] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120255] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120256] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120257] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120258] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120259] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120260] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120261] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120262] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120263] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120264] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120265] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120266] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120267] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120268] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120269] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120270] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120271] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120272] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120273] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120274] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120275] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120276] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120277] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120278] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[120279] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120280] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120281] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120282] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120283] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[120284] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[120285] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120286] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120287] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120288] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120289] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[120290] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120291] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[120292] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[120293] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[120294] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120295] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120296] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120297] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120298] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120299] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120300] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120301] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[120302] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120303] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120304] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120305] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120306] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120307] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120308] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120309] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120310] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120311] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120312] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120313] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120314] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120315] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120316] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120317] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120318] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120319] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
				},
				[54784] = new Dictionary<int, Feature>
				{
					[120320] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120321] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120322] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120323] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120324] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120325] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120326] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120327] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120328] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120329] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120330] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[120331] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120332] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120333] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120334] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120335] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[120336] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[120337] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120338] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120339] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120340] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120341] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[120342] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120343] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[120344] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[120345] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[120346] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120347] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120348] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120349] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120350] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120351] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120352] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120353] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[120354] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120355] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120356] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120357] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120358] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120359] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120360] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120361] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120362] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120363] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120364] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120365] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120366] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120367] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120368] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120369] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120370] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120371] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120372] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120373] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120374] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120375] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120376] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120377] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120378] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120379] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120380] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120381] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120382] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[120383] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120384] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120385] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120386] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120387] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[120388] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[120389] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120390] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120391] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120392] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120393] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[120394] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120395] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[120396] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[120397] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[120398] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120399] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120400] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120401] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120402] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120403] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120404] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120405] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[120406] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120407] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120408] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120409] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120410] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120411] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120412] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120413] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120414] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120415] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120416] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120417] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120418] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120419] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120420] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120421] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120422] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120423] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120424] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120425] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120426] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120427] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120428] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120429] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120430] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120431] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120432] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[120433] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[120434] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[120435] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[120436] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[120437] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[120438] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[120439] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[120440] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[120441] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[120442] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[120443] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[120444] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[120445] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[120446] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[120447] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[120448] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[120449] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[120450] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[120451] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[120452] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[120453] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[120454] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[120455] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[120456] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[120457] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[120458] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[120459] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[120460] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[120461] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[120462] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[120463] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[120464] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[120465] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[120466] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[120467] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[120468] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[120469] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[120470] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[120471] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[120472] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[120473] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[120474] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[120475] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[120476] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[120477] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[120478] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[120479] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[120480] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[120481] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[120482] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[120483] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[120484] = new Feature
					{
						_0 = new int[] { 305 },
						_1 = 256,
						_2 = null,
					},
					[120485] = new Feature
					{
						_0 = new int[] { 567 },
						_1 = 256,
						_2 = null,
					},
					[120488] = new Feature
					{
						_0 = new int[] { 913 },
						_1 = 256,
						_2 = null,
					},
					[120489] = new Feature
					{
						_0 = new int[] { 914 },
						_1 = 256,
						_2 = null,
					},
					[120490] = new Feature
					{
						_0 = new int[] { 915 },
						_1 = 256,
						_2 = null,
					},
					[120491] = new Feature
					{
						_0 = new int[] { 916 },
						_1 = 256,
						_2 = null,
					},
					[120492] = new Feature
					{
						_0 = new int[] { 917 },
						_1 = 256,
						_2 = null,
					},
					[120493] = new Feature
					{
						_0 = new int[] { 918 },
						_1 = 256,
						_2 = null,
					},
					[120494] = new Feature
					{
						_0 = new int[] { 919 },
						_1 = 256,
						_2 = null,
					},
					[120495] = new Feature
					{
						_0 = new int[] { 920 },
						_1 = 256,
						_2 = null,
					},
					[120496] = new Feature
					{
						_0 = new int[] { 921 },
						_1 = 256,
						_2 = null,
					},
					[120497] = new Feature
					{
						_0 = new int[] { 922 },
						_1 = 256,
						_2 = null,
					},
					[120498] = new Feature
					{
						_0 = new int[] { 923 },
						_1 = 256,
						_2 = null,
					},
					[120499] = new Feature
					{
						_0 = new int[] { 924 },
						_1 = 256,
						_2 = null,
					},
					[120500] = new Feature
					{
						_0 = new int[] { 925 },
						_1 = 256,
						_2 = null,
					},
					[120501] = new Feature
					{
						_0 = new int[] { 926 },
						_1 = 256,
						_2 = null,
					},
					[120502] = new Feature
					{
						_0 = new int[] { 927 },
						_1 = 256,
						_2 = null,
					},
					[120503] = new Feature
					{
						_0 = new int[] { 928 },
						_1 = 256,
						_2 = null,
					},
					[120504] = new Feature
					{
						_0 = new int[] { 929 },
						_1 = 256,
						_2 = null,
					},
					[120505] = new Feature
					{
						_0 = new int[] { 1012 },
						_1 = 256,
						_2 = null,
					},
					[120506] = new Feature
					{
						_0 = new int[] { 931 },
						_1 = 256,
						_2 = null,
					},
					[120507] = new Feature
					{
						_0 = new int[] { 932 },
						_1 = 256,
						_2 = null,
					},
					[120508] = new Feature
					{
						_0 = new int[] { 933 },
						_1 = 256,
						_2 = null,
					},
					[120509] = new Feature
					{
						_0 = new int[] { 934 },
						_1 = 256,
						_2 = null,
					},
					[120510] = new Feature
					{
						_0 = new int[] { 935 },
						_1 = 256,
						_2 = null,
					},
					[120511] = new Feature
					{
						_0 = new int[] { 936 },
						_1 = 256,
						_2 = null,
					},
					[120512] = new Feature
					{
						_0 = new int[] { 937 },
						_1 = 256,
						_2 = null,
					},
					[120513] = new Feature
					{
						_0 = new int[] { 8711 },
						_1 = 256,
						_2 = null,
					},
					[120514] = new Feature
					{
						_0 = new int[] { 945 },
						_1 = 256,
						_2 = null,
					},
					[120515] = new Feature
					{
						_0 = new int[] { 946 },
						_1 = 256,
						_2 = null,
					},
					[120516] = new Feature
					{
						_0 = new int[] { 947 },
						_1 = 256,
						_2 = null,
					},
					[120517] = new Feature
					{
						_0 = new int[] { 948 },
						_1 = 256,
						_2 = null,
					},
					[120518] = new Feature
					{
						_0 = new int[] { 949 },
						_1 = 256,
						_2 = null,
					},
					[120519] = new Feature
					{
						_0 = new int[] { 950 },
						_1 = 256,
						_2 = null,
					},
					[120520] = new Feature
					{
						_0 = new int[] { 951 },
						_1 = 256,
						_2 = null,
					},
					[120521] = new Feature
					{
						_0 = new int[] { 952 },
						_1 = 256,
						_2 = null,
					},
					[120522] = new Feature
					{
						_0 = new int[] { 953 },
						_1 = 256,
						_2 = null,
					},
					[120523] = new Feature
					{
						_0 = new int[] { 954 },
						_1 = 256,
						_2 = null,
					},
					[120524] = new Feature
					{
						_0 = new int[] { 955 },
						_1 = 256,
						_2 = null,
					},
					[120525] = new Feature
					{
						_0 = new int[] { 956 },
						_1 = 256,
						_2 = null,
					},
					[120526] = new Feature
					{
						_0 = new int[] { 957 },
						_1 = 256,
						_2 = null,
					},
					[120527] = new Feature
					{
						_0 = new int[] { 958 },
						_1 = 256,
						_2 = null,
					},
					[120528] = new Feature
					{
						_0 = new int[] { 959 },
						_1 = 256,
						_2 = null,
					},
					[120529] = new Feature
					{
						_0 = new int[] { 960 },
						_1 = 256,
						_2 = null,
					},
					[120530] = new Feature
					{
						_0 = new int[] { 961 },
						_1 = 256,
						_2 = null,
					},
					[120531] = new Feature
					{
						_0 = new int[] { 962 },
						_1 = 256,
						_2 = null,
					},
					[120532] = new Feature
					{
						_0 = new int[] { 963 },
						_1 = 256,
						_2 = null,
					},
					[120533] = new Feature
					{
						_0 = new int[] { 964 },
						_1 = 256,
						_2 = null,
					},
					[120534] = new Feature
					{
						_0 = new int[] { 965 },
						_1 = 256,
						_2 = null,
					},
					[120535] = new Feature
					{
						_0 = new int[] { 966 },
						_1 = 256,
						_2 = null,
					},
					[120536] = new Feature
					{
						_0 = new int[] { 967 },
						_1 = 256,
						_2 = null,
					},
					[120537] = new Feature
					{
						_0 = new int[] { 968 },
						_1 = 256,
						_2 = null,
					},
					[120538] = new Feature
					{
						_0 = new int[] { 969 },
						_1 = 256,
						_2 = null,
					},
					[120539] = new Feature
					{
						_0 = new int[] { 8706 },
						_1 = 256,
						_2 = null,
					},
					[120540] = new Feature
					{
						_0 = new int[] { 1013 },
						_1 = 256,
						_2 = null,
					},
					[120541] = new Feature
					{
						_0 = new int[] { 977 },
						_1 = 256,
						_2 = null,
					},
					[120542] = new Feature
					{
						_0 = new int[] { 1008 },
						_1 = 256,
						_2 = null,
					},
					[120543] = new Feature
					{
						_0 = new int[] { 981 },
						_1 = 256,
						_2 = null,
					},
					[120544] = new Feature
					{
						_0 = new int[] { 1009 },
						_1 = 256,
						_2 = null,
					},
					[120545] = new Feature
					{
						_0 = new int[] { 982 },
						_1 = 256,
						_2 = null,
					},
					[120546] = new Feature
					{
						_0 = new int[] { 913 },
						_1 = 256,
						_2 = null,
					},
					[120547] = new Feature
					{
						_0 = new int[] { 914 },
						_1 = 256,
						_2 = null,
					},
					[120548] = new Feature
					{
						_0 = new int[] { 915 },
						_1 = 256,
						_2 = null,
					},
					[120549] = new Feature
					{
						_0 = new int[] { 916 },
						_1 = 256,
						_2 = null,
					},
					[120550] = new Feature
					{
						_0 = new int[] { 917 },
						_1 = 256,
						_2 = null,
					},
					[120551] = new Feature
					{
						_0 = new int[] { 918 },
						_1 = 256,
						_2 = null,
					},
					[120552] = new Feature
					{
						_0 = new int[] { 919 },
						_1 = 256,
						_2 = null,
					},
					[120553] = new Feature
					{
						_0 = new int[] { 920 },
						_1 = 256,
						_2 = null,
					},
					[120554] = new Feature
					{
						_0 = new int[] { 921 },
						_1 = 256,
						_2 = null,
					},
					[120555] = new Feature
					{
						_0 = new int[] { 922 },
						_1 = 256,
						_2 = null,
					},
					[120556] = new Feature
					{
						_0 = new int[] { 923 },
						_1 = 256,
						_2 = null,
					},
					[120557] = new Feature
					{
						_0 = new int[] { 924 },
						_1 = 256,
						_2 = null,
					},
					[120558] = new Feature
					{
						_0 = new int[] { 925 },
						_1 = 256,
						_2 = null,
					},
					[120559] = new Feature
					{
						_0 = new int[] { 926 },
						_1 = 256,
						_2 = null,
					},
					[120560] = new Feature
					{
						_0 = new int[] { 927 },
						_1 = 256,
						_2 = null,
					},
					[120561] = new Feature
					{
						_0 = new int[] { 928 },
						_1 = 256,
						_2 = null,
					},
					[120562] = new Feature
					{
						_0 = new int[] { 929 },
						_1 = 256,
						_2 = null,
					},
					[120563] = new Feature
					{
						_0 = new int[] { 1012 },
						_1 = 256,
						_2 = null,
					},
					[120564] = new Feature
					{
						_0 = new int[] { 931 },
						_1 = 256,
						_2 = null,
					},
					[120565] = new Feature
					{
						_0 = new int[] { 932 },
						_1 = 256,
						_2 = null,
					},
					[120566] = new Feature
					{
						_0 = new int[] { 933 },
						_1 = 256,
						_2 = null,
					},
					[120567] = new Feature
					{
						_0 = new int[] { 934 },
						_1 = 256,
						_2 = null,
					},
					[120568] = new Feature
					{
						_0 = new int[] { 935 },
						_1 = 256,
						_2 = null,
					},
					[120569] = new Feature
					{
						_0 = new int[] { 936 },
						_1 = 256,
						_2 = null,
					},
					[120570] = new Feature
					{
						_0 = new int[] { 937 },
						_1 = 256,
						_2 = null,
					},
					[120571] = new Feature
					{
						_0 = new int[] { 8711 },
						_1 = 256,
						_2 = null,
					},
					[120572] = new Feature
					{
						_0 = new int[] { 945 },
						_1 = 256,
						_2 = null,
					},
					[120573] = new Feature
					{
						_0 = new int[] { 946 },
						_1 = 256,
						_2 = null,
					},
					[120574] = new Feature
					{
						_0 = new int[] { 947 },
						_1 = 256,
						_2 = null,
					},
					[120575] = new Feature
					{
						_0 = new int[] { 948 },
						_1 = 256,
						_2 = null,
					},
				},
				[55040] = new Dictionary<int, Feature>
				{
					[120576] = new Feature
					{
						_0 = new int[] { 949 },
						_1 = 256,
						_2 = null,
					},
					[120577] = new Feature
					{
						_0 = new int[] { 950 },
						_1 = 256,
						_2 = null,
					},
					[120578] = new Feature
					{
						_0 = new int[] { 951 },
						_1 = 256,
						_2 = null,
					},
					[120579] = new Feature
					{
						_0 = new int[] { 952 },
						_1 = 256,
						_2 = null,
					},
					[120580] = new Feature
					{
						_0 = new int[] { 953 },
						_1 = 256,
						_2 = null,
					},
					[120581] = new Feature
					{
						_0 = new int[] { 954 },
						_1 = 256,
						_2 = null,
					},
					[120582] = new Feature
					{
						_0 = new int[] { 955 },
						_1 = 256,
						_2 = null,
					},
					[120583] = new Feature
					{
						_0 = new int[] { 956 },
						_1 = 256,
						_2 = null,
					},
					[120584] = new Feature
					{
						_0 = new int[] { 957 },
						_1 = 256,
						_2 = null,
					},
					[120585] = new Feature
					{
						_0 = new int[] { 958 },
						_1 = 256,
						_2 = null,
					},
					[120586] = new Feature
					{
						_0 = new int[] { 959 },
						_1 = 256,
						_2 = null,
					},
					[120587] = new Feature
					{
						_0 = new int[] { 960 },
						_1 = 256,
						_2 = null,
					},
					[120588] = new Feature
					{
						_0 = new int[] { 961 },
						_1 = 256,
						_2 = null,
					},
					[120589] = new Feature
					{
						_0 = new int[] { 962 },
						_1 = 256,
						_2 = null,
					},
					[120590] = new Feature
					{
						_0 = new int[] { 963 },
						_1 = 256,
						_2 = null,
					},
					[120591] = new Feature
					{
						_0 = new int[] { 964 },
						_1 = 256,
						_2 = null,
					},
					[120592] = new Feature
					{
						_0 = new int[] { 965 },
						_1 = 256,
						_2 = null,
					},
					[120593] = new Feature
					{
						_0 = new int[] { 966 },
						_1 = 256,
						_2 = null,
					},
					[120594] = new Feature
					{
						_0 = new int[] { 967 },
						_1 = 256,
						_2 = null,
					},
					[120595] = new Feature
					{
						_0 = new int[] { 968 },
						_1 = 256,
						_2 = null,
					},
					[120596] = new Feature
					{
						_0 = new int[] { 969 },
						_1 = 256,
						_2 = null,
					},
					[120597] = new Feature
					{
						_0 = new int[] { 8706 },
						_1 = 256,
						_2 = null,
					},
					[120598] = new Feature
					{
						_0 = new int[] { 1013 },
						_1 = 256,
						_2 = null,
					},
					[120599] = new Feature
					{
						_0 = new int[] { 977 },
						_1 = 256,
						_2 = null,
					},
					[120600] = new Feature
					{
						_0 = new int[] { 1008 },
						_1 = 256,
						_2 = null,
					},
					[120601] = new Feature
					{
						_0 = new int[] { 981 },
						_1 = 256,
						_2 = null,
					},
					[120602] = new Feature
					{
						_0 = new int[] { 1009 },
						_1 = 256,
						_2 = null,
					},
					[120603] = new Feature
					{
						_0 = new int[] { 982 },
						_1 = 256,
						_2 = null,
					},
					[120604] = new Feature
					{
						_0 = new int[] { 913 },
						_1 = 256,
						_2 = null,
					},
					[120605] = new Feature
					{
						_0 = new int[] { 914 },
						_1 = 256,
						_2 = null,
					},
					[120606] = new Feature
					{
						_0 = new int[] { 915 },
						_1 = 256,
						_2 = null,
					},
					[120607] = new Feature
					{
						_0 = new int[] { 916 },
						_1 = 256,
						_2 = null,
					},
					[120608] = new Feature
					{
						_0 = new int[] { 917 },
						_1 = 256,
						_2 = null,
					},
					[120609] = new Feature
					{
						_0 = new int[] { 918 },
						_1 = 256,
						_2 = null,
					},
					[120610] = new Feature
					{
						_0 = new int[] { 919 },
						_1 = 256,
						_2 = null,
					},
					[120611] = new Feature
					{
						_0 = new int[] { 920 },
						_1 = 256,
						_2 = null,
					},
					[120612] = new Feature
					{
						_0 = new int[] { 921 },
						_1 = 256,
						_2 = null,
					},
					[120613] = new Feature
					{
						_0 = new int[] { 922 },
						_1 = 256,
						_2 = null,
					},
					[120614] = new Feature
					{
						_0 = new int[] { 923 },
						_1 = 256,
						_2 = null,
					},
					[120615] = new Feature
					{
						_0 = new int[] { 924 },
						_1 = 256,
						_2 = null,
					},
					[120616] = new Feature
					{
						_0 = new int[] { 925 },
						_1 = 256,
						_2 = null,
					},
					[120617] = new Feature
					{
						_0 = new int[] { 926 },
						_1 = 256,
						_2 = null,
					},
					[120618] = new Feature
					{
						_0 = new int[] { 927 },
						_1 = 256,
						_2 = null,
					},
					[120619] = new Feature
					{
						_0 = new int[] { 928 },
						_1 = 256,
						_2 = null,
					},
					[120620] = new Feature
					{
						_0 = new int[] { 929 },
						_1 = 256,
						_2 = null,
					},
					[120621] = new Feature
					{
						_0 = new int[] { 1012 },
						_1 = 256,
						_2 = null,
					},
					[120622] = new Feature
					{
						_0 = new int[] { 931 },
						_1 = 256,
						_2 = null,
					},
					[120623] = new Feature
					{
						_0 = new int[] { 932 },
						_1 = 256,
						_2 = null,
					},
					[120624] = new Feature
					{
						_0 = new int[] { 933 },
						_1 = 256,
						_2 = null,
					},
					[120625] = new Feature
					{
						_0 = new int[] { 934 },
						_1 = 256,
						_2 = null,
					},
					[120626] = new Feature
					{
						_0 = new int[] { 935 },
						_1 = 256,
						_2 = null,
					},
					[120627] = new Feature
					{
						_0 = new int[] { 936 },
						_1 = 256,
						_2 = null,
					},
					[120628] = new Feature
					{
						_0 = new int[] { 937 },
						_1 = 256,
						_2 = null,
					},
					[120629] = new Feature
					{
						_0 = new int[] { 8711 },
						_1 = 256,
						_2 = null,
					},
					[120630] = new Feature
					{
						_0 = new int[] { 945 },
						_1 = 256,
						_2 = null,
					},
					[120631] = new Feature
					{
						_0 = new int[] { 946 },
						_1 = 256,
						_2 = null,
					},
					[120632] = new Feature
					{
						_0 = new int[] { 947 },
						_1 = 256,
						_2 = null,
					},
					[120633] = new Feature
					{
						_0 = new int[] { 948 },
						_1 = 256,
						_2 = null,
					},
					[120634] = new Feature
					{
						_0 = new int[] { 949 },
						_1 = 256,
						_2 = null,
					},
					[120635] = new Feature
					{
						_0 = new int[] { 950 },
						_1 = 256,
						_2 = null,
					},
					[120636] = new Feature
					{
						_0 = new int[] { 951 },
						_1 = 256,
						_2 = null,
					},
					[120637] = new Feature
					{
						_0 = new int[] { 952 },
						_1 = 256,
						_2 = null,
					},
					[120638] = new Feature
					{
						_0 = new int[] { 953 },
						_1 = 256,
						_2 = null,
					},
					[120639] = new Feature
					{
						_0 = new int[] { 954 },
						_1 = 256,
						_2 = null,
					},
					[120640] = new Feature
					{
						_0 = new int[] { 955 },
						_1 = 256,
						_2 = null,
					},
					[120641] = new Feature
					{
						_0 = new int[] { 956 },
						_1 = 256,
						_2 = null,
					},
					[120642] = new Feature
					{
						_0 = new int[] { 957 },
						_1 = 256,
						_2 = null,
					},
					[120643] = new Feature
					{
						_0 = new int[] { 958 },
						_1 = 256,
						_2 = null,
					},
					[120644] = new Feature
					{
						_0 = new int[] { 959 },
						_1 = 256,
						_2 = null,
					},
					[120645] = new Feature
					{
						_0 = new int[] { 960 },
						_1 = 256,
						_2 = null,
					},
					[120646] = new Feature
					{
						_0 = new int[] { 961 },
						_1 = 256,
						_2 = null,
					},
					[120647] = new Feature
					{
						_0 = new int[] { 962 },
						_1 = 256,
						_2 = null,
					},
					[120648] = new Feature
					{
						_0 = new int[] { 963 },
						_1 = 256,
						_2 = null,
					},
					[120649] = new Feature
					{
						_0 = new int[] { 964 },
						_1 = 256,
						_2 = null,
					},
					[120650] = new Feature
					{
						_0 = new int[] { 965 },
						_1 = 256,
						_2 = null,
					},
					[120651] = new Feature
					{
						_0 = new int[] { 966 },
						_1 = 256,
						_2 = null,
					},
					[120652] = new Feature
					{
						_0 = new int[] { 967 },
						_1 = 256,
						_2 = null,
					},
					[120653] = new Feature
					{
						_0 = new int[] { 968 },
						_1 = 256,
						_2 = null,
					},
					[120654] = new Feature
					{
						_0 = new int[] { 969 },
						_1 = 256,
						_2 = null,
					},
					[120655] = new Feature
					{
						_0 = new int[] { 8706 },
						_1 = 256,
						_2 = null,
					},
					[120656] = new Feature
					{
						_0 = new int[] { 1013 },
						_1 = 256,
						_2 = null,
					},
					[120657] = new Feature
					{
						_0 = new int[] { 977 },
						_1 = 256,
						_2 = null,
					},
					[120658] = new Feature
					{
						_0 = new int[] { 1008 },
						_1 = 256,
						_2 = null,
					},
					[120659] = new Feature
					{
						_0 = new int[] { 981 },
						_1 = 256,
						_2 = null,
					},
					[120660] = new Feature
					{
						_0 = new int[] { 1009 },
						_1 = 256,
						_2 = null,
					},
					[120661] = new Feature
					{
						_0 = new int[] { 982 },
						_1 = 256,
						_2 = null,
					},
					[120662] = new Feature
					{
						_0 = new int[] { 913 },
						_1 = 256,
						_2 = null,
					},
					[120663] = new Feature
					{
						_0 = new int[] { 914 },
						_1 = 256,
						_2 = null,
					},
					[120664] = new Feature
					{
						_0 = new int[] { 915 },
						_1 = 256,
						_2 = null,
					},
					[120665] = new Feature
					{
						_0 = new int[] { 916 },
						_1 = 256,
						_2 = null,
					},
					[120666] = new Feature
					{
						_0 = new int[] { 917 },
						_1 = 256,
						_2 = null,
					},
					[120667] = new Feature
					{
						_0 = new int[] { 918 },
						_1 = 256,
						_2 = null,
					},
					[120668] = new Feature
					{
						_0 = new int[] { 919 },
						_1 = 256,
						_2 = null,
					},
					[120669] = new Feature
					{
						_0 = new int[] { 920 },
						_1 = 256,
						_2 = null,
					},
					[120670] = new Feature
					{
						_0 = new int[] { 921 },
						_1 = 256,
						_2 = null,
					},
					[120671] = new Feature
					{
						_0 = new int[] { 922 },
						_1 = 256,
						_2 = null,
					},
					[120672] = new Feature
					{
						_0 = new int[] { 923 },
						_1 = 256,
						_2 = null,
					},
					[120673] = new Feature
					{
						_0 = new int[] { 924 },
						_1 = 256,
						_2 = null,
					},
					[120674] = new Feature
					{
						_0 = new int[] { 925 },
						_1 = 256,
						_2 = null,
					},
					[120675] = new Feature
					{
						_0 = new int[] { 926 },
						_1 = 256,
						_2 = null,
					},
					[120676] = new Feature
					{
						_0 = new int[] { 927 },
						_1 = 256,
						_2 = null,
					},
					[120677] = new Feature
					{
						_0 = new int[] { 928 },
						_1 = 256,
						_2 = null,
					},
					[120678] = new Feature
					{
						_0 = new int[] { 929 },
						_1 = 256,
						_2 = null,
					},
					[120679] = new Feature
					{
						_0 = new int[] { 1012 },
						_1 = 256,
						_2 = null,
					},
					[120680] = new Feature
					{
						_0 = new int[] { 931 },
						_1 = 256,
						_2 = null,
					},
					[120681] = new Feature
					{
						_0 = new int[] { 932 },
						_1 = 256,
						_2 = null,
					},
					[120682] = new Feature
					{
						_0 = new int[] { 933 },
						_1 = 256,
						_2 = null,
					},
					[120683] = new Feature
					{
						_0 = new int[] { 934 },
						_1 = 256,
						_2 = null,
					},
					[120684] = new Feature
					{
						_0 = new int[] { 935 },
						_1 = 256,
						_2 = null,
					},
					[120685] = new Feature
					{
						_0 = new int[] { 936 },
						_1 = 256,
						_2 = null,
					},
					[120686] = new Feature
					{
						_0 = new int[] { 937 },
						_1 = 256,
						_2 = null,
					},
					[120687] = new Feature
					{
						_0 = new int[] { 8711 },
						_1 = 256,
						_2 = null,
					},
					[120688] = new Feature
					{
						_0 = new int[] { 945 },
						_1 = 256,
						_2 = null,
					},
					[120689] = new Feature
					{
						_0 = new int[] { 946 },
						_1 = 256,
						_2 = null,
					},
					[120690] = new Feature
					{
						_0 = new int[] { 947 },
						_1 = 256,
						_2 = null,
					},
					[120691] = new Feature
					{
						_0 = new int[] { 948 },
						_1 = 256,
						_2 = null,
					},
					[120692] = new Feature
					{
						_0 = new int[] { 949 },
						_1 = 256,
						_2 = null,
					},
					[120693] = new Feature
					{
						_0 = new int[] { 950 },
						_1 = 256,
						_2 = null,
					},
					[120694] = new Feature
					{
						_0 = new int[] { 951 },
						_1 = 256,
						_2 = null,
					},
					[120695] = new Feature
					{
						_0 = new int[] { 952 },
						_1 = 256,
						_2 = null,
					},
					[120696] = new Feature
					{
						_0 = new int[] { 953 },
						_1 = 256,
						_2 = null,
					},
					[120697] = new Feature
					{
						_0 = new int[] { 954 },
						_1 = 256,
						_2 = null,
					},
					[120698] = new Feature
					{
						_0 = new int[] { 955 },
						_1 = 256,
						_2 = null,
					},
					[120699] = new Feature
					{
						_0 = new int[] { 956 },
						_1 = 256,
						_2 = null,
					},
					[120700] = new Feature
					{
						_0 = new int[] { 957 },
						_1 = 256,
						_2 = null,
					},
					[120701] = new Feature
					{
						_0 = new int[] { 958 },
						_1 = 256,
						_2 = null,
					},
					[120702] = new Feature
					{
						_0 = new int[] { 959 },
						_1 = 256,
						_2 = null,
					},
					[120703] = new Feature
					{
						_0 = new int[] { 960 },
						_1 = 256,
						_2 = null,
					},
					[120704] = new Feature
					{
						_0 = new int[] { 961 },
						_1 = 256,
						_2 = null,
					},
					[120705] = new Feature
					{
						_0 = new int[] { 962 },
						_1 = 256,
						_2 = null,
					},
					[120706] = new Feature
					{
						_0 = new int[] { 963 },
						_1 = 256,
						_2 = null,
					},
					[120707] = new Feature
					{
						_0 = new int[] { 964 },
						_1 = 256,
						_2 = null,
					},
					[120708] = new Feature
					{
						_0 = new int[] { 965 },
						_1 = 256,
						_2 = null,
					},
					[120709] = new Feature
					{
						_0 = new int[] { 966 },
						_1 = 256,
						_2 = null,
					},
					[120710] = new Feature
					{
						_0 = new int[] { 967 },
						_1 = 256,
						_2 = null,
					},
					[120711] = new Feature
					{
						_0 = new int[] { 968 },
						_1 = 256,
						_2 = null,
					},
					[120712] = new Feature
					{
						_0 = new int[] { 969 },
						_1 = 256,
						_2 = null,
					},
					[120713] = new Feature
					{
						_0 = new int[] { 8706 },
						_1 = 256,
						_2 = null,
					},
					[120714] = new Feature
					{
						_0 = new int[] { 1013 },
						_1 = 256,
						_2 = null,
					},
					[120715] = new Feature
					{
						_0 = new int[] { 977 },
						_1 = 256,
						_2 = null,
					},
					[120716] = new Feature
					{
						_0 = new int[] { 1008 },
						_1 = 256,
						_2 = null,
					},
					[120717] = new Feature
					{
						_0 = new int[] { 981 },
						_1 = 256,
						_2 = null,
					},
					[120718] = new Feature
					{
						_0 = new int[] { 1009 },
						_1 = 256,
						_2 = null,
					},
					[120719] = new Feature
					{
						_0 = new int[] { 982 },
						_1 = 256,
						_2 = null,
					},
					[120720] = new Feature
					{
						_0 = new int[] { 913 },
						_1 = 256,
						_2 = null,
					},
					[120721] = new Feature
					{
						_0 = new int[] { 914 },
						_1 = 256,
						_2 = null,


					},
					[120722] = new Feature
					{
						_0 = new int[] { 915 },
						_1 = 256,
						_2 = null,
					},
					[120723] = new Feature
					{
						_0 = new int[] { 916 },
						_1 = 256,
						_2 = null,
					},
					[120724] = new Feature
					{
						_0 = new int[] { 917 },
						_1 = 256,
						_2 = null,
					},
					[120725] = new Feature
					{
						_0 = new int[] { 918 },
						_1 = 256,
						_2 = null,
					},
					[120726] = new Feature
					{
						_0 = new int[] { 919 },
						_1 = 256,
						_2 = null,
					},
					[120727] = new Feature
					{
						_0 = new int[] { 920 },
						_1 = 256,
						_2 = null,
					},
					[120728] = new Feature
					{
						_0 = new int[] { 921 },
						_1 = 256,
						_2 = null,
					},
					[120729] = new Feature
					{
						_0 = new int[] { 922 },
						_1 = 256,
						_2 = null,
					},
					[120730] = new Feature
					{
						_0 = new int[] { 923 },
						_1 = 256,
						_2 = null,
					},
					[120731] = new Feature
					{
						_0 = new int[] { 924 },
						_1 = 256,
						_2 = null,
					},
					[120732] = new Feature
					{
						_0 = new int[] { 925 },
						_1 = 256,
						_2 = null,
					},
					[120733] = new Feature
					{
						_0 = new int[] { 926 },
						_1 = 256,
						_2 = null,
					},
					[120734] = new Feature
					{
						_0 = new int[] { 927 },
						_1 = 256,
						_2 = null,
					},
					[120735] = new Feature
					{
						_0 = new int[] { 928 },
						_1 = 256,
						_2 = null,
					},
					[120736] = new Feature
					{
						_0 = new int[] { 929 },
						_1 = 256,
						_2 = null,
					},
					[120737] = new Feature
					{
						_0 = new int[] { 1012 },
						_1 = 256,
						_2 = null,
					},
					[120738] = new Feature
					{
						_0 = new int[] { 931 },
						_1 = 256,
						_2 = null,
					},
					[120739] = new Feature
					{
						_0 = new int[] { 932 },
						_1 = 256,
						_2 = null,
					},
					[120740] = new Feature
					{
						_0 = new int[] { 933 },
						_1 = 256,
						_2 = null,
					},
					[120741] = new Feature
					{
						_0 = new int[] { 934 },
						_1 = 256,
						_2 = null,
					},
					[120742] = new Feature
					{
						_0 = new int[] { 935 },
						_1 = 256,
						_2 = null,
					},
					[120743] = new Feature
					{
						_0 = new int[] { 936 },
						_1 = 256,
						_2 = null,
					},
					[120744] = new Feature
					{
						_0 = new int[] { 937 },
						_1 = 256,
						_2 = null,
					},
					[120745] = new Feature
					{
						_0 = new int[] { 8711 },
						_1 = 256,
						_2 = null,
					},
					[120746] = new Feature
					{
						_0 = new int[] { 945 },
						_1 = 256,
						_2 = null,
					},
					[120747] = new Feature
					{
						_0 = new int[] { 946 },
						_1 = 256,
						_2 = null,
					},
					[120748] = new Feature
					{
						_0 = new int[] { 947 },
						_1 = 256,
						_2 = null,
					},
					[120749] = new Feature
					{
						_0 = new int[] { 948 },
						_1 = 256,
						_2 = null,
					},
					[120750] = new Feature
					{
						_0 = new int[] { 949 },
						_1 = 256,
						_2 = null,
					},
					[120751] = new Feature
					{
						_0 = new int[] { 950 },
						_1 = 256,
						_2 = null,
					},
					[120752] = new Feature
					{
						_0 = new int[] { 951 },
						_1 = 256,
						_2 = null,
					},
					[120753] = new Feature
					{
						_0 = new int[] { 952 },
						_1 = 256,
						_2 = null,
					},
					[120754] = new Feature
					{
						_0 = new int[] { 953 },
						_1 = 256,
						_2 = null,
					},
					[120755] = new Feature
					{
						_0 = new int[] { 954 },
						_1 = 256,
						_2 = null,
					},
					[120756] = new Feature
					{
						_0 = new int[] { 955 },
						_1 = 256,
						_2 = null,
					},
					[120757] = new Feature
					{
						_0 = new int[] { 956 },
						_1 = 256,
						_2 = null,
					},
					[120758] = new Feature
					{
						_0 = new int[] { 957 },
						_1 = 256,
						_2 = null,
					},
					[120759] = new Feature
					{
						_0 = new int[] { 958 },
						_1 = 256,
						_2 = null,
					},
					[120760] = new Feature
					{
						_0 = new int[] { 959 },
						_1 = 256,
						_2 = null,
					},
					[120761] = new Feature
					{
						_0 = new int[] { 960 },
						_1 = 256,
						_2 = null,
					},
					[120762] = new Feature
					{
						_0 = new int[] { 961 },
						_1 = 256,
						_2 = null,
					},
					[120763] = new Feature
					{
						_0 = new int[] { 962 },
						_1 = 256,
						_2 = null,
					},
					[120764] = new Feature
					{
						_0 = new int[] { 963 },
						_1 = 256,
						_2 = null,
					},
					[120765] = new Feature
					{
						_0 = new int[] { 964 },
						_1 = 256,
						_2 = null,
					},
					[120766] = new Feature
					{
						_0 = new int[] { 965 },
						_1 = 256,
						_2 = null,
					},
					[120767] = new Feature
					{
						_0 = new int[] { 966 },
						_1 = 256,
						_2 = null,
					},
					[120768] = new Feature
					{
						_0 = new int[] { 967 },
						_1 = 256,
						_2 = null,
					},
					[120769] = new Feature
					{
						_0 = new int[] { 968 },
						_1 = 256,
						_2 = null,
					},
					[120770] = new Feature
					{
						_0 = new int[] { 969 },
						_1 = 256,
						_2 = null,
					},
					[120771] = new Feature
					{
						_0 = new int[] { 8706 },
						_1 = 256,
						_2 = null,
					},
					[120772] = new Feature
					{
						_0 = new int[] { 1013 },
						_1 = 256,
						_2 = null,
					},
					[120773] = new Feature
					{
						_0 = new int[] { 977 },
						_1 = 256,
						_2 = null,
					},
					[120774] = new Feature
					{
						_0 = new int[] { 1008 },
						_1 = 256,
						_2 = null,
					},
					[120775] = new Feature
					{
						_0 = new int[] { 981 },
						_1 = 256,
						_2 = null,
					},
					[120776] = new Feature
					{
						_0 = new int[] { 1009 },
						_1 = 256,
						_2 = null,
					},
					[120777] = new Feature
					{
						_0 = new int[] { 982 },
						_1 = 256,
						_2 = null,
					},
					[120778] = new Feature
					{
						_0 = new int[] { 988 },
						_1 = 256,
						_2 = null,
					},
					[120779] = new Feature
					{
						_0 = new int[] { 989 },
						_1 = 256,
						_2 = null,
					},
					[120782] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
					[120783] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[120784] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[120785] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[120786] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[120787] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[120788] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[120789] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[120790] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[120791] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
					[120792] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
					[120793] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[120794] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[120795] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[120796] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[120797] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[120798] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[120799] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[120800] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[120801] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
					[120802] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
					[120803] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[120804] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[120805] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[120806] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[120807] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[120808] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[120809] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[120810] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[120811] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
					[120812] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
					[120813] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[120814] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[120815] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[120816] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[120817] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[120818] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[120819] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[120820] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[120821] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
					[120822] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
					[120823] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[120824] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[120825] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[120826] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[120827] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[120828] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[120829] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[120830] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[120831] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
				},
				[59392] = new Dictionary<int, Feature>
				{
					[125136] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[125137] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[125138] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[125139] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[125140] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[125141] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[125142] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
				},
				[60928] = new Dictionary<int, Feature>
				{
					[126464] = new Feature
					{
						_0 = new int[] { 1575 },
						_1 = 256,
						_2 = null,
					},
					[126465] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[126466] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[126467] = new Feature
					{
						_0 = new int[] { 1583 },
						_1 = 256,
						_2 = null,
					},
					[126469] = new Feature
					{
						_0 = new int[] { 1608 },
						_1 = 256,
						_2 = null,
					},
					[126470] = new Feature
					{
						_0 = new int[] { 1586 },
						_1 = 256,
						_2 = null,
					},
					[126471] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[126472] = new Feature
					{
						_0 = new int[] { 1591 },
						_1 = 256,
						_2 = null,
					},
					[126473] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[126474] = new Feature
					{
						_0 = new int[] { 1603 },
						_1 = 256,
						_2 = null,
					},
					[126475] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[126476] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[126477] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[126478] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[126479] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[126480] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[126481] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[126482] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[126483] = new Feature
					{
						_0 = new int[] { 1585 },
						_1 = 256,
						_2 = null,
					},
					[126484] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[126485] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[126486] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[126487] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[126488] = new Feature
					{
						_0 = new int[] { 1584 },
						_1 = 256,
						_2 = null,
					},
					[126489] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[126490] = new Feature
					{
						_0 = new int[] { 1592 },
						_1 = 256,
						_2 = null,
					},
					[126491] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[126492] = new Feature
					{
						_0 = new int[] { 1646 },
						_1 = 256,
						_2 = null,
					},
					[126493] = new Feature
					{
						_0 = new int[] { 1722 },
						_1 = 256,
						_2 = null,
					},
					[126494] = new Feature
					{
						_0 = new int[] { 1697 },
						_1 = 256,
						_2 = null,
					},
					[126495] = new Feature
					{
						_0 = new int[] { 1647 },
						_1 = 256,
						_2 = null,
					},
					[126497] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[126498] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[126500] = new Feature
					{
						_0 = new int[] { 1607 },
						_1 = 256,
						_2 = null,
					},
					[126503] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[126505] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[126506] = new Feature
					{
						_0 = new int[] { 1603 },
						_1 = 256,
						_2 = null,
					},
					[126507] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[126508] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[126509] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[126510] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[126511] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[126512] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[126513] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[126514] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[126516] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[126517] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[126518] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[126519] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[126521] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[126523] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[126530] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[126535] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[126537] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[126539] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[126541] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[126542] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[126543] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[126545] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[126546] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[126548] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[126551] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[126553] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[126555] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[126557] = new Feature
					{
						_0 = new int[] { 1722 },
						_1 = 256,
						_2 = null,
					},
					[126559] = new Feature
					{
						_0 = new int[] { 1647 },
						_1 = 256,
						_2 = null,
					},
					[126561] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[126562] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[126564] = new Feature
					{
						_0 = new int[] { 1607 },
						_1 = 256,
						_2 = null,
					},
					[126567] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[126568] = new Feature
					{
						_0 = new int[] { 1591 },
						_1 = 256,
						_2 = null,
					},
					[126569] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[126570] = new Feature
					{
						_0 = new int[] { 1603 },
						_1 = 256,
						_2 = null,
					},
					[126572] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[126573] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[126574] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[126575] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[126576] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[126577] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[126578] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[126580] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[126581] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[126582] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[126583] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[126585] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[126586] = new Feature
					{
						_0 = new int[] { 1592 },
						_1 = 256,
						_2 = null,
					},
					[126587] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[126588] = new Feature
					{
						_0 = new int[] { 1646 },
						_1 = 256,
						_2 = null,
					},
					[126590] = new Feature
					{
						_0 = new int[] { 1697 },
						_1 = 256,
						_2 = null,
					},
					[126592] = new Feature
					{
						_0 = new int[] { 1575 },
						_1 = 256,
						_2 = null,
					},
					[126593] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[126594] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[126595] = new Feature
					{
						_0 = new int[] { 1583 },
						_1 = 256,
						_2 = null,
					},
					[126596] = new Feature
					{
						_0 = new int[] { 1607 },
						_1 = 256,
						_2 = null,
					},
					[126597] = new Feature
					{
						_0 = new int[] { 1608 },
						_1 = 256,
						_2 = null,
					},
					[126598] = new Feature
					{
						_0 = new int[] { 1586 },
						_1 = 256,
						_2 = null,
					},
					[126599] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[126600] = new Feature
					{
						_0 = new int[] { 1591 },
						_1 = 256,
						_2 = null,
					},
					[126601] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[126603] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[126604] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[126605] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[126606] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[126607] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[126608] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[126609] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[126610] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[126611] = new Feature
					{
						_0 = new int[] { 1585 },
						_1 = 256,
						_2 = null,
					},
					[126612] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[126613] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[126614] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[126615] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[126616] = new Feature
					{
						_0 = new int[] { 1584 },
						_1 = 256,
						_2 = null,
					},
					[126617] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[126618] = new Feature
					{
						_0 = new int[] { 1592 },
						_1 = 256,
						_2 = null,
					},
					[126619] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[126625] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[126626] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[126627] = new Feature
					{
						_0 = new int[] { 1583 },
						_1 = 256,
						_2 = null,
					},
					[126629] = new Feature
					{
						_0 = new int[] { 1608 },
						_1 = 256,
						_2 = null,
					},
					[126630] = new Feature
					{
						_0 = new int[] { 1586 },
						_1 = 256,
						_2 = null,
					},
					[126631] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[126632] = new Feature
					{
						_0 = new int[] { 1591 },
						_1 = 256,
						_2 = null,
					},
					[126633] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[126635] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[126636] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[126637] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[126638] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[126639] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[126640] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[126641] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[126642] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[126643] = new Feature
					{
						_0 = new int[] { 1585 },
						_1 = 256,
						_2 = null,
					},
					[126644] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[126645] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[126646] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[126647] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[126648] = new Feature
					{
						_0 = new int[] { 1584 },
						_1 = 256,
						_2 = null,
					},
					[126649] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[126650] = new Feature
					{
						_0 = new int[] { 1592 },
						_1 = 256,
						_2 = null,
					},
					[126651] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
				},
				[61696] = new Dictionary<int, Feature>
				{
					[127232] = new Feature
					{
						_0 = new int[] { 48, 46 },
						_1 = 256,
						_2 = null,
					},
					[127233] = new Feature
					{
						_0 = new int[] { 48, 44 },
						_1 = 256,
						_2 = null,
					},
					[127234] = new Feature
					{
						_0 = new int[] { 49, 44 },
						_1 = 256,
						_2 = null,
					},
					[127235] = new Feature
					{
						_0 = new int[] { 50, 44 },
						_1 = 256,
						_2 = null,
					},
					[127236] = new Feature
					{
						_0 = new int[] { 51, 44 },
						_1 = 256,
						_2 = null,
					},
					[127237] = new Feature
					{
						_0 = new int[] { 52, 44 },
						_1 = 256,
						_2 = null,
					},
					[127238] = new Feature
					{
						_0 = new int[] { 53, 44 },
						_1 = 256,
						_2 = null,
					},
					[127239] = new Feature
					{
						_0 = new int[] { 54, 44 },
						_1 = 256,
						_2 = null,
					},
					[127240] = new Feature
					{
						_0 = new int[] { 55, 44 },
						_1 = 256,
						_2 = null,
					},
					[127241] = new Feature
					{
						_0 = new int[] { 56, 44 },
						_1 = 256,
						_2 = null,
					},
					[127242] = new Feature
					{
						_0 = new int[] { 57, 44 },
						_1 = 256,
						_2 = null,
					},
					[127248] = new Feature
					{
						_0 = new int[] { 40, 65, 41 },
						_1 = 256,
						_2 = null,
					},
					[127249] = new Feature
					{
						_0 = new int[] { 40, 66, 41 },
						_1 = 256,
						_2 = null,
					},
					[127250] = new Feature
					{
						_0 = new int[] { 40, 67, 41 },
						_1 = 256,
						_2 = null,
					},
					[127251] = new Feature
					{
						_0 = new int[] { 40, 68, 41 },
						_1 = 256,
						_2 = null,
					},
					[127252] = new Feature
					{
						_0 = new int[] { 40, 69, 41 },
						_1 = 256,
						_2 = null,
					},
					[127253] = new Feature
					{
						_0 = new int[] { 40, 70, 41 },
						_1 = 256,
						_2 = null,
					},
					[127254] = new Feature
					{
						_0 = new int[] { 40, 71, 41 },
						_1 = 256,
						_2 = null,
					},
					[127255] = new Feature
					{
						_0 = new int[] { 40, 72, 41 },
						_1 = 256,
						_2 = null,
					},
					[127256] = new Feature
					{
						_0 = new int[] { 40, 73, 41 },
						_1 = 256,
						_2 = null,
					},
					[127257] = new Feature
					{
						_0 = new int[] { 40, 74, 41 },
						_1 = 256,
						_2 = null,
					},
					[127258] = new Feature
					{
						_0 = new int[] { 40, 75, 41 },
						_1 = 256,
						_2 = null,
					},
					[127259] = new Feature
					{
						_0 = new int[] { 40, 76, 41 },
						_1 = 256,
						_2 = null,
					},
					[127260] = new Feature
					{
						_0 = new int[] { 40, 77, 41 },
						_1 = 256,
						_2 = null,
					},
					[127261] = new Feature
					{
						_0 = new int[] { 40, 78, 41 },
						_1 = 256,
						_2 = null,
					},
					[127262] = new Feature
					{
						_0 = new int[] { 40, 79, 41 },
						_1 = 256,
						_2 = null,
					},
					[127263] = new Feature
					{
						_0 = new int[] { 40, 80, 41 },
						_1 = 256,
						_2 = null,
					},
					[127264] = new Feature
					{
						_0 = new int[] { 40, 81, 41 },
						_1 = 256,
						_2 = null,
					},
					[127265] = new Feature
					{
						_0 = new int[] { 40, 82, 41 },
						_1 = 256,
						_2 = null,
					},
					[127266] = new Feature
					{
						_0 = new int[] { 40, 83, 41 },
						_1 = 256,
						_2 = null,
					},
					[127267] = new Feature
					{
						_0 = new int[] { 40, 84, 41 },
						_1 = 256,
						_2 = null,
					},
					[127268] = new Feature
					{
						_0 = new int[] { 40, 85, 41 },
						_1 = 256,
						_2 = null,
					},
					[127269] = new Feature
					{
						_0 = new int[] { 40, 86, 41 },
						_1 = 256,
						_2 = null,
					},
					[127270] = new Feature
					{
						_0 = new int[] { 40, 87, 41 },
						_1 = 256,
						_2 = null,
					},
					[127271] = new Feature
					{
						_0 = new int[] { 40, 88, 41 },
						_1 = 256,
						_2 = null,
					},
					[127272] = new Feature
					{
						_0 = new int[] { 40, 89, 41 },
						_1 = 256,
						_2 = null,
					},
					[127273] = new Feature
					{
						_0 = new int[] { 40, 90, 41 },
						_1 = 256,
						_2 = null,
					},
					[127274] = new Feature
					{
						_0 = new int[] { 12308, 83, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127275] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[127276] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[127277] = new Feature
					{
						_0 = new int[] { 67, 68 },
						_1 = 256,
						_2 = null,
					},
					[127278] = new Feature
					{
						_0 = new int[] { 87, 90 },
						_1 = 256,
						_2 = null,
					},
					[127280] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[127281] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[127282] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[127283] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[127284] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[127285] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[127286] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[127287] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[127288] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[127289] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[127290] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[127291] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[127292] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[127293] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[127294] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[127295] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[127296] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[127297] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[127298] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[127299] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[127300] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[127301] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[127302] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[127303] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[127304] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[127305] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[127306] = new Feature
					{
						_0 = new int[] { 72, 86 },
						_1 = 256,
						_2 = null,
					},
					[127307] = new Feature
					{
						_0 = new int[] { 77, 86 },
						_1 = 256,
						_2 = null,
					},
					[127308] = new Feature
					{
						_0 = new int[] { 83, 68 },
						_1 = 256,
						_2 = null,
					},
					[127309] = new Feature
					{
						_0 = new int[] { 83, 83 },
						_1 = 256,
						_2 = null,
					},
					[127310] = new Feature
					{
						_0 = new int[] { 80, 80, 86 },
						_1 = 256,
						_2 = null,
					},
					[127311] = new Feature
					{
						_0 = new int[] { 87, 67 },
						_1 = 256,
						_2 = null,
					},
					[127338] = new Feature
					{
						_0 = new int[] { 77, 67 },
						_1 = 256,
						_2 = null,
					},
					[127339] = new Feature
					{
						_0 = new int[] { 77, 68 },
						_1 = 256,
						_2 = null,
					},
					[127376] = new Feature
					{
						_0 = new int[] { 68, 74 },
						_1 = 256,
						_2 = null,
					},
				},
				[61952] = new Dictionary<int, Feature>
				{
					[127488] = new Feature
					{
						_0 = new int[] { 12411, 12363 },
						_1 = 256,
						_2 = null,
					},
					[127489] = new Feature
					{
						_0 = new int[] { 12467, 12467 },
						_1 = 256,
						_2 = null,
					},
					[127490] = new Feature
					{
						_0 = new int[] { 12469 },
						_1 = 256,
						_2 = null,
					},
					[127504] = new Feature
					{
						_0 = new int[] { 25163 },
						_1 = 256,
						_2 = null,
					},
					[127505] = new Feature
					{
						_0 = new int[] { 23383 },
						_1 = 256,
						_2 = null,
					},
					[127506] = new Feature
					{
						_0 = new int[] { 21452 },
						_1 = 256,
						_2 = null,
					},
					[127507] = new Feature
					{
						_0 = new int[] { 12487 },
						_1 = 256,
						_2 = null,
					},
					[127508] = new Feature
					{
						_0 = new int[] { 20108 },
						_1 = 256,
						_2 = null,
					},
					[127509] = new Feature
					{
						_0 = new int[] { 22810 },
						_1 = 256,
						_2 = null,
					},
					[127510] = new Feature
					{
						_0 = new int[] { 35299 },
						_1 = 256,
						_2 = null,
					},
					[127511] = new Feature
					{
						_0 = new int[] { 22825 },
						_1 = 256,
						_2 = null,
					},
					[127512] = new Feature
					{
						_0 = new int[] { 20132 },
						_1 = 256,
						_2 = null,
					},
					[127513] = new Feature
					{
						_0 = new int[] { 26144 },
						_1 = 256,
						_2 = null,
					},
					[127514] = new Feature
					{
						_0 = new int[] { 28961 },
						_1 = 256,
						_2 = null,
					},
					[127515] = new Feature
					{
						_0 = new int[] { 26009 },
						_1 = 256,
						_2 = null,
					},
					[127516] = new Feature
					{
						_0 = new int[] { 21069 },
						_1 = 256,
						_2 = null,
					},
					[127517] = new Feature
					{
						_0 = new int[] { 24460 },
						_1 = 256,
						_2 = null,
					},
					[127518] = new Feature
					{
						_0 = new int[] { 20877 },
						_1 = 256,
						_2 = null,
					},
					[127519] = new Feature
					{
						_0 = new int[] { 26032 },
						_1 = 256,
						_2 = null,
					},
					[127520] = new Feature
					{
						_0 = new int[] { 21021 },
						_1 = 256,
						_2 = null,
					},
					[127521] = new Feature
					{
						_0 = new int[] { 32066 },
						_1 = 256,
						_2 = null,
					},
					[127522] = new Feature
					{
						_0 = new int[] { 29983 },
						_1 = 256,
						_2 = null,
					},
					[127523] = new Feature
					{
						_0 = new int[] { 36009 },
						_1 = 256,
						_2 = null,
					},
					[127524] = new Feature
					{
						_0 = new int[] { 22768 },
						_1 = 256,
						_2 = null,
					},
					[127525] = new Feature
					{
						_0 = new int[] { 21561 },
						_1 = 256,
						_2 = null,
					},
					[127526] = new Feature
					{
						_0 = new int[] { 28436 },
						_1 = 256,
						_2 = null,
					},
					[127527] = new Feature
					{
						_0 = new int[] { 25237 },
						_1 = 256,
						_2 = null,
					},
					[127528] = new Feature
					{
						_0 = new int[] { 25429 },
						_1 = 256,
						_2 = null,
					},
					[127529] = new Feature
					{
						_0 = new int[] { 19968 },
						_1 = 256,
						_2 = null,
					},
					[127530] = new Feature
					{
						_0 = new int[] { 19977 },
						_1 = 256,
						_2 = null,
					},
					[127531] = new Feature
					{
						_0 = new int[] { 36938 },
						_1 = 256,
						_2 = null,
					},
					[127532] = new Feature
					{
						_0 = new int[] { 24038 },
						_1 = 256,
						_2 = null,
					},
					[127533] = new Feature
					{
						_0 = new int[] { 20013 },
						_1 = 256,
						_2 = null,
					},
					[127534] = new Feature
					{
						_0 = new int[] { 21491 },
						_1 = 256,
						_2 = null,
					},
					[127535] = new Feature
					{
						_0 = new int[] { 25351 },
						_1 = 256,
						_2 = null,
					},
					[127536] = new Feature
					{
						_0 = new int[] { 36208 },
						_1 = 256,
						_2 = null,
					},
					[127537] = new Feature
					{
						_0 = new int[] { 25171 },
						_1 = 256,
						_2 = null,
					},
					[127538] = new Feature
					{
						_0 = new int[] { 31105 },
						_1 = 256,
						_2 = null,
					},
					[127539] = new Feature
					{
						_0 = new int[] { 31354 },
						_1 = 256,
						_2 = null,
					},
					[127540] = new Feature
					{
						_0 = new int[] { 21512 },
						_1 = 256,
						_2 = null,
					},
					[127541] = new Feature
					{
						_0 = new int[] { 28288 },
						_1 = 256,
						_2 = null,
					},
					[127542] = new Feature
					{
						_0 = new int[] { 26377 },
						_1 = 256,
						_2 = null,
					},
					[127543] = new Feature
					{
						_0 = new int[] { 26376 },
						_1 = 256,
						_2 = null,
					},
					[127544] = new Feature
					{
						_0 = new int[] { 30003 },
						_1 = 256,
						_2 = null,
					},
					[127545] = new Feature
					{
						_0 = new int[] { 21106 },
						_1 = 256,
						_2 = null,
					},
					[127546] = new Feature
					{
						_0 = new int[] { 21942 },
						_1 = 256,
						_2 = null,
					},
					[127552] = new Feature
					{
						_0 = new int[] { 12308, 26412, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127553] = new Feature
					{
						_0 = new int[] { 12308, 19977, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127554] = new Feature
					{
						_0 = new int[] { 12308, 20108, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127555] = new Feature
					{
						_0 = new int[] { 12308, 23433, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127556] = new Feature
					{
						_0 = new int[] { 12308, 28857, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127557] = new Feature
					{
						_0 = new int[] { 12308, 25171, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127558] = new Feature
					{
						_0 = new int[] { 12308, 30423, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127559] = new Feature
					{
						_0 = new int[] { 12308, 21213, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127560] = new Feature
					{
						_0 = new int[] { 12308, 25943, 12309 },
						_1 = 256,
						_2 = null,
					},
					[127568] = new Feature
					{
						_0 = new int[] { 24471 },
						_1 = 256,
						_2 = null,
					},
					[127569] = new Feature
					{
						_0 = new int[] { 21487 },
						_1 = 256,
						_2 = null,
					},
				},
				[63488] = new Dictionary<int, Feature>
				{
					[194560] = new Feature
					{
						_0 = new int[] { 20029 },
						_1 = null,
						_2 = null,
					},
					[194561] = new Feature
					{
						_0 = new int[] { 20024 },
						_1 = null,
						_2 = null,
					},
					[194562] = new Feature
					{
						_0 = new int[] { 20033 },
						_1 = null,
						_2 = null,
					},
					[194563] = new Feature
					{
						_0 = new int[] { 131362 },
						_1 = null,
						_2 = null,
					},
					[194564] = new Feature
					{
						_0 = new int[] { 20320 },
						_1 = null,
						_2 = null,
					},
					[194565] = new Feature
					{
						_0 = new int[] { 20398 },
						_1 = null,
						_2 = null,
					},
					[194566] = new Feature
					{
						_0 = new int[] { 20411 },
						_1 = null,
						_2 = null,
					},
					[194567] = new Feature
					{
						_0 = new int[] { 20482 },
						_1 = null,
						_2 = null,
					},
					[194568] = new Feature
					{
						_0 = new int[] { 20602 },
						_1 = null,
						_2 = null,
					},
					[194569] = new Feature
					{
						_0 = new int[] { 20633 },
						_1 = null,
						_2 = null,
					},
					[194570] = new Feature
					{
						_0 = new int[] { 20711 },
						_1 = null,
						_2 = null,
					},
					[194571] = new Feature
					{
						_0 = new int[] { 20687 },
						_1 = null,
						_2 = null,
					},
					[194572] = new Feature
					{
						_0 = new int[] { 13470 },
						_1 = null,
						_2 = null,
					},
					[194573] = new Feature
					{
						_0 = new int[] { 132666 },
						_1 = null,
						_2 = null,
					},
					[194574] = new Feature
					{
						_0 = new int[] { 20813 },
						_1 = null,
						_2 = null,
					},
					[194575] = new Feature
					{
						_0 = new int[] { 20820 },
						_1 = null,
						_2 = null,
					},
					[194576] = new Feature
					{
						_0 = new int[] { 20836 },
						_1 = null,
						_2 = null,
					},
					[194577] = new Feature
					{
						_0 = new int[] { 20855 },
						_1 = null,
						_2 = null,
					},
					[194578] = new Feature
					{
						_0 = new int[] { 132380 },
						_1 = null,
						_2 = null,
					},
					[194579] = new Feature
					{
						_0 = new int[] { 13497 },
						_1 = null,
						_2 = null,
					},
					[194580] = new Feature
					{
						_0 = new int[] { 20839 },
						_1 = null,
						_2 = null,
					},
					[194581] = new Feature
					{
						_0 = new int[] { 20877 },
						_1 = null,
						_2 = null,
					},
					[194582] = new Feature
					{
						_0 = new int[] { 132427 },
						_1 = null,
						_2 = null,
					},
					[194583] = new Feature
					{
						_0 = new int[] { 20887 },
						_1 = null,
						_2 = null,
					},
					[194584] = new Feature
					{
						_0 = new int[] { 20900 },
						_1 = null,
						_2 = null,
					},
					[194585] = new Feature
					{
						_0 = new int[] { 20172 },
						_1 = null,
						_2 = null,
					},
					[194586] = new Feature
					{
						_0 = new int[] { 20908 },
						_1 = null,
						_2 = null,
					},
					[194587] = new Feature
					{
						_0 = new int[] { 20917 },
						_1 = null,
						_2 = null,
					},
					[194588] = new Feature
					{
						_0 = new int[] { 168415 },
						_1 = null,
						_2 = null,
					},
					[194589] = new Feature
					{
						_0 = new int[] { 20981 },
						_1 = null,
						_2 = null,
					},
					[194590] = new Feature
					{
						_0 = new int[] { 20995 },
						_1 = null,
						_2 = null,
					},
					[194591] = new Feature
					{
						_0 = new int[] { 13535 },
						_1 = null,
						_2 = null,
					},
					[194592] = new Feature
					{
						_0 = new int[] { 21051 },
						_1 = null,
						_2 = null,
					},
					[194593] = new Feature
					{
						_0 = new int[] { 21062 },
						_1 = null,
						_2 = null,
					},
					[194594] = new Feature
					{
						_0 = new int[] { 21106 },
						_1 = null,
						_2 = null,
					},
					[194595] = new Feature
					{
						_0 = new int[] { 21111 },
						_1 = null,
						_2 = null,
					},
					[194596] = new Feature
					{
						_0 = new int[] { 13589 },
						_1 = null,
						_2 = null,
					},
					[194597] = new Feature
					{
						_0 = new int[] { 21191 },
						_1 = null,
						_2 = null,
					},
					[194598] = new Feature
					{
						_0 = new int[] { 21193 },
						_1 = null,
						_2 = null,
					},
					[194599] = new Feature
					{
						_0 = new int[] { 21220 },
						_1 = null,
						_2 = null,
					},
					[194600] = new Feature
					{
						_0 = new int[] { 21242 },
						_1 = null,
						_2 = null,
					},
					[194601] = new Feature
					{
						_0 = new int[] { 21253 },
						_1 = null,
						_2 = null,
					},
					[194602] = new Feature
					{
						_0 = new int[] { 21254 },
						_1 = null,
						_2 = null,
					},
					[194603] = new Feature
					{
						_0 = new int[] { 21271 },
						_1 = null,
						_2 = null,
					},
					[194604] = new Feature
					{
						_0 = new int[] { 21321 },
						_1 = null,
						_2 = null,
					},
					[194605] = new Feature
					{
						_0 = new int[] { 21329 },
						_1 = null,
						_2 = null,
					},
					[194606] = new Feature
					{
						_0 = new int[] { 21338 },
						_1 = null,
						_2 = null,
					},
					[194607] = new Feature
					{
						_0 = new int[] { 21363 },
						_1 = null,
						_2 = null,
					},
					[194608] = new Feature
					{
						_0 = new int[] { 21373 },
						_1 = null,
						_2 = null,
					},
					[194609] = new Feature
					{
						_0 = new int[] { 21375 },
						_1 = null,
						_2 = null,
					},
					[194610] = new Feature
					{
						_0 = new int[] { 21375 },
						_1 = null,
						_2 = null,
					},
					[194611] = new Feature
					{
						_0 = new int[] { 21375 },
						_1 = null,
						_2 = null,
					},
					[194612] = new Feature
					{
						_0 = new int[] { 133676 },
						_1 = null,
						_2 = null,
					},
					[194613] = new Feature
					{
						_0 = new int[] { 28784 },
						_1 = null,
						_2 = null,
					},
					[194614] = new Feature
					{
						_0 = new int[] { 21450 },
						_1 = null,
						_2 = null,
					},
					[194615] = new Feature
					{
						_0 = new int[] { 21471 },
						_1 = null,
						_2 = null,
					},
					[194616] = new Feature
					{
						_0 = new int[] { 133987 },
						_1 = null,
						_2 = null,
					},
					[194617] = new Feature
					{
						_0 = new int[] { 21483 },
						_1 = null,
						_2 = null,
					},
					[194618] = new Feature
					{
						_0 = new int[] { 21489 },
						_1 = null,
						_2 = null,
					},
					[194619] = new Feature
					{
						_0 = new int[] { 21510 },
						_1 = null,
						_2 = null,
					},
					[194620] = new Feature
					{
						_0 = new int[] { 21662 },
						_1 = null,
						_2 = null,
					},
					[194621] = new Feature
					{
						_0 = new int[] { 21560 },
						_1 = null,
						_2 = null,
					},
					[194622] = new Feature
					{
						_0 = new int[] { 21576 },
						_1 = null,
						_2 = null,
					},
					[194623] = new Feature
					{
						_0 = new int[] { 21608 },
						_1 = null,
						_2 = null,
					},
					[194624] = new Feature
					{
						_0 = new int[] { 21666 },
						_1 = null,
						_2 = null,
					},
					[194625] = new Feature
					{
						_0 = new int[] { 21750 },
						_1 = null,
						_2 = null,
					},
					[194626] = new Feature
					{
						_0 = new int[] { 21776 },
						_1 = null,
						_2 = null,
					},
					[194627] = new Feature
					{
						_0 = new int[] { 21843 },
						_1 = null,
						_2 = null,
					},
					[194628] = new Feature
					{
						_0 = new int[] { 21859 },
						_1 = null,
						_2 = null,
					},
					[194629] = new Feature
					{
						_0 = new int[] { 21892 },
						_1 = null,
						_2 = null,
					},
					[194630] = new Feature
					{
						_0 = new int[] { 21892 },
						_1 = null,
						_2 = null,
					},
					[194631] = new Feature
					{
						_0 = new int[] { 21913 },
						_1 = null,
						_2 = null,
					},
					[194632] = new Feature
					{
						_0 = new int[] { 21931 },
						_1 = null,
						_2 = null,
					},
					[194633] = new Feature
					{
						_0 = new int[] { 21939 },
						_1 = null,
						_2 = null,
					},
					[194634] = new Feature
					{
						_0 = new int[] { 21954 },
						_1 = null,
						_2 = null,
					},
					[194635] = new Feature
					{
						_0 = new int[] { 22294 },
						_1 = null,
						_2 = null,
					},
					[194636] = new Feature
					{
						_0 = new int[] { 22022 },
						_1 = null,
						_2 = null,
					},
					[194637] = new Feature
					{
						_0 = new int[] { 22295 },
						_1 = null,
						_2 = null,
					},
					[194638] = new Feature
					{
						_0 = new int[] { 22097 },
						_1 = null,
						_2 = null,
					},
					[194639] = new Feature
					{
						_0 = new int[] { 22132 },
						_1 = null,
						_2 = null,
					},
					[194640] = new Feature
					{
						_0 = new int[] { 20999 },
						_1 = null,
						_2 = null,
					},
					[194641] = new Feature
					{
						_0 = new int[] { 22766 },
						_1 = null,
						_2 = null,
					},
					[194642] = new Feature
					{
						_0 = new int[] { 22478 },
						_1 = null,
						_2 = null,
					},
					[194643] = new Feature
					{
						_0 = new int[] { 22516 },
						_1 = null,
						_2 = null,
					},
					[194644] = new Feature
					{
						_0 = new int[] { 22541 },
						_1 = null,
						_2 = null,
					},


					[194645] = new Feature
					{
						_0 = new int[] { 22411 },
						_1 = null,
						_2 = null,
					},
					[194646] = new Feature
					{
						_0 = new int[] { 22578 },
						_1 = null,
						_2 = null,
					},
					[194647] = new Feature
					{
						_0 = new int[] { 22577 },
						_1 = null,
						_2 = null,
					},
					[194648] = new Feature
					{
						_0 = new int[] { 22700 },
						_1 = null,
						_2 = null,
					},
					[194649] = new Feature
					{
						_0 = new int[] { 136420 },
						_1 = null,
						_2 = null,
					},
					[194650] = new Feature
					{
						_0 = new int[] { 22770 },
						_1 = null,
						_2 = null,
					},
					[194651] = new Feature
					{
						_0 = new int[] { 22775 },
						_1 = null,
						_2 = null,
					},
					[194652] = new Feature
					{
						_0 = new int[] { 22790 },
						_1 = null,
						_2 = null,
					},
					[194653] = new Feature
					{
						_0 = new int[] { 22810 },
						_1 = null,
						_2 = null,
					},
					[194654] = new Feature
					{
						_0 = new int[] { 22818 },
						_1 = null,
						_2 = null,
					},
					[194655] = new Feature
					{
						_0 = new int[] { 22882 },
						_1 = null,
						_2 = null,
					},
					[194656] = new Feature
					{
						_0 = new int[] { 136872 },
						_1 = null,
						_2 = null,
					},
					[194657] = new Feature
					{
						_0 = new int[] { 136938 },
						_1 = null,
						_2 = null,
					},
					[194658] = new Feature
					{
						_0 = new int[] { 23020 },
						_1 = null,
						_2 = null,
					},
					[194659] = new Feature
					{
						_0 = new int[] { 23067 },
						_1 = null,
						_2 = null,
					},
					[194660] = new Feature
					{
						_0 = new int[] { 23079 },
						_1 = null,
						_2 = null,
					},
					[194661] = new Feature
					{
						_0 = new int[] { 23000 },
						_1 = null,
						_2 = null,
					},
					[194662] = new Feature
					{
						_0 = new int[] { 23142 },
						_1 = null,
						_2 = null,
					},
					[194663] = new Feature
					{
						_0 = new int[] { 14062 },
						_1 = null,
						_2 = null,
					},
					[194664] = new Feature
					{
						_0 = new int[] { 14076 },
						_1 = null,
						_2 = null,
					},
					[194665] = new Feature
					{
						_0 = new int[] { 23304 },
						_1 = null,
						_2 = null,
					},
					[194666] = new Feature
					{
						_0 = new int[] { 23358 },
						_1 = null,
						_2 = null,
					},
					[194667] = new Feature
					{
						_0 = new int[] { 23358 },
						_1 = null,
						_2 = null,
					},
					[194668] = new Feature
					{
						_0 = new int[] { 137672 },
						_1 = null,
						_2 = null,
					},
					[194669] = new Feature
					{
						_0 = new int[] { 23491 },
						_1 = null,
						_2 = null,
					},
					[194670] = new Feature
					{
						_0 = new int[] { 23512 },
						_1 = null,
						_2 = null,
					},
					[194671] = new Feature
					{
						_0 = new int[] { 23527 },
						_1 = null,
						_2 = null,
					},
					[194672] = new Feature
					{
						_0 = new int[] { 23539 },
						_1 = null,
						_2 = null,
					},
					[194673] = new Feature
					{
						_0 = new int[] { 138008 },
						_1 = null,
						_2 = null,
					},
					[194674] = new Feature
					{
						_0 = new int[] { 23551 },
						_1 = null,
						_2 = null,
					},
					[194675] = new Feature
					{
						_0 = new int[] { 23558 },
						_1 = null,
						_2 = null,
					},
					[194676] = new Feature
					{
						_0 = new int[] { 24403 },
						_1 = null,
						_2 = null,
					},
					[194677] = new Feature
					{
						_0 = new int[] { 23586 },
						_1 = null,
						_2 = null,
					},
					[194678] = new Feature
					{
						_0 = new int[] { 14209 },
						_1 = null,
						_2 = null,
					},
					[194679] = new Feature
					{
						_0 = new int[] { 23648 },
						_1 = null,
						_2 = null,
					},
					[194680] = new Feature
					{
						_0 = new int[] { 23662 },
						_1 = null,
						_2 = null,
					},
					[194681] = new Feature
					{
						_0 = new int[] { 23744 },
						_1 = null,
						_2 = null,
					},
					[194682] = new Feature
					{
						_0 = new int[] { 23693 },
						_1 = null,
						_2 = null,
					},
					[194683] = new Feature
					{
						_0 = new int[] { 138724 },
						_1 = null,
						_2 = null,
					},
					[194684] = new Feature
					{
						_0 = new int[] { 23875 },
						_1 = null,
						_2 = null,
					},
					[194685] = new Feature
					{
						_0 = new int[] { 138726 },
						_1 = null,
						_2 = null,
					},
					[194686] = new Feature
					{
						_0 = new int[] { 23918 },
						_1 = null,
						_2 = null,
					},
					[194687] = new Feature
					{
						_0 = new int[] { 23915 },
						_1 = null,
						_2 = null,
					},
					[194688] = new Feature
					{
						_0 = new int[] { 23932 },
						_1 = null,
						_2 = null,
					},
					[194689] = new Feature
					{
						_0 = new int[] { 24033 },
						_1 = null,
						_2 = null,
					},
					[194690] = new Feature
					{
						_0 = new int[] { 24034 },
						_1 = null,
						_2 = null,
					},
					[194691] = new Feature
					{
						_0 = new int[] { 14383 },
						_1 = null,
						_2 = null,
					},
					[194692] = new Feature
					{
						_0 = new int[] { 24061 },
						_1 = null,
						_2 = null,
					},
					[194693] = new Feature
					{
						_0 = new int[] { 24104 },
						_1 = null,
						_2 = null,
					},
					[194694] = new Feature
					{
						_0 = new int[] { 24125 },
						_1 = null,
						_2 = null,
					},
					[194695] = new Feature
					{
						_0 = new int[] { 24169 },
						_1 = null,
						_2 = null,
					},
					[194696] = new Feature
					{
						_0 = new int[] { 14434 },
						_1 = null,
						_2 = null,
					},
					[194697] = new Feature
					{
						_0 = new int[] { 139651 },
						_1 = null,
						_2 = null,
					},
					[194698] = new Feature
					{
						_0 = new int[] { 14460 },
						_1 = null,
						_2 = null,
					},
					[194699] = new Feature
					{
						_0 = new int[] { 24240 },
						_1 = null,
						_2 = null,
					},
					[194700] = new Feature
					{
						_0 = new int[] { 24243 },
						_1 = null,
						_2 = null,
					},
					[194701] = new Feature
					{
						_0 = new int[] { 24246 },
						_1 = null,
						_2 = null,
					},
					[194702] = new Feature
					{
						_0 = new int[] { 24266 },
						_1 = null,
						_2 = null,
					},
					[194703] = new Feature
					{
						_0 = new int[] { 172946 },
						_1 = null,
						_2 = null,
					},
					[194704] = new Feature
					{
						_0 = new int[] { 24318 },
						_1 = null,
						_2 = null,
					},
					[194705] = new Feature
					{
						_0 = new int[] { 140081 },
						_1 = null,
						_2 = null,
					},
					[194706] = new Feature
					{
						_0 = new int[] { 140081 },
						_1 = null,
						_2 = null,
					},
					[194707] = new Feature
					{
						_0 = new int[] { 33281 },
						_1 = null,
						_2 = null,
					},
					[194708] = new Feature
					{
						_0 = new int[] { 24354 },
						_1 = null,
						_2 = null,
					},
					[194709] = new Feature
					{
						_0 = new int[] { 24354 },
						_1 = null,
						_2 = null,
					},
					[194710] = new Feature
					{
						_0 = new int[] { 14535 },
						_1 = null,
						_2 = null,
					},
					[194711] = new Feature
					{
						_0 = new int[] { 144056 },
						_1 = null,
						_2 = null,
					},
					[194712] = new Feature
					{
						_0 = new int[] { 156122 },
						_1 = null,
						_2 = null,
					},
					[194713] = new Feature
					{
						_0 = new int[] { 24418 },
						_1 = null,
						_2 = null,
					},
					[194714] = new Feature
					{
						_0 = new int[] { 24427 },
						_1 = null,
						_2 = null,
					},
					[194715] = new Feature
					{
						_0 = new int[] { 14563 },
						_1 = null,
						_2 = null,
					},
					[194716] = new Feature
					{
						_0 = new int[] { 24474 },
						_1 = null,
						_2 = null,
					},
					[194717] = new Feature
					{
						_0 = new int[] { 24525 },
						_1 = null,
						_2 = null,
					},
					[194718] = new Feature
					{
						_0 = new int[] { 24535 },
						_1 = null,
						_2 = null,
					},
					[194719] = new Feature
					{
						_0 = new int[] { 24569 },
						_1 = null,
						_2 = null,
					},
					[194720] = new Feature
					{
						_0 = new int[] { 24705 },
						_1 = null,
						_2 = null,
					},
					[194721] = new Feature
					{
						_0 = new int[] { 14650 },
						_1 = null,
						_2 = null,
					},
					[194722] = new Feature
					{
						_0 = new int[] { 14620 },
						_1 = null,
						_2 = null,
					},
					[194723] = new Feature
					{
						_0 = new int[] { 24724 },
						_1 = null,
						_2 = null,
					},
					[194724] = new Feature
					{
						_0 = new int[] { 141012 },
						_1 = null,
						_2 = null,
					},
					[194725] = new Feature
					{
						_0 = new int[] { 24775 },
						_1 = null,
						_2 = null,
					},
					[194726] = new Feature
					{
						_0 = new int[] { 24904 },
						_1 = null,
						_2 = null,
					},
					[194727] = new Feature
					{
						_0 = new int[] { 24908 },
						_1 = null,
						_2 = null,
					},
					[194728] = new Feature
					{
						_0 = new int[] { 24910 },
						_1 = null,
						_2 = null,
					},
					[194729] = new Feature
					{
						_0 = new int[] { 24908 },
						_1 = null,
						_2 = null,
					},
					[194730] = new Feature
					{
						_0 = new int[] { 24954 },
						_1 = null,
						_2 = null,
					},
					[194731] = new Feature
					{
						_0 = new int[] { 24974 },
						_1 = null,
						_2 = null,
					},
					[194732] = new Feature
					{
						_0 = new int[] { 25010 },
						_1 = null,
						_2 = null,
					},
					[194733] = new Feature
					{
						_0 = new int[] { 24996 },
						_1 = null,
						_2 = null,
					},
					[194734] = new Feature
					{
						_0 = new int[] { 25007 },
						_1 = null,
						_2 = null,
					},
					[194735] = new Feature
					{
						_0 = new int[] { 25054 },
						_1 = null,
						_2 = null,
					},
					[194736] = new Feature
					{
						_0 = new int[] { 25074 },
						_1 = null,
						_2 = null,
					},
					[194737] = new Feature
					{
						_0 = new int[] { 25078 },
						_1 = null,
						_2 = null,
					},
					[194738] = new Feature
					{
						_0 = new int[] { 25104 },
						_1 = null,
						_2 = null,
					},
					[194739] = new Feature
					{
						_0 = new int[] { 25115 },
						_1 = null,
						_2 = null,
					},
					[194740] = new Feature
					{
						_0 = new int[] { 25181 },
						_1 = null,
						_2 = null,
					},
					[194741] = new Feature
					{
						_0 = new int[] { 25265 },
						_1 = null,
						_2 = null,
					},
					[194742] = new Feature
					{
						_0 = new int[] { 25300 },
						_1 = null,
						_2 = null,
					},
					[194743] = new Feature
					{
						_0 = new int[] { 25424 },
						_1 = null,
						_2 = null,
					},
					[194744] = new Feature
					{
						_0 = new int[] { 142092 },
						_1 = null,
						_2 = null,
					},
					[194745] = new Feature
					{
						_0 = new int[] { 25405 },
						_1 = null,
						_2 = null,
					},
					[194746] = new Feature
					{
						_0 = new int[] { 25340 },
						_1 = null,
						_2 = null,
					},
					[194747] = new Feature
					{
						_0 = new int[] { 25448 },
						_1 = null,
						_2 = null,
					},
					[194748] = new Feature
					{
						_0 = new int[] { 25475 },
						_1 = null,
						_2 = null,
					},
					[194749] = new Feature
					{
						_0 = new int[] { 25572 },
						_1 = null,
						_2 = null,
					},
					[194750] = new Feature
					{
						_0 = new int[] { 142321 },
						_1 = null,
						_2 = null,
					},
					[194751] = new Feature
					{
						_0 = new int[] { 25634 },
						_1 = null,
						_2 = null,
					},
					[194752] = new Feature
					{
						_0 = new int[] { 25541 },
						_1 = null,
						_2 = null,
					},
					[194753] = new Feature
					{
						_0 = new int[] { 25513 },
						_1 = null,
						_2 = null,
					},
					[194754] = new Feature
					{
						_0 = new int[] { 14894 },
						_1 = null,
						_2 = null,
					},
					[194755] = new Feature
					{
						_0 = new int[] { 25705 },
						_1 = null,
						_2 = null,
					},
					[194756] = new Feature
					{
						_0 = new int[] { 25726 },
						_1 = null,
						_2 = null,
					},
					[194757] = new Feature
					{
						_0 = new int[] { 25757 },
						_1 = null,
						_2 = null,
					},
					[194758] = new Feature
					{
						_0 = new int[] { 25719 },
						_1 = null,
						_2 = null,
					},
					[194759] = new Feature
					{
						_0 = new int[] { 14956 },
						_1 = null,
						_2 = null,
					},
					[194760] = new Feature
					{
						_0 = new int[] { 25935 },
						_1 = null,
						_2 = null,
					},
					[194761] = new Feature
					{
						_0 = new int[] { 25964 },
						_1 = null,
						_2 = null,
					},
					[194762] = new Feature
					{
						_0 = new int[] { 143370 },
						_1 = null,
						_2 = null,
					},
					[194763] = new Feature
					{
						_0 = new int[] { 26083 },
						_1 = null,
						_2 = null,
					},
					[194764] = new Feature
					{
						_0 = new int[] { 26360 },
						_1 = null,
						_2 = null,
					},
					[194765] = new Feature
					{
						_0 = new int[] { 26185 },
						_1 = null,
						_2 = null,
					},
					[194766] = new Feature
					{
						_0 = new int[] { 15129 },
						_1 = null,
						_2 = null,
					},
					[194767] = new Feature
					{
						_0 = new int[] { 26257 },
						_1 = null,
						_2 = null,
					},
					[194768] = new Feature
					{
						_0 = new int[] { 15112 },
						_1 = null,
						_2 = null,
					},
					[194769] = new Feature
					{
						_0 = new int[] { 15076 },
						_1 = null,
						_2 = null,
					},
					[194770] = new Feature
					{
						_0 = new int[] { 20882 },
						_1 = null,
						_2 = null,
					},
					[194771] = new Feature
					{
						_0 = new int[] { 20885 },
						_1 = null,
						_2 = null,
					},
					[194772] = new Feature
					{
						_0 = new int[] { 26368 },
						_1 = null,
						_2 = null,
					},
					[194773] = new Feature
					{
						_0 = new int[] { 26268 },
						_1 = null,
						_2 = null,
					},
					[194774] = new Feature
					{
						_0 = new int[] { 32941 },
						_1 = null,
						_2 = null,
					},
					[194775] = new Feature
					{
						_0 = new int[] { 17369 },
						_1 = null,
						_2 = null,
					},
					[194776] = new Feature
					{
						_0 = new int[] { 26391 },
						_1 = null,
						_2 = null,
					},
					[194777] = new Feature
					{
						_0 = new int[] { 26395 },
						_1 = null,
						_2 = null,
					},
					[194778] = new Feature
					{
						_0 = new int[] { 26401 },
						_1 = null,
						_2 = null,
					},
					[194779] = new Feature
					{
						_0 = new int[] { 26462 },
						_1 = null,
						_2 = null,
					},
					[194780] = new Feature
					{
						_0 = new int[] { 26451 },
						_1 = null,
						_2 = null,
					},
					[194781] = new Feature
					{
						_0 = new int[] { 144323 },
						_1 = null,
						_2 = null,
					},
					[194782] = new Feature
					{
						_0 = new int[] { 15177 },
						_1 = null,
						_2 = null,
					},
					[194783] = new Feature
					{
						_0 = new int[] { 26618 },
						_1 = null,
						_2 = null,
					},
					[194784] = new Feature
					{
						_0 = new int[] { 26501 },
						_1 = null,
						_2 = null,
					},
					[194785] = new Feature
					{
						_0 = new int[] { 26706 },
						_1 = null,
						_2 = null,
					},
					[194786] = new Feature
					{
						_0 = new int[] { 26757 },
						_1 = null,
						_2 = null,
					},
					[194787] = new Feature
					{
						_0 = new int[] { 144493 },
						_1 = null,
						_2 = null,
					},
					[194788] = new Feature
					{
						_0 = new int[] { 26766 },
						_1 = null,
						_2 = null,
					},
					[194789] = new Feature
					{
						_0 = new int[] { 26655 },
						_1 = null,
						_2 = null,
					},
					[194790] = new Feature
					{
						_0 = new int[] { 26900 },
						_1 = null,
						_2 = null,
					},
					[194791] = new Feature
					{
						_0 = new int[] { 15261 },
						_1 = null,
						_2 = null,
					},
					[194792] = new Feature
					{
						_0 = new int[] { 26946 },
						_1 = null,
						_2 = null,
					},
					[194793] = new Feature
					{
						_0 = new int[] { 27043 },
						_1 = null,
						_2 = null,
					},
					[194794] = new Feature
					{
						_0 = new int[] { 27114 },
						_1 = null,
						_2 = null,
					},
					[194795] = new Feature
					{
						_0 = new int[] { 27304 },
						_1 = null,
						_2 = null,
					},
					[194796] = new Feature
					{
						_0 = new int[] { 145059 },
						_1 = null,
						_2 = null,
					},
					[194797] = new Feature
					{
						_0 = new int[] { 27355 },
						_1 = null,
						_2 = null,
					},
					[194798] = new Feature
					{
						_0 = new int[] { 15384 },
						_1 = null,
						_2 = null,
					},
					[194799] = new Feature
					{
						_0 = new int[] { 27425 },
						_1 = null,
						_2 = null,
					},
					[194800] = new Feature
					{
						_0 = new int[] { 145575 },
						_1 = null,
						_2 = null,
					},
					[194801] = new Feature
					{
						_0 = new int[] { 27476 },
						_1 = null,
						_2 = null,
					},
					[194802] = new Feature
					{
						_0 = new int[] { 15438 },
						_1 = null,
						_2 = null,
					},
					[194803] = new Feature
					{
						_0 = new int[] { 27506 },
						_1 = null,
						_2 = null,
					},
					[194804] = new Feature
					{
						_0 = new int[] { 27551 },
						_1 = null,
						_2 = null,
					},
					[194805] = new Feature
					{
						_0 = new int[] { 27578 },
						_1 = null,
						_2 = null,
					},
					[194806] = new Feature
					{
						_0 = new int[] { 27579 },
						_1 = null,
						_2 = null,
					},
					[194807] = new Feature
					{
						_0 = new int[] { 146061 },
						_1 = null,
						_2 = null,
					},
					[194808] = new Feature
					{
						_0 = new int[] { 138507 },
						_1 = null,
						_2 = null,
					},
					[194809] = new Feature
					{
						_0 = new int[] { 146170 },
						_1 = null,
						_2 = null,
					},
					[194810] = new Feature
					{
						_0 = new int[] { 27726 },
						_1 = null,
						_2 = null,
					},
					[194811] = new Feature
					{
						_0 = new int[] { 146620 },
						_1 = null,
						_2 = null,
					},
					[194812] = new Feature
					{
						_0 = new int[] { 27839 },
						_1 = null,
						_2 = null,
					},
					[194813] = new Feature
					{
						_0 = new int[] { 27853 },
						_1 = null,
						_2 = null,
					},
					[194814] = new Feature
					{
						_0 = new int[] { 27751 },
						_1 = null,
						_2 = null,
					},
					[194815] = new Feature
					{
						_0 = new int[] { 27926 },
						_1 = null,
						_2 = null,
					},
				},
				[63744] = new Dictionary<int, Feature>
				{
					[63744] = new Feature
					{
						_0 = new int[] { 35912 },
						_1 = null,
						_2 = null,
					},
					[63745] = new Feature
					{
						_0 = new int[] { 26356 },
						_1 = null,
						_2 = null,
					},
					[63746] = new Feature
					{
						_0 = new int[] { 36554 },
						_1 = null,
						_2 = null,
					},
					[63747] = new Feature
					{
						_0 = new int[] { 36040 },
						_1 = null,
						_2 = null,
					},
					[63748] = new Feature
					{
						_0 = new int[] { 28369 },
						_1 = null,
						_2 = null,
					},
					[63749] = new Feature
					{
						_0 = new int[] { 20018 },
						_1 = null,
						_2 = null,
					},
					[63750] = new Feature
					{
						_0 = new int[] { 21477 },
						_1 = null,
						_2 = null,
					},
					[63751] = new Feature
					{
						_0 = new int[] { 40860 },
						_1 = null,
						_2 = null,
					},
					[63752] = new Feature
					{
						_0 = new int[] { 40860 },
						_1 = null,
						_2 = null,
					},
					[63753] = new Feature
					{
						_0 = new int[] { 22865 },
						_1 = null,
						_2 = null,
					},
					[63754] = new Feature
					{
						_0 = new int[] { 37329 },
						_1 = null,
						_2 = null,
					},
					[63755] = new Feature
					{
						_0 = new int[] { 21895 },
						_1 = null,
						_2 = null,
					},
					[63756] = new Feature
					{
						_0 = new int[] { 22856 },
						_1 = null,
						_2 = null,
					},
					[63757] = new Feature
					{
						_0 = new int[] { 25078 },
						_1 = null,
						_2 = null,
					},
					[63758] = new Feature
					{
						_0 = new int[] { 30313 },
						_1 = null,
						_2 = null,
					},
					[63759] = new Feature
					{
						_0 = new int[] { 32645 },
						_1 = null,
						_2 = null,
					},
					[63760] = new Feature
					{
						_0 = new int[] { 34367 },
						_1 = null,
						_2 = null,
					},
					[63761] = new Feature
					{
						_0 = new int[] { 34746 },
						_1 = null,
						_2 = null,
					},
					[63762] = new Feature
					{
						_0 = new int[] { 35064 },
						_1 = null,
						_2 = null,
					},
					[63763] = new Feature
					{
						_0 = new int[] { 37007 },
						_1 = null,
						_2 = null,
					},
					[63764] = new Feature
					{
						_0 = new int[] { 27138 },
						_1 = null,
						_2 = null,
					},
					[63765] = new Feature
					{
						_0 = new int[] { 27931 },
						_1 = null,
						_2 = null,
					},
					[63766] = new Feature
					{
						_0 = new int[] { 28889 },
						_1 = null,
						_2 = null,
					},
					[63767] = new Feature
					{
						_0 = new int[] { 29662 },
						_1 = null,
						_2 = null,
					},
					[63768] = new Feature
					{
						_0 = new int[] { 33853 },
						_1 = null,
						_2 = null,
					},
					[63769] = new Feature
					{
						_0 = new int[] { 37226 },
						_1 = null,
						_2 = null,
					},
					[63770] = new Feature
					{
						_0 = new int[] { 39409 },
						_1 = null,
						_2 = null,
					},
					[63771] = new Feature
					{
						_0 = new int[] { 20098 },
						_1 = null,
						_2 = null,
					},
					[63772] = new Feature
					{
						_0 = new int[] { 21365 },
						_1 = null,
						_2 = null,
					},
					[63773] = new Feature
					{
						_0 = new int[] { 27396 },
						_1 = null,
						_2 = null,
					},
					[63774] = new Feature
					{
						_0 = new int[] { 29211 },
						_1 = null,
						_2 = null,
					},
					[63775] = new Feature
					{
						_0 = new int[] { 34349 },
						_1 = null,
						_2 = null,
					},
					[63776] = new Feature
					{
						_0 = new int[] { 40478 },
						_1 = null,
						_2 = null,
					},
					[63777] = new Feature
					{
						_0 = new int[] { 23888 },
						_1 = null,
						_2 = null,
					},
					[63778] = new Feature
					{
						_0 = new int[] { 28651 },
						_1 = null,
						_2 = null,
					},
					[63779] = new Feature
					{
						_0 = new int[] { 34253 },
						_1 = null,
						_2 = null,
					},
					[63780] = new Feature
					{
						_0 = new int[] { 35172 },
						_1 = null,
						_2 = null,
					},
					[63781] = new Feature
					{
						_0 = new int[] { 25289 },
						_1 = null,
						_2 = null,
					},
					[63782] = new Feature
					{
						_0 = new int[] { 33240 },
						_1 = null,
						_2 = null,
					},
					[63783] = new Feature
					{
						_0 = new int[] { 34847 },
						_1 = null,
						_2 = null,
					},
					[63784] = new Feature
					{
						_0 = new int[] { 24266 },
						_1 = null,
						_2 = null,
					},
					[63785] = new Feature
					{
						_0 = new int[] { 26391 },
						_1 = null,
						_2 = null,
					},
					[63786] = new Feature
					{
						_0 = new int[] { 28010 },
						_1 = null,
						_2 = null,
					},
					[63787] = new Feature
					{
						_0 = new int[] { 29436 },
						_1 = null,
						_2 = null,
					},
					[63788] = new Feature
					{
						_0 = new int[] { 37070 },
						_1 = null,
						_2 = null,
					},
					[63789] = new Feature
					{
						_0 = new int[] { 20358 },
						_1 = null,
						_2 = null,
					},
					[63790] = new Feature
					{
						_0 = new int[] { 20919 },
						_1 = null,
						_2 = null,
					},
					[63791] = new Feature
					{
						_0 = new int[] { 21214 },
						_1 = null,
						_2 = null,
					},
					[63792] = new Feature
					{
						_0 = new int[] { 25796 },
						_1 = null,
						_2 = null,
					},
					[63793] = new Feature
					{
						_0 = new int[] { 27347 },
						_1 = null,
						_2 = null,
					},
					[63794] = new Feature
					{
						_0 = new int[] { 29200 },
						_1 = null,
						_2 = null,
					},
					[63795] = new Feature
					{
						_0 = new int[] { 30439 },
						_1 = null,
						_2 = null,
					},
					[63796] = new Feature
					{
						_0 = new int[] { 32769 },
						_1 = null,
						_2 = null,
					},
					[63797] = new Feature
					{
						_0 = new int[] { 34310 },
						_1 = null,
						_2 = null,
					},
					[63798] = new Feature
					{
						_0 = new int[] { 34396 },
						_1 = null,
						_2 = null,
					},
					[63799] = new Feature
					{
						_0 = new int[] { 36335 },
						_1 = null,
						_2 = null,
					},
					[63800] = new Feature
					{
						_0 = new int[] { 38706 },
						_1 = null,
						_2 = null,
					},
					[63801] = new Feature
					{
						_0 = new int[] { 39791 },
						_1 = null,
						_2 = null,
					},
					[63802] = new Feature
					{
						_0 = new int[] { 40442 },
						_1 = null,
						_2 = null,
					},
					[63803] = new Feature
					{
						_0 = new int[] { 30860 },
						_1 = null,
						_2 = null,
					},
					[63804] = new Feature
					{
						_0 = new int[] { 31103 },
						_1 = null,
						_2 = null,
					},
					[63805] = new Feature
					{
						_0 = new int[] { 32160 },
						_1 = null,
						_2 = null,
					},
					[63806] = new Feature
					{
						_0 = new int[] { 33737 },
						_1 = null,
						_2 = null,
					},
					[63807] = new Feature
					{
						_0 = new int[] { 37636 },
						_1 = null,
						_2 = null,
					},
					[63808] = new Feature
					{
						_0 = new int[] { 40575 },
						_1 = null,
						_2 = null,
					},
					[63809] = new Feature
					{
						_0 = new int[] { 35542 },
						_1 = null,
						_2 = null,
					},
					[63810] = new Feature
					{
						_0 = new int[] { 22751 },
						_1 = null,
						_2 = null,
					},
					[63811] = new Feature
					{
						_0 = new int[] { 24324 },
						_1 = null,
						_2 = null,
					},
					[63812] = new Feature
					{
						_0 = new int[] { 31840 },
						_1 = null,
						_2 = null,
					},
					[63813] = new Feature
					{
						_0 = new int[] { 32894 },
						_1 = null,
						_2 = null,
					},
					[63814] = new Feature
					{
						_0 = new int[] { 29282 },
						_1 = null,
						_2 = null,
					},
					[63815] = new Feature
					{
						_0 = new int[] { 30922 },
						_1 = null,
						_2 = null,
					},
					[63816] = new Feature
					{
						_0 = new int[] { 36034 },
						_1 = null,
						_2 = null,
					},
					[63817] = new Feature
					{
						_0 = new int[] { 38647 },
						_1 = null,
						_2 = null,
					},
					[63818] = new Feature
					{
						_0 = new int[] { 22744 },
						_1 = null,
						_2 = null,
					},
					[63819] = new Feature
					{
						_0 = new int[] { 23650 },
						_1 = null,
						_2 = null,
					},
					[63820] = new Feature
					{
						_0 = new int[] { 27155 },
						_1 = null,
						_2 = null,
					},
					[63821] = new Feature
					{
						_0 = new int[] { 28122 },
						_1 = null,
						_2 = null,
					},
					[63822] = new Feature
					{
						_0 = new int[] { 28431 },
						_1 = null,
						_2 = null,
					},
					[63823] = new Feature
					{
						_0 = new int[] { 32047 },
						_1 = null,
						_2 = null,
					},
					[63824] = new Feature
					{
						_0 = new int[] { 32311 },
						_1 = null,
						_2 = null,
					},
					[63825] = new Feature
					{
						_0 = new int[] { 38475 },
						_1 = null,
						_2 = null,
					},
					[63826] = new Feature
					{
						_0 = new int[] { 21202 },
						_1 = null,
						_2 = null,
					},
					[63827] = new Feature
					{
						_0 = new int[] { 32907 },
						_1 = null,
						_2 = null,
					},
					[63828] = new Feature
					{
						_0 = new int[] { 20956 },
						_1 = null,
						_2 = null,
					},
					[63829] = new Feature
					{
						_0 = new int[] { 20940 },
						_1 = null,
						_2 = null,
					},
					[63830] = new Feature
					{
						_0 = new int[] { 31260 },
						_1 = null,
						_2 = null,
					},
					[63831] = new Feature
					{
						_0 = new int[] { 32190 },
						_1 = null,
						_2 = null,
					},
					[63832] = new Feature
					{
						_0 = new int[] { 33777 },
						_1 = null,
						_2 = null,
					},
					[63833] = new Feature
					{
						_0 = new int[] { 38517 },
						_1 = null,
						_2 = null,
					},
					[63834] = new Feature
					{
						_0 = new int[] { 35712 },
						_1 = null,
						_2 = null,
					},
					[63835] = new Feature
					{
						_0 = new int[] { 25295 },
						_1 = null,
						_2 = null,
					},
					[63836] = new Feature
					{
						_0 = new int[] { 27138 },
						_1 = null,
						_2 = null,
					},
					[63837] = new Feature
					{
						_0 = new int[] { 35582 },
						_1 = null,
						_2 = null,
					},
					[63838] = new Feature
					{
						_0 = new int[] { 20025 },
						_1 = null,
						_2 = null,
					},
					[63839] = new Feature
					{
						_0 = new int[] { 23527 },
						_1 = null,
						_2 = null,
					},
					[63840] = new Feature
					{
						_0 = new int[] { 24594 },
						_1 = null,
						_2 = null,
					},
					[63841] = new Feature
					{
						_0 = new int[] { 29575 },
						_1 = null,
						_2 = null,
					},
					[63842] = new Feature
					{
						_0 = new int[] { 30064 },
						_1 = null,
						_2 = null,
					},
					[63843] = new Feature
					{
						_0 = new int[] { 21271 },
						_1 = null,
						_2 = null,
					},
					[63844] = new Feature
					{
						_0 = new int[] { 30971 },
						_1 = null,
						_2 = null,
					},
					[63845] = new Feature
					{
						_0 = new int[] { 20415 },
						_1 = null,
						_2 = null,
					},
					[63846] = new Feature
					{
						_0 = new int[] { 24489 },
						_1 = null,
						_2 = null,
					},
					[63847] = new Feature
					{
						_0 = new int[] { 19981 },
						_1 = null,
						_2 = null,
					},
					[63848] = new Feature
					{
						_0 = new int[] { 27852 },
						_1 = null,
						_2 = null,
					},
					[63849] = new Feature
					{
						_0 = new int[] { 25976 },
						_1 = null,
						_2 = null,
					},
					[63850] = new Feature
					{
						_0 = new int[] { 32034 },
						_1 = null,
						_2 = null,
					},
					[63851] = new Feature
					{
						_0 = new int[] { 21443 },
						_1 = null,
						_2 = null,
					},
					[63852] = new Feature
					{
						_0 = new int[] { 22622 },
						_1 = null,
						_2 = null,
					},
					[63853] = new Feature
					{
						_0 = new int[] { 30465 },
						_1 = null,
						_2 = null,
					},
					[63854] = new Feature
					{
						_0 = new int[] { 33865 },
						_1 = null,
						_2 = null,
					},
					[63855] = new Feature
					{
						_0 = new int[] { 35498 },
						_1 = null,
						_2 = null,
					},
					[63856] = new Feature
					{
						_0 = new int[] { 27578 },
						_1 = null,
						_2 = null,
					},
					[63857] = new Feature
					{
						_0 = new int[] { 36784 },
						_1 = null,
						_2 = null,
					},
					[63858] = new Feature
					{
						_0 = new int[] { 27784 },
						_1 = null,
						_2 = null,
					},
					[63859] = new Feature
					{
						_0 = new int[] { 25342 },
						_1 = null,
						_2 = null,
					},
					[63860] = new Feature
					{
						_0 = new int[] { 33509 },
						_1 = null,
						_2 = null,
					},
					[63861] = new Feature
					{
						_0 = new int[] { 25504 },
						_1 = null,
						_2 = null,
					},
					[63862] = new Feature
					{
						_0 = new int[] { 30053 },
						_1 = null,
						_2 = null,
					},
					[63863] = new Feature
					{
						_0 = new int[] { 20142 },
						_1 = null,
						_2 = null,
					},
					[63864] = new Feature
					{
						_0 = new int[] { 20841 },
						_1 = null,
						_2 = null,
					},
					[63865] = new Feature
					{
						_0 = new int[] { 20937 },
						_1 = null,
						_2 = null,
					},
					[63866] = new Feature
					{
						_0 = new int[] { 26753 },
						_1 = null,
						_2 = null,
					},
					[63867] = new Feature
					{
						_0 = new int[] { 31975 },
						_1 = null,
						_2 = null,
					},
					[63868] = new Feature
					{
						_0 = new int[] { 33391 },
						_1 = null,
						_2 = null,
					},
					[63869] = new Feature
					{
						_0 = new int[] { 35538 },
						_1 = null,
						_2 = null,
					},
					[63870] = new Feature
					{
						_0 = new int[] { 37327 },
						_1 = null,
						_2 = null,
					},
					[63871] = new Feature
					{
						_0 = new int[] { 21237 },
						_1 = null,
						_2 = null,
					},
					[63872] = new Feature
					{
						_0 = new int[] { 21570 },
						_1 = null,
						_2 = null,
					},
					[63873] = new Feature
					{
						_0 = new int[] { 22899 },
						_1 = null,
						_2 = null,
					},
					[63874] = new Feature
					{
						_0 = new int[] { 24300 },
						_1 = null,
						_2 = null,
					},
					[63875] = new Feature
					{
						_0 = new int[] { 26053 },
						_1 = null,
						_2 = null,
					},
					[63876] = new Feature
					{
						_0 = new int[] { 28670 },
						_1 = null,
						_2 = null,
					},
					[63877] = new Feature
					{
						_0 = new int[] { 31018 },
						_1 = null,
						_2 = null,
					},
					[63878] = new Feature
					{
						_0 = new int[] { 38317 },
						_1 = null,
						_2 = null,
					},
					[63879] = new Feature
					{
						_0 = new int[] { 39530 },
						_1 = null,
						_2 = null,
					},
					[63880] = new Feature
					{
						_0 = new int[] { 40599 },
						_1 = null,
						_2 = null,
					},
					[63881] = new Feature
					{
						_0 = new int[] { 40654 },
						_1 = null,
						_2 = null,
					},
					[63882] = new Feature
					{
						_0 = new int[] { 21147 },
						_1 = null,
						_2 = null,
					},
					[63883] = new Feature
					{
						_0 = new int[] { 26310 },
						_1 = null,
						_2 = null,
					},
					[63884] = new Feature
					{
						_0 = new int[] { 27511 },
						_1 = null,
						_2 = null,
					},
					[63885] = new Feature
					{
						_0 = new int[] { 36706 },
						_1 = null,
						_2 = null,
					},
					[63886] = new Feature
					{
						_0 = new int[] { 24180 },
						_1 = null,
						_2 = null,
					},
					[63887] = new Feature
					{
						_0 = new int[] { 24976 },
						_1 = null,
						_2 = null,
					},
					[63888] = new Feature
					{
						_0 = new int[] { 25088 },
						_1 = null,
						_2 = null,
					},
					[63889] = new Feature
					{
						_0 = new int[] { 25754 },
						_1 = null,
						_2 = null,
					},
					[63890] = new Feature
					{
						_0 = new int[] { 28451 },
						_1 = null,
						_2 = null,
					},
					[63891] = new Feature
					{
						_0 = new int[] { 29001 },
						_1 = null,
						_2 = null,
					},
					[63892] = new Feature
					{
						_0 = new int[] { 29833 },
						_1 = null,
						_2 = null,
					},
					[63893] = new Feature
					{
						_0 = new int[] { 31178 },
						_1 = null,
						_2 = null,
					},
					[63894] = new Feature
					{
						_0 = new int[] { 32244 },
						_1 = null,
						_2 = null,
					},
					[63895] = new Feature
					{
						_0 = new int[] { 32879 },
						_1 = null,
						_2 = null,
					},
					[63896] = new Feature
					{
						_0 = new int[] { 36646 },
						_1 = null,
						_2 = null,
					},
					[63897] = new Feature
					{
						_0 = new int[] { 34030 },
						_1 = null,
						_2 = null,
					},
					[63898] = new Feature
					{
						_0 = new int[] { 36899 },
						_1 = null,
						_2 = null,
					},
					[63899] = new Feature
					{
						_0 = new int[] { 37706 },
						_1 = null,
						_2 = null,
					},
					[63900] = new Feature
					{
						_0 = new int[] { 21015 },
						_1 = null,
						_2 = null,
					},
					[63901] = new Feature
					{
						_0 = new int[] { 21155 },
						_1 = null,
						_2 = null,
					},
					[63902] = new Feature
					{
						_0 = new int[] { 21693 },
						_1 = null,
						_2 = null,
					},
					[63903] = new Feature
					{
						_0 = new int[] { 28872 },
						_1 = null,
						_2 = null,
					},
					[63904] = new Feature
					{
						_0 = new int[] { 35010 },
						_1 = null,
						_2 = null,
					},
					[63905] = new Feature
					{
						_0 = new int[] { 35498 },
						_1 = null,
						_2 = null,
					},
					[63906] = new Feature
					{
						_0 = new int[] { 24265 },
						_1 = null,
						_2 = null,
					},
					[63907] = new Feature
					{
						_0 = new int[] { 24565 },
						_1 = null,
						_2 = null,
					},
					[63908] = new Feature
					{
						_0 = new int[] { 25467 },
						_1 = null,
						_2 = null,
					},
					[63909] = new Feature
					{
						_0 = new int[] { 27566 },
						_1 = null,
						_2 = null,
					},
					[63910] = new Feature
					{
						_0 = new int[] { 31806 },
						_1 = null,
						_2 = null,
					},
					[63911] = new Feature
					{
						_0 = new int[] { 29557 },
						_1 = null,
						_2 = null,
					},
					[63912] = new Feature
					{
						_0 = new int[] { 20196 },
						_1 = null,
						_2 = null,
					},
					[63913] = new Feature
					{
						_0 = new int[] { 22265 },
						_1 = null,
						_2 = null,
					},
					[63914] = new Feature
					{
						_0 = new int[] { 23527 },
						_1 = null,
						_2 = null,
					},
					[63915] = new Feature
					{
						_0 = new int[] { 23994 },
						_1 = null,
						_2 = null,
					},
					[63916] = new Feature
					{
						_0 = new int[] { 24604 },
						_1 = null,
						_2 = null,
					},
					[63917] = new Feature
					{
						_0 = new int[] { 29618 },
						_1 = null,
						_2 = null,
					},
					[63918] = new Feature
					{
						_0 = new int[] { 29801 },
						_1 = null,
						_2 = null,
					},
					[63919] = new Feature
					{
						_0 = new int[] { 32666 },
						_1 = null,
						_2 = null,
					},
					[63920] = new Feature
					{
						_0 = new int[] { 32838 },
						_1 = null,
						_2 = null,
					},
					[63921] = new Feature
					{
						_0 = new int[] { 37428 },
						_1 = null,
						_2 = null,
					},
					[63922] = new Feature
					{
						_0 = new int[] { 38646 },
						_1 = null,
						_2 = null,
					},
					[63923] = new Feature
					{
						_0 = new int[] { 38728 },
						_1 = null,
						_2 = null,
					},
					[63924] = new Feature
					{
						_0 = new int[] { 38936 },
						_1 = null,
						_2 = null,
					},
					[63925] = new Feature
					{
						_0 = new int[] { 20363 },
						_1 = null,
						_2 = null,
					},
					[63926] = new Feature
					{
						_0 = new int[] { 31150 },
						_1 = null,
						_2 = null,
					},
					[63927] = new Feature
					{
						_0 = new int[] { 37300 },
						_1 = null,
						_2 = null,
					},
					[63928] = new Feature
					{
						_0 = new int[] { 38584 },
						_1 = null,
						_2 = null,
					},
					[63929] = new Feature
					{
						_0 = new int[] { 24801 },
						_1 = null,
						_2 = null,
					},
					[63930] = new Feature
					{
						_0 = new int[] { 20102 },
						_1 = null,
						_2 = null,
					},
					[63931] = new Feature
					{
						_0 = new int[] { 20698 },
						_1 = null,
						_2 = null,
					},
					[63932] = new Feature
					{
						_0 = new int[] { 23534 },
						_1 = null,
						_2 = null,
					},
					[63933] = new Feature
					{
						_0 = new int[] { 23615 },
						_1 = null,
						_2 = null,
					},
					[63934] = new Feature
					{
						_0 = new int[] { 26009 },
						_1 = null,
						_2 = null,
					},
					[63935] = new Feature
					{
						_0 = new int[] { 27138 },
						_1 = null,
						_2 = null,
					},
					[63936] = new Feature
					{
						_0 = new int[] { 29134 },
						_1 = null,
						_2 = null,
					},
					[63937] = new Feature
					{
						_0 = new int[] { 30274 },
						_1 = null,
						_2 = null,
					},
					[63938] = new Feature
					{
						_0 = new int[] { 34044 },
						_1 = null,
						_2 = null,
					},
					[63939] = new Feature
					{
						_0 = new int[] { 36988 },
						_1 = null,
						_2 = null,
					},
					[63940] = new Feature
					{
						_0 = new int[] { 40845 },
						_1 = null,
						_2 = null,
					},
					[63941] = new Feature
					{
						_0 = new int[] { 26248 },
						_1 = null,
						_2 = null,
					},
					[63942] = new Feature
					{
						_0 = new int[] { 38446 },
						_1 = null,
						_2 = null,
					},
					[63943] = new Feature
					{
						_0 = new int[] { 21129 },
						_1 = null,
						_2 = null,
					},
					[63944] = new Feature
					{
						_0 = new int[] { 26491 },
						_1 = null,
						_2 = null,
					},
					[63945] = new Feature
					{
						_0 = new int[] { 26611 },
						_1 = null,
						_2 = null,
					},
					[63946] = new Feature
					{
						_0 = new int[] { 27969 },
						_1 = null,
						_2 = null,
					},
					[63947] = new Feature
					{
						_0 = new int[] { 28316 },
						_1 = null,
						_2 = null,
					},
					[63948] = new Feature
					{
						_0 = new int[] { 29705 },
						_1 = null,
						_2 = null,
					},
					[63949] = new Feature
					{
						_0 = new int[] { 30041 },
						_1 = null,
						_2 = null,
					},
					[63950] = new Feature
					{
						_0 = new int[] { 30827 },
						_1 = null,
						_2 = null,
					},
					[63951] = new Feature
					{
						_0 = new int[] { 32016 },
						_1 = null,
						_2 = null,
					},
					[63952] = new Feature
					{
						_0 = new int[] { 39006 },
						_1 = null,
						_2 = null,
					},
					[63953] = new Feature
					{
						_0 = new int[] { 20845 },
						_1 = null,
						_2 = null,
					},
					[63954] = new Feature
					{
						_0 = new int[] { 25134 },
						_1 = null,
						_2 = null,
					},
					[63955] = new Feature
					{
						_0 = new int[] { 38520 },
						_1 = null,
						_2 = null,
					},
					[63956] = new Feature
					{
						_0 = new int[] { 20523 },
						_1 = null,
						_2 = null,
					},
					[63957] = new Feature
					{
						_0 = new int[] { 23833 },
						_1 = null,
						_2 = null,
					},
					[63958] = new Feature
					{
						_0 = new int[] { 28138 },
						_1 = null,
						_2 = null,
					},
					[63959] = new Feature
					{
						_0 = new int[] { 36650 },
						_1 = null,
						_2 = null,
					},
					[63960] = new Feature
					{
						_0 = new int[] { 24459 },
						_1 = null,
						_2 = null,
					},
					[63961] = new Feature
					{
						_0 = new int[] { 24900 },
						_1 = null,
						_2 = null,
					},
					[63962] = new Feature
					{
						_0 = new int[] { 26647 },
						_1 = null,
						_2 = null,
					},
					[63963] = new Feature
					{
						_0 = new int[] { 29575 },
						_1 = null,
						_2 = null,
					},
					[63964] = new Feature
					{
						_0 = new int[] { 38534 },
						_1 = null,
						_2 = null,
					},
					[63965] = new Feature
					{
						_0 = new int[] { 21033 },
						_1 = null,
						_2 = null,
					},
					[63966] = new Feature
					{
						_0 = new int[] { 21519 },
						_1 = null,
						_2 = null,
					},
					[63967] = new Feature
					{
						_0 = new int[] { 23653 },
						_1 = null,
						_2 = null,
					},
					[63968] = new Feature
					{
						_0 = new int[] { 26131 },
						_1 = null,
						_2 = null,
					},
					[63969] = new Feature
					{
						_0 = new int[] { 26446 },
						_1 = null,
						_2 = null,
					},
					[63970] = new Feature
					{
						_0 = new int[] { 26792 },
						_1 = null,
						_2 = null,
					},
					[63971] = new Feature
					{
						_0 = new int[] { 27877 },
						_1 = null,
						_2 = null,
					},
					[63972] = new Feature
					{
						_0 = new int[] { 29702 },
						_1 = null,
						_2 = null,
					},
					[63973] = new Feature
					{
						_0 = new int[] { 30178 },
						_1 = null,
						_2 = null,
					},
					[63974] = new Feature
					{
						_0 = new int[] { 32633 },
						_1 = null,
						_2 = null,
					},
					[63975] = new Feature
					{
						_0 = new int[] { 35023 },
						_1 = null,
						_2 = null,
					},
					[63976] = new Feature
					{
						_0 = new int[] { 35041 },
						_1 = null,
						_2 = null,
					},
					[63977] = new Feature
					{
						_0 = new int[] { 37324 },
						_1 = null,
						_2 = null,
					},
					[63978] = new Feature
					{
						_0 = new int[] { 38626 },
						_1 = null,
						_2 = null,
					},
					[63979] = new Feature
					{
						_0 = new int[] { 21311 },
						_1 = null,
						_2 = null,
					},
					[63980] = new Feature
					{
						_0 = new int[] { 28346 },
						_1 = null,
						_2 = null,
					},
					[63981] = new Feature
					{
						_0 = new int[] { 21533 },
						_1 = null,
						_2 = null,
					},
					[63982] = new Feature
					{
						_0 = new int[] { 29136 },
						_1 = null,
						_2 = null,
					},
					[63983] = new Feature
					{
						_0 = new int[] { 29848 },
						_1 = null,
						_2 = null,
					},
					[63984] = new Feature
					{
						_0 = new int[] { 34298 },
						_1 = null,
						_2 = null,
					},
					[63985] = new Feature
					{
						_0 = new int[] { 38563 },
						_1 = null,
						_2 = null,
					},
					[63986] = new Feature
					{
						_0 = new int[] { 40023 },
						_1 = null,
						_2 = null,
					},
					[63987] = new Feature
					{
						_0 = new int[] { 40607 },
						_1 = null,
						_2 = null,
					},
					[63988] = new Feature
					{
						_0 = new int[] { 26519 },
						_1 = null,
						_2 = null,
					},
					[63989] = new Feature
					{
						_0 = new int[] { 28107 },
						_1 = null,
						_2 = null,
					},
					[63990] = new Feature
					{
						_0 = new int[] { 33256 },
						_1 = null,
						_2 = null,
					},
					[63991] = new Feature
					{
						_0 = new int[] { 31435 },
						_1 = null,
						_2 = null,
					},
					[63992] = new Feature
					{
						_0 = new int[] { 31520 },
						_1 = null,
						_2 = null,
					},
					[63993] = new Feature
					{
						_0 = new int[] { 31890 },
						_1 = null,
						_2 = null,
					},
					[63994] = new Feature
					{
						_0 = new int[] { 29376 },
						_1 = null,
						_2 = null,
					},
					[63995] = new Feature
					{
						_0 = new int[] { 28825 },
						_1 = null,
						_2 = null,
					},
					[63996] = new Feature
					{
						_0 = new int[] { 35672 },
						_1 = null,
						_2 = null,
					},
					[63997] = new Feature
					{
						_0 = new int[] { 20160 },
						_1 = null,
						_2 = null,
					},
					[63998] = new Feature
					{
						_0 = new int[] { 33590 },
						_1 = null,
						_2 = null,
					},
					[63999] = new Feature
					{
						_0 = new int[] { 21050 },
						_1 = null,
						_2 = null,
					},
					[194816] = new Feature
					{
						_0 = new int[] { 27966 },
						_1 = null,
						_2 = null,
					},
					[194817] = new Feature
					{
						_0 = new int[] { 28023 },
						_1 = null,
						_2 = null,
					},
					[194818] = new Feature
					{
						_0 = new int[] { 27969 },
						_1 = null,
						_2 = null,
					},
					[194819] = new Feature
					{
						_0 = new int[] { 28009 },
						_1 = null,
						_2 = null,
					},
					[194820] = new Feature
					{
						_0 = new int[] { 28024 },
						_1 = null,
						_2 = null,
					},
					[194821] = new Feature
					{
						_0 = new int[] { 28037 },
						_1 = null,
						_2 = null,
					},
					[194822] = new Feature
					{
						_0 = new int[] { 146718 },
						_1 = null,
						_2 = null,
					},
					[194823] = new Feature
					{
						_0 = new int[] { 27956 },
						_1 = null,
						_2 = null,
					},
					[194824] = new Feature
					{
						_0 = new int[] { 28207 },
						_1 = null,
						_2 = null,
					},
					[194825] = new Feature
					{
						_0 = new int[] { 28270 },
						_1 = null,
						_2 = null,
					},
					[194826] = new Feature
					{
						_0 = new int[] { 15667 },
						_1 = null,
						_2 = null,
					},
					[194827] = new Feature
					{
						_0 = new int[] { 28363 },
						_1 = null,
						_2 = null,
					},
					[194828] = new Feature
					{
						_0 = new int[] { 28359 },
						_1 = null,
						_2 = null,
					},
					[194829] = new Feature
					{
						_0 = new int[] { 147153 },
						_1 = null,
						_2 = null,
					},
					[194830] = new Feature
					{
						_0 = new int[] { 28153 },
						_1 = null,
						_2 = null,
					},
					[194831] = new Feature
					{
						_0 = new int[] { 28526 },
						_1 = null,
						_2 = null,
					},
					[194832] = new Feature
					{
						_0 = new int[] { 147294 },
						_1 = null,
						_2 = null,
					},
					[194833] = new Feature
					{
						_0 = new int[] { 147342 },
						_1 = null,
						_2 = null,
					},
					[194834] = new Feature
					{
						_0 = new int[] { 28614 },
						_1 = null,
						_2 = null,
					},
					[194835] = new Feature
					{
						_0 = new int[] { 28729 },
						_1 = null,
						_2 = null,
					},
					[194836] = new Feature
					{
						_0 = new int[] { 28702 },
						_1 = null,
						_2 = null,
					},
					[194837] = new Feature
					{
						_0 = new int[] { 28699 },
						_1 = null,
						_2 = null,
					},
					[194838] = new Feature
					{
						_0 = new int[] { 15766 },
						_1 = null,
						_2 = null,
					},
					[194839] = new Feature
					{
						_0 = new int[] { 28746 },
						_1 = null,
						_2 = null,
					},
					[194840] = new Feature
					{
						_0 = new int[] { 28797 },
						_1 = null,
						_2 = null,
					},
					[194841] = new Feature
					{
						_0 = new int[] { 28791 },
						_1 = null,
						_2 = null,
					},
					[194842] = new Feature
					{
						_0 = new int[] { 28845 },
						_1 = null,
						_2 = null,
					},
					[194843] = new Feature
					{
						_0 = new int[] { 132389 },
						_1 = null,
						_2 = null,
					},
					[194844] = new Feature
					{
						_0 = new int[] { 28997 },
						_1 = null,
						_2 = null,
					},
					[194845] = new Feature
					{
						_0 = new int[] { 148067 },
						_1 = null,
						_2 = null,
					},
					[194846] = new Feature
					{
						_0 = new int[] { 29084 },
						_1 = null,
						_2 = null,
					},
					[194847] = new Feature
					{
						_0 = new int[] { 148395 },
						_1 = null,
						_2 = null,
					},
					[194848] = new Feature
					{
						_0 = new int[] { 29224 },
						_1 = null,
						_2 = null,
					},
					[194849] = new Feature
					{
						_0 = new int[] { 29237 },
						_1 = null,
						_2 = null,
					},
					[194850] = new Feature
					{
						_0 = new int[] { 29264 },
						_1 = null,
						_2 = null,
					},
					[194851] = new Feature
					{
						_0 = new int[] { 149000 },
						_1 = null,
						_2 = null,
					},
					[194852] = new Feature
					{
						_0 = new int[] { 29312 },
						_1 = null,
						_2 = null,
					},
					[194853] = new Feature
					{
						_0 = new int[] { 29333 },
						_1 = null,
						_2 = null,
					},
					[194854] = new Feature
					{
						_0 = new int[] { 149301 },
						_1 = null,
						_2 = null,
					},
					[194855] = new Feature
					{
						_0 = new int[] { 149524 },
						_1 = null,
						_2 = null,
					},
					[194856] = new Feature
					{
						_0 = new int[] { 29562 },
						_1 = null,
						_2 = null,
					},
					[194857] = new Feature
					{
						_0 = new int[] { 29579 },
						_1 = null,
						_2 = null,
					},
					[194858] = new Feature
					{
						_0 = new int[] { 16044 },
						_1 = null,
						_2 = null,
					},
					[194859] = new Feature
					{
						_0 = new int[] { 29605 },
						_1 = null,
						_2 = null,
					},
					[194860] = new Feature
					{
						_0 = new int[] { 16056 },
						_1 = null,
						_2 = null,
					},
					[194861] = new Feature
					{
						_0 = new int[] { 16056 },
						_1 = null,
						_2 = null,
					},
					[194862] = new Feature
					{
						_0 = new int[] { 29767 },
						_1 = null,
						_2 = null,
					},
					[194863] = new Feature
					{
						_0 = new int[] { 29788 },
						_1 = null,


						_2 = null,
					},
					[194864] = new Feature
					{
						_0 = new int[] { 29809 },
						_1 = null,
						_2 = null,
					},
					[194865] = new Feature
					{
						_0 = new int[] { 29829 },
						_1 = null,
						_2 = null,
					},
					[194866] = new Feature
					{
						_0 = new int[] { 29898 },
						_1 = null,
						_2 = null,
					},
					[194867] = new Feature
					{
						_0 = new int[] { 16155 },
						_1 = null,
						_2 = null,
					},
					[194868] = new Feature
					{
						_0 = new int[] { 29988 },
						_1 = null,
						_2 = null,
					},
					[194869] = new Feature
					{
						_0 = new int[] { 150582 },
						_1 = null,
						_2 = null,
					},
					[194870] = new Feature
					{
						_0 = new int[] { 30014 },
						_1 = null,
						_2 = null,
					},
					[194871] = new Feature
					{
						_0 = new int[] { 150674 },
						_1 = null,
						_2 = null,
					},
					[194872] = new Feature
					{
						_0 = new int[] { 30064 },
						_1 = null,
						_2 = null,
					},
					[194873] = new Feature
					{
						_0 = new int[] { 139679 },
						_1 = null,
						_2 = null,
					},
					[194874] = new Feature
					{
						_0 = new int[] { 30224 },
						_1 = null,
						_2 = null,
					},
					[194875] = new Feature
					{
						_0 = new int[] { 151457 },
						_1 = null,
						_2 = null,
					},
					[194876] = new Feature
					{
						_0 = new int[] { 151480 },
						_1 = null,
						_2 = null,
					},
					[194877] = new Feature
					{
						_0 = new int[] { 151620 },
						_1 = null,
						_2 = null,
					},
					[194878] = new Feature
					{
						_0 = new int[] { 16380 },
						_1 = null,
						_2 = null,
					},
					[194879] = new Feature
					{
						_0 = new int[] { 16392 },
						_1 = null,
						_2 = null,
					},
					[194880] = new Feature
					{
						_0 = new int[] { 30452 },
						_1 = null,
						_2 = null,
					},
					[194881] = new Feature
					{
						_0 = new int[] { 151795 },
						_1 = null,
						_2 = null,
					},
					[194882] = new Feature
					{
						_0 = new int[] { 151794 },
						_1 = null,
						_2 = null,
					},
					[194883] = new Feature
					{
						_0 = new int[] { 151833 },
						_1 = null,
						_2 = null,
					},
					[194884] = new Feature
					{
						_0 = new int[] { 151859 },
						_1 = null,
						_2 = null,
					},
					[194885] = new Feature
					{
						_0 = new int[] { 30494 },
						_1 = null,
						_2 = null,
					},
					[194886] = new Feature
					{
						_0 = new int[] { 30495 },
						_1 = null,
						_2 = null,
					},
					[194887] = new Feature
					{
						_0 = new int[] { 30495 },
						_1 = null,
						_2 = null,
					},
					[194888] = new Feature
					{
						_0 = new int[] { 30538 },
						_1 = null,
						_2 = null,
					},
					[194889] = new Feature
					{
						_0 = new int[] { 16441 },
						_1 = null,
						_2 = null,
					},
					[194890] = new Feature
					{
						_0 = new int[] { 30603 },
						_1 = null,
						_2 = null,
					},
					[194891] = new Feature
					{
						_0 = new int[] { 16454 },
						_1 = null,
						_2 = null,
					},
					[194892] = new Feature
					{
						_0 = new int[] { 16534 },
						_1 = null,
						_2 = null,
					},
					[194893] = new Feature
					{
						_0 = new int[] { 152605 },
						_1 = null,
						_2 = null,
					},
					[194894] = new Feature
					{
						_0 = new int[] { 30798 },
						_1 = null,
						_2 = null,
					},
					[194895] = new Feature
					{
						_0 = new int[] { 30860 },
						_1 = null,
						_2 = null,
					},
					[194896] = new Feature
					{
						_0 = new int[] { 30924 },
						_1 = null,
						_2 = null,
					},
					[194897] = new Feature
					{
						_0 = new int[] { 16611 },
						_1 = null,
						_2 = null,
					},
					[194898] = new Feature
					{
						_0 = new int[] { 153126 },
						_1 = null,
						_2 = null,
					},
					[194899] = new Feature
					{
						_0 = new int[] { 31062 },
						_1 = null,
						_2 = null,
					},
					[194900] = new Feature
					{
						_0 = new int[] { 153242 },
						_1 = null,
						_2 = null,
					},
					[194901] = new Feature
					{
						_0 = new int[] { 153285 },
						_1 = null,
						_2 = null,
					},
					[194902] = new Feature
					{
						_0 = new int[] { 31119 },
						_1 = null,
						_2 = null,
					},
					[194903] = new Feature
					{
						_0 = new int[] { 31211 },
						_1 = null,
						_2 = null,
					},
					[194904] = new Feature
					{
						_0 = new int[] { 16687 },
						_1 = null,
						_2 = null,
					},
					[194905] = new Feature
					{
						_0 = new int[] { 31296 },
						_1 = null,
						_2 = null,
					},
					[194906] = new Feature
					{
						_0 = new int[] { 31306 },
						_1 = null,
						_2 = null,
					},
					[194907] = new Feature
					{
						_0 = new int[] { 31311 },
						_1 = null,
						_2 = null,
					},
					[194908] = new Feature
					{
						_0 = new int[] { 153980 },
						_1 = null,
						_2 = null,
					},
					[194909] = new Feature
					{
						_0 = new int[] { 154279 },
						_1 = null,
						_2 = null,
					},
					[194910] = new Feature
					{
						_0 = new int[] { 154279 },
						_1 = null,
						_2 = null,
					},
					[194911] = new Feature
					{
						_0 = new int[] { 31470 },
						_1 = null,
						_2 = null,
					},
					[194912] = new Feature
					{
						_0 = new int[] { 16898 },
						_1 = null,
						_2 = null,
					},
					[194913] = new Feature
					{
						_0 = new int[] { 154539 },
						_1 = null,
						_2 = null,
					},
					[194914] = new Feature
					{
						_0 = new int[] { 31686 },
						_1 = null,
						_2 = null,
					},
					[194915] = new Feature
					{
						_0 = new int[] { 31689 },
						_1 = null,
						_2 = null,
					},
					[194916] = new Feature
					{
						_0 = new int[] { 16935 },
						_1 = null,
						_2 = null,
					},
					[194917] = new Feature
					{
						_0 = new int[] { 154752 },
						_1 = null,
						_2 = null,
					},
					[194918] = new Feature
					{
						_0 = new int[] { 31954 },
						_1 = null,
						_2 = null,
					},
					[194919] = new Feature
					{
						_0 = new int[] { 17056 },
						_1 = null,
						_2 = null,
					},
					[194920] = new Feature
					{
						_0 = new int[] { 31976 },
						_1 = null,
						_2 = null,
					},
					[194921] = new Feature
					{
						_0 = new int[] { 31971 },
						_1 = null,
						_2 = null,
					},
					[194922] = new Feature
					{
						_0 = new int[] { 32000 },
						_1 = null,
						_2 = null,
					},
					[194923] = new Feature
					{
						_0 = new int[] { 155526 },
						_1 = null,
						_2 = null,
					},
					[194924] = new Feature
					{
						_0 = new int[] { 32099 },
						_1 = null,
						_2 = null,
					},
					[194925] = new Feature
					{
						_0 = new int[] { 17153 },
						_1 = null,
						_2 = null,
					},
					[194926] = new Feature
					{
						_0 = new int[] { 32199 },
						_1 = null,
						_2 = null,
					},
					[194927] = new Feature
					{
						_0 = new int[] { 32258 },
						_1 = null,
						_2 = null,
					},
					[194928] = new Feature
					{
						_0 = new int[] { 32325 },
						_1 = null,
						_2 = null,
					},
					[194929] = new Feature
					{
						_0 = new int[] { 17204 },
						_1 = null,
						_2 = null,
					},
					[194930] = new Feature
					{
						_0 = new int[] { 156200 },
						_1 = null,
						_2 = null,
					},
					[194931] = new Feature
					{
						_0 = new int[] { 156231 },
						_1 = null,
						_2 = null,
					},
					[194932] = new Feature
					{
						_0 = new int[] { 17241 },
						_1 = null,
						_2 = null,
					},
					[194933] = new Feature
					{
						_0 = new int[] { 156377 },
						_1 = null,
						_2 = null,
					},
					[194934] = new Feature
					{
						_0 = new int[] { 32634 },
						_1 = null,
						_2 = null,
					},
					[194935] = new Feature
					{
						_0 = new int[] { 156478 },
						_1 = null,
						_2 = null,
					},
					[194936] = new Feature
					{
						_0 = new int[] { 32661 },
						_1 = null,
						_2 = null,
					},
					[194937] = new Feature
					{
						_0 = new int[] { 32762 },
						_1 = null,
						_2 = null,
					},
					[194938] = new Feature
					{
						_0 = new int[] { 32773 },
						_1 = null,
						_2 = null,
					},
					[194939] = new Feature
					{
						_0 = new int[] { 156890 },
						_1 = null,
						_2 = null,
					},
					[194940] = new Feature
					{
						_0 = new int[] { 156963 },
						_1 = null,
						_2 = null,
					},
					[194941] = new Feature
					{
						_0 = new int[] { 32864 },
						_1 = null,
						_2 = null,
					},
					[194942] = new Feature
					{
						_0 = new int[] { 157096 },
						_1 = null,
						_2 = null,
					},
					[194943] = new Feature
					{
						_0 = new int[] { 32880 },
						_1 = null,
						_2 = null,
					},
					[194944] = new Feature
					{
						_0 = new int[] { 144223 },
						_1 = null,
						_2 = null,
					},
					[194945] = new Feature
					{
						_0 = new int[] { 17365 },
						_1 = null,
						_2 = null,
					},
					[194946] = new Feature
					{
						_0 = new int[] { 32946 },
						_1 = null,
						_2 = null,
					},
					[194947] = new Feature
					{
						_0 = new int[] { 33027 },
						_1 = null,
						_2 = null,
					},
					[194948] = new Feature
					{
						_0 = new int[] { 17419 },
						_1 = null,
						_2 = null,
					},
					[194949] = new Feature
					{
						_0 = new int[] { 33086 },
						_1 = null,
						_2 = null,
					},
					[194950] = new Feature
					{
						_0 = new int[] { 23221 },
						_1 = null,
						_2 = null,
					},
					[194951] = new Feature
					{
						_0 = new int[] { 157607 },
						_1 = null,
						_2 = null,
					},
					[194952] = new Feature
					{
						_0 = new int[] { 157621 },
						_1 = null,
						_2 = null,
					},
					[194953] = new Feature
					{
						_0 = new int[] { 144275 },
						_1 = null,
						_2 = null,
					},
					[194954] = new Feature
					{
						_0 = new int[] { 144284 },
						_1 = null,
						_2 = null,
					},
					[194955] = new Feature
					{
						_0 = new int[] { 33281 },
						_1 = null,
						_2 = null,
					},
					[194956] = new Feature
					{
						_0 = new int[] { 33284 },
						_1 = null,
						_2 = null,
					},
					[194957] = new Feature
					{
						_0 = new int[] { 36766 },
						_1 = null,
						_2 = null,
					},
					[194958] = new Feature
					{
						_0 = new int[] { 17515 },
						_1 = null,
						_2 = null,
					},
					[194959] = new Feature
					{
						_0 = new int[] { 33425 },
						_1 = null,
						_2 = null,
					},
					[194960] = new Feature
					{
						_0 = new int[] { 33419 },
						_1 = null,
						_2 = null,
					},
					[194961] = new Feature
					{
						_0 = new int[] { 33437 },
						_1 = null,
						_2 = null,
					},
					[194962] = new Feature
					{
						_0 = new int[] { 21171 },
						_1 = null,
						_2 = null,
					},
					[194963] = new Feature
					{
						_0 = new int[] { 33457 },
						_1 = null,
						_2 = null,
					},
					[194964] = new Feature
					{
						_0 = new int[] { 33459 },
						_1 = null,
						_2 = null,
					},
					[194965] = new Feature
					{
						_0 = new int[] { 33469 },
						_1 = null,
						_2 = null,
					},
					[194966] = new Feature
					{
						_0 = new int[] { 33510 },
						_1 = null,
						_2 = null,
					},
					[194967] = new Feature
					{
						_0 = new int[] { 158524 },
						_1 = null,
						_2 = null,
					},
					[194968] = new Feature
					{
						_0 = new int[] { 33509 },
						_1 = null,
						_2 = null,
					},
					[194969] = new Feature
					{
						_0 = new int[] { 33565 },
						_1 = null,
						_2 = null,
					},
					[194970] = new Feature
					{
						_0 = new int[] { 33635 },
						_1 = null,
						_2 = null,
					},
					[194971] = new Feature
					{
						_0 = new int[] { 33709 },
						_1 = null,
						_2 = null,
					},
					[194972] = new Feature
					{
						_0 = new int[] { 33571 },
						_1 = null,
						_2 = null,
					},
					[194973] = new Feature
					{
						_0 = new int[] { 33725 },
						_1 = null,
						_2 = null,
					},
					[194974] = new Feature
					{
						_0 = new int[] { 33767 },
						_1 = null,
						_2 = null,
					},
					[194975] = new Feature
					{
						_0 = new int[] { 33879 },
						_1 = null,
						_2 = null,
					},
					[194976] = new Feature
					{
						_0 = new int[] { 33619 },
						_1 = null,
						_2 = null,
					},
					[194977] = new Feature
					{
						_0 = new int[] { 33738 },
						_1 = null,
						_2 = null,
					},
					[194978] = new Feature
					{
						_0 = new int[] { 33740 },
						_1 = null,
						_2 = null,
					},
					[194979] = new Feature
					{
						_0 = new int[] { 33756 },
						_1 = null,
						_2 = null,
					},
					[194980] = new Feature
					{
						_0 = new int[] { 158774 },
						_1 = null,
						_2 = null,
					},
					[194981] = new Feature
					{
						_0 = new int[] { 159083 },
						_1 = null,
						_2 = null,
					},
					[194982] = new Feature
					{
						_0 = new int[] { 158933 },
						_1 = null,
						_2 = null,
					},
					[194983] = new Feature
					{
						_0 = new int[] { 17707 },
						_1 = null,
						_2 = null,
					},
					[194984] = new Feature
					{
						_0 = new int[] { 34033 },
						_1 = null,
						_2 = null,
					},
					[194985] = new Feature
					{
						_0 = new int[] { 34035 },
						_1 = null,
						_2 = null,
					},
					[194986] = new Feature
					{
						_0 = new int[] { 34070 },
						_1 = null,
						_2 = null,
					},
					[194987] = new Feature
					{
						_0 = new int[] { 160714 },
						_1 = null,
						_2 = null,
					},
					[194988] = new Feature
					{
						_0 = new int[] { 34148 },
						_1 = null,
						_2 = null,
					},
					[194989] = new Feature
					{
						_0 = new int[] { 159532 },
						_1 = null,
						_2 = null,
					},
					[194990] = new Feature
					{
						_0 = new int[] { 17757 },
						_1 = null,
						_2 = null,
					},
					[194991] = new Feature
					{
						_0 = new int[] { 17761 },
						_1 = null,
						_2 = null,
					},
					[194992] = new Feature
					{
						_0 = new int[] { 159665 },
						_1 = null,
						_2 = null,
					},
					[194993] = new Feature
					{
						_0 = new int[] { 159954 },
						_1 = null,
						_2 = null,
					},
					[194994] = new Feature
					{
						_0 = new int[] { 17771 },
						_1 = null,
						_2 = null,
					},
					[194995] = new Feature
					{
						_0 = new int[] { 34384 },
						_1 = null,
						_2 = null,
					},
					[194996] = new Feature
					{
						_0 = new int[] { 34396 },
						_1 = null,
						_2 = null,
					},
					[194997] = new Feature
					{
						_0 = new int[] { 34407 },
						_1 = null,
						_2 = null,
					},
					[194998] = new Feature
					{
						_0 = new int[] { 34409 },
						_1 = null,
						_2 = null,
					},
					[194999] = new Feature
					{
						_0 = new int[] { 34473 },
						_1 = null,
						_2 = null,
					},
					[195000] = new Feature
					{
						_0 = new int[] { 34440 },
						_1 = null,
						_2 = null,
					},
					[195001] = new Feature
					{
						_0 = new int[] { 34574 },
						_1 = null,
						_2 = null,
					},
					[195002] = new Feature
					{
						_0 = new int[] { 34530 },
						_1 = null,
						_2 = null,
					},
					[195003] = new Feature
					{
						_0 = new int[] { 34681 },
						_1 = null,
						_2 = null,
					},
					[195004] = new Feature
					{
						_0 = new int[] { 34600 },
						_1 = null,
						_2 = null,
					},
					[195005] = new Feature
					{
						_0 = new int[] { 34667 },
						_1 = null,
						_2 = null,
					},
					[195006] = new Feature
					{
						_0 = new int[] { 34694 },
						_1 = null,
						_2 = null,
					},
					[195007] = new Feature
					{
						_0 = new int[] { 17879 },
						_1 = null,
						_2 = null,
					},
					[195008] = new Feature
					{
						_0 = new int[] { 34785 },
						_1 = null,
						_2 = null,
					},
					[195009] = new Feature
					{
						_0 = new int[] { 34817 },
						_1 = null,
						_2 = null,
					},
					[195010] = new Feature
					{
						_0 = new int[] { 17913 },
						_1 = null,
						_2 = null,
					},
					[195011] = new Feature
					{
						_0 = new int[] { 34912 },
						_1 = null,
						_2 = null,
					},
					[195012] = new Feature
					{
						_0 = new int[] { 34915 },
						_1 = null,
						_2 = null,
					},
					[195013] = new Feature
					{
						_0 = new int[] { 161383 },
						_1 = null,
						_2 = null,
					},
					[195014] = new Feature
					{
						_0 = new int[] { 35031 },
						_1 = null,
						_2 = null,
					},
					[195015] = new Feature
					{
						_0 = new int[] { 35038 },
						_1 = null,
						_2 = null,
					},
					[195016] = new Feature
					{
						_0 = new int[] { 17973 },
						_1 = null,
						_2 = null,
					},
					[195017] = new Feature
					{
						_0 = new int[] { 35066 },
						_1 = null,
						_2 = null,
					},
					[195018] = new Feature
					{
						_0 = new int[] { 13499 },
						_1 = null,
						_2 = null,
					},
					[195019] = new Feature
					{
						_0 = new int[] { 161966 },
						_1 = null,
						_2 = null,
					},
					[195020] = new Feature
					{
						_0 = new int[] { 162150 },
						_1 = null,
						_2 = null,
					},
					[195021] = new Feature
					{
						_0 = new int[] { 18110 },
						_1 = null,
						_2 = null,
					},
					[195022] = new Feature
					{
						_0 = new int[] { 18119 },
						_1 = null,
						_2 = null,
					},
					[195023] = new Feature
					{
						_0 = new int[] { 35488 },
						_1 = null,
						_2 = null,
					},
					[195024] = new Feature
					{
						_0 = new int[] { 35565 },
						_1 = null,
						_2 = null,
					},
					[195025] = new Feature
					{
						_0 = new int[] { 35722 },
						_1 = null,
						_2 = null,
					},
					[195026] = new Feature
					{
						_0 = new int[] { 35925 },
						_1 = null,
						_2 = null,
					},
					[195027] = new Feature
					{
						_0 = new int[] { 162984 },
						_1 = null,
						_2 = null,
					},
					[195028] = new Feature
					{
						_0 = new int[] { 36011 },
						_1 = null,
						_2 = null,
					},
					[195029] = new Feature
					{
						_0 = new int[] { 36033 },
						_1 = null,
						_2 = null,
					},
					[195030] = new Feature
					{
						_0 = new int[] { 36123 },
						_1 = null,
						_2 = null,
					},
					[195031] = new Feature
					{
						_0 = new int[] { 36215 },
						_1 = null,
						_2 = null,
					},
					[195032] = new Feature
					{
						_0 = new int[] { 163631 },
						_1 = null,
						_2 = null,
					},
					[195033] = new Feature
					{
						_0 = new int[] { 133124 },
						_1 = null,
						_2 = null,
					},
					[195034] = new Feature
					{
						_0 = new int[] { 36299 },
						_1 = null,
						_2 = null,
					},
					[195035] = new Feature
					{
						_0 = new int[] { 36284 },
						_1 = null,
						_2 = null,
					},
					[195036] = new Feature
					{
						_0 = new int[] { 36336 },
						_1 = null,
						_2 = null,
					},
					[195037] = new Feature
					{
						_0 = new int[] { 133342 },
						_1 = null,
						_2 = null,
					},
					[195038] = new Feature
					{
						_0 = new int[] { 36564 },
						_1 = null,
						_2 = null,
					},
					[195039] = new Feature
					{
						_0 = new int[] { 36664 },
						_1 = null,
						_2 = null,
					},
					[195040] = new Feature
					{
						_0 = new int[] { 165330 },
						_1 = null,
						_2 = null,
					},
					[195041] = new Feature
					{
						_0 = new int[] { 165357 },
						_1 = null,
						_2 = null,
					},
					[195042] = new Feature
					{
						_0 = new int[] { 37012 },
						_1 = null,
						_2 = null,
					},
					[195043] = new Feature
					{
						_0 = new int[] { 37105 },
						_1 = null,
						_2 = null,
					},
					[195044] = new Feature
					{
						_0 = new int[] { 37137 },
						_1 = null,
						_2 = null,
					},
					[195045] = new Feature
					{
						_0 = new int[] { 165678 },
						_1 = null,
						_2 = null,
					},
					[195046] = new Feature
					{
						_0 = new int[] { 37147 },
						_1 = null,
						_2 = null,
					},
					[195047] = new Feature
					{
						_0 = new int[] { 37432 },
						_1 = null,
						_2 = null,
					},
					[195048] = new Feature
					{
						_0 = new int[] { 37591 },
						_1 = null,
						_2 = null,
					},
					[195049] = new Feature
					{
						_0 = new int[] { 37592 },
						_1 = null,
						_2 = null,
					},
					[195050] = new Feature
					{
						_0 = new int[] { 37500 },
						_1 = null,
						_2 = null,
					},
					[195051] = new Feature
					{
						_0 = new int[] { 37881 },
						_1 = null,
						_2 = null,
					},
					[195052] = new Feature
					{
						_0 = new int[] { 37909 },
						_1 = null,
						_2 = null,
					},
					[195053] = new Feature
					{
						_0 = new int[] { 166906 },
						_1 = null,
						_2 = null,
					},
					[195054] = new Feature
					{
						_0 = new int[] { 38283 },
						_1 = null,
						_2 = null,
					},
					[195055] = new Feature
					{
						_0 = new int[] { 18837 },
						_1 = null,
						_2 = null,
					},
					[195056] = new Feature
					{
						_0 = new int[] { 38327 },
						_1 = null,
						_2 = null,
					},
					[195057] = new Feature
					{
						_0 = new int[] { 167287 },
						_1 = null,
						_2 = null,
					},
					[195058] = new Feature
					{
						_0 = new int[] { 18918 },
						_1 = null,
						_2 = null,
					},
					[195059] = new Feature
					{
						_0 = new int[] { 38595 },
						_1 = null,
						_2 = null,
					},
					[195060] = new Feature
					{
						_0 = new int[] { 23986 },
						_1 = null,
						_2 = null,
					},
					[195061] = new Feature
					{
						_0 = new int[] { 38691 },
						_1 = null,
						_2 = null,
					},
					[195062] = new Feature
					{
						_0 = new int[] { 168261 },
						_1 = null,
						_2 = null,
					},
					[195063] = new Feature
					{
						_0 = new int[] { 168474 },
						_1 = null,
						_2 = null,
					},
					[195064] = new Feature
					{
						_0 = new int[] { 19054 },
						_1 = null,
						_2 = null,
					},
					[195065] = new Feature
					{
						_0 = new int[] { 19062 },
						_1 = null,
						_2 = null,
					},
					[195066] = new Feature
					{
						_0 = new int[] { 38880 },
						_1 = null,
						_2 = null,
					},
					[195067] = new Feature
					{
						_0 = new int[] { 168970 },
						_1 = null,
						_2 = null,
					},
					[195068] = new Feature
					{
						_0 = new int[] { 19122 },
						_1 = null,
						_2 = null,
					},
					[195069] = new Feature
					{
						_0 = new int[] { 169110 },
						_1 = null,
						_2 = null,
					},
					[195070] = new Feature
					{
						_0 = new int[] { 38923 },
						_1 = null,
						_2 = null,
					},
					[195071] = new Feature
					{
						_0 = new int[] { 38923 },
						_1 = null,
						_2 = null,
					},
				},
				[64000] = new Dictionary<int, Feature>
				{
					[64000] = new Feature
					{
						_0 = new int[] { 20999 },
						_1 = null,
						_2 = null,
					},
					[64001] = new Feature
					{
						_0 = new int[] { 24230 },
						_1 = null,
						_2 = null,
					},
					[64002] = new Feature
					{
						_0 = new int[] { 25299 },
						_1 = null,
						_2 = null,
					},
					[64003] = new Feature
					{
						_0 = new int[] { 31958 },
						_1 = null,
						_2 = null,
					},
					[64004] = new Feature
					{
						_0 = new int[] { 23429 },
						_1 = null,
						_2 = null,
					},
					[64005] = new Feature
					{
						_0 = new int[] { 27934 },
						_1 = null,
						_2 = null,
					},
					[64006] = new Feature
					{
						_0 = new int[] { 26292 },
						_1 = null,
						_2 = null,
					},
					[64007] = new Feature
					{
						_0 = new int[] { 36667 },
						_1 = null,
						_2 = null,
					},
					[64008] = new Feature
					{
						_0 = new int[] { 34892 },
						_1 = null,
						_2 = null,
					},
					[64009] = new Feature
					{
						_0 = new int[] { 38477 },
						_1 = null,
						_2 = null,
					},
					[64010] = new Feature
					{
						_0 = new int[] { 35211 },
						_1 = null,
						_2 = null,
					},
					[64011] = new Feature
					{
						_0 = new int[] { 24275 },
						_1 = null,
						_2 = null,
					},
					[64012] = new Feature
					{
						_0 = new int[] { 20800 },
						_1 = null,
						_2 = null,
					},
					[64013] = new Feature
					{
						_0 = new int[] { 21952 },
						_1 = null,
						_2 = null,
					},
					[64016] = new Feature
					{
						_0 = new int[] { 22618 },
						_1 = null,
						_2 = null,
					},
					[64018] = new Feature
					{
						_0 = new int[] { 26228 },
						_1 = null,
						_2 = null,
					},
					[64021] = new Feature
					{
						_0 = new int[] { 20958 },
						_1 = null,
						_2 = null,
					},
					[64022] = new Feature
					{
						_0 = new int[] { 29482 },
						_1 = null,
						_2 = null,
					},
					[64023] = new Feature
					{
						_0 = new int[] { 30410 },
						_1 = null,
						_2 = null,
					},
					[64024] = new Feature
					{
						_0 = new int[] { 31036 },
						_1 = null,
						_2 = null,
					},
					[64025] = new Feature
					{
						_0 = new int[] { 31070 },
						_1 = null,
						_2 = null,
					},
					[64026] = new Feature
					{
						_0 = new int[] { 31077 },
						_1 = null,
						_2 = null,
					},
					[64027] = new Feature
					{
						_0 = new int[] { 31119 },
						_1 = null,
						_2 = null,
					},
					[64028] = new Feature
					{
						_0 = new int[] { 38742 },
						_1 = null,
						_2 = null,
					},
					[64029] = new Feature
					{
						_0 = new int[] { 31934 },
						_1 = null,
						_2 = null,
					},
					[64030] = new Feature
					{
						_0 = new int[] { 32701 },
						_1 = null,
						_2 = null,
					},
					[64032] = new Feature
					{
						_0 = new int[] { 34322 },
						_1 = null,
						_2 = null,
					},
					[64034] = new Feature
					{
						_0 = new int[] { 35576 },
						_1 = null,
						_2 = null,
					},
					[64037] = new Feature
					{
						_0 = new int[] { 36920 },
						_1 = null,
						_2 = null,
					},
					[64038] = new Feature
					{
						_0 = new int[] { 37117 },
						_1 = null,
						_2 = null,
					},
					[64042] = new Feature
					{
						_0 = new int[] { 39151 },
						_1 = null,
						_2 = null,
					},
					[64043] = new Feature
					{
						_0 = new int[] { 39164 },
						_1 = null,
						_2 = null,
					},
					[64044] = new Feature
					{
						_0 = new int[] { 39208 },
						_1 = null,
						_2 = null,
					},
					[64045] = new Feature
					{
						_0 = new int[] { 40372 },
						_1 = null,
						_2 = null,
					},
					[64046] = new Feature
					{
						_0 = new int[] { 37086 },
						_1 = null,
						_2 = null,
					},
					[64047] = new Feature
					{
						_0 = new int[] { 38583 },
						_1 = null,
						_2 = null,
					},
					[64048] = new Feature
					{
						_0 = new int[] { 20398 },
						_1 = null,
						_2 = null,
					},
					[64049] = new Feature
					{
						_0 = new int[] { 20711 },
						_1 = null,
						_2 = null,
					},
					[64050] = new Feature
					{
						_0 = new int[] { 20813 },
						_1 = null,
						_2 = null,
					},
					[64051] = new Feature
					{
						_0 = new int[] { 21193 },
						_1 = null,
						_2 = null,
					},
					[64052] = new Feature
					{
						_0 = new int[] { 21220 },
						_1 = null,
						_2 = null,
					},
					[64053] = new Feature
					{
						_0 = new int[] { 21329 },
						_1 = null,
						_2 = null,
					},
					[64054] = new Feature
					{
						_0 = new int[] { 21917 },
						_1 = null,
						_2 = null,
					},
					[64055] = new Feature
					{
						_0 = new int[] { 22022 },
						_1 = null,
						_2 = null,
					},
					[64056] = new Feature
					{
						_0 = new int[] { 22120 },
						_1 = null,
						_2 = null,
					},
					[64057] = new Feature
					{
						_0 = new int[] { 22592 },
						_1 = null,
						_2 = null,
					},
					[64058] = new Feature
					{
						_0 = new int[] { 22696 },
						_1 = null,
						_2 = null,
					},
					[64059] = new Feature
					{
						_0 = new int[] { 23652 },
						_1 = null,
						_2 = null,
					},
					[64060] = new Feature
					{
						_0 = new int[] { 23662 },
						_1 = null,
						_2 = null,
					},
					[64061] = new Feature
					{
						_0 = new int[] { 24724 },
						_1 = null,
						_2 = null,
					},
					[64062] = new Feature
					{
						_0 = new int[] { 24936 },
						_1 = null,
						_2 = null,
					},
					[64063] = new Feature
					{
						_0 = new int[] { 24974 },
						_1 = null,
						_2 = null,
					},
					[64064] = new Feature
					{
						_0 = new int[] { 25074 },
						_1 = null,
						_2 = null,
					},
					[64065] = new Feature
					{
						_0 = new int[] { 25935 },
						_1 = null,
						_2 = null,
					},
					[64066] = new Feature
					{
						_0 = new int[] { 26082 },
						_1 = null,
						_2 = null,
					},
					[64067] = new Feature
					{
						_0 = new int[] { 26257 },
						_1 = null,
						_2 = null,
					},
					[64068] = new Feature
					{
						_0 = new int[] { 26757 },
						_1 = null,
						_2 = null,
					},
					[64069] = new Feature
					{
						_0 = new int[] { 28023 },
						_1 = null,
						_2 = null,
					},
					[64070] = new Feature
					{
						_0 = new int[] { 28186 },
						_1 = null,
						_2 = null,
					},
					[64071] = new Feature
					{
						_0 = new int[] { 28450 },
						_1 = null,
						_2 = null,
					},
					[64072] = new Feature
					{
						_0 = new int[] { 29038 },
						_1 = null,
						_2 = null,
					},
					[64073] = new Feature
					{
						_0 = new int[] { 29227 },
						_1 = null,
						_2 = null,
					},
					[64074] = new Feature
					{
						_0 = new int[] { 29730 },
						_1 = null,
						_2 = null,
					},
					[64075] = new Feature
					{
						_0 = new int[] { 30865 },
						_1 = null,
						_2 = null,
					},
					[64076] = new Feature
					{
						_0 = new int[] { 31038 },
						_1 = null,
						_2 = null,
					},
					[64077] = new Feature
					{
						_0 = new int[] { 31049 },
						_1 = null,
						_2 = null,
					},
					[64078] = new Feature
					{
						_0 = new int[] { 31048 },
						_1 = null,
						_2 = null,
					},
					[64079] = new Feature
					{
						_0 = new int[] { 31056 },
						_1 = null,
						_2 = null,
					},
					[64080] = new Feature
					{
						_0 = new int[] { 31062 },
						_1 = null,
						_2 = null,
					},
					[64081] = new Feature
					{
						_0 = new int[] { 31069 },
						_1 = null,
						_2 = null,
					},
					[64082] = new Feature
					{
						_0 = new int[] { 31117 },
						_1 = null,
						_2 = null,
					},
					[64083] = new Feature
					{
						_0 = new int[] { 31118 },
						_1 = null,
						_2 = null,
					},
					[64084] = new Feature
					{
						_0 = new int[] { 31296 },
						_1 = null,
						_2 = null,
					},
					[64085] = new Feature
					{
						_0 = new int[] { 31361 },
						_1 = null,
						_2 = null,
					},
					[64086] = new Feature
					{
						_0 = new int[] { 31680 },
						_1 = null,
						_2 = null,
					},
					[64087] = new Feature
					{
						_0 = new int[] { 32244 },
						_1 = null,
						_2 = null,
					},
					[64088] = new Feature
					{
						_0 = new int[] { 32265 },
						_1 = null,
						_2 = null,
					},
					[64089] = new Feature
					{
						_0 = new int[] { 32321 },
						_1 = null,
						_2 = null,
					},
					[64090] = new Feature
					{
						_0 = new int[] { 32626 },
						_1 = null,
						_2 = null,
					},
					[64091] = new Feature
					{
						_0 = new int[] { 32773 },
						_1 = null,
						_2 = null,
					},
					[64092] = new Feature
					{
						_0 = new int[] { 33261 },
						_1 = null,
						_2 = null,
					},
					[64093] = new Feature
					{
						_0 = new int[] { 33401 },
						_1 = null,
						_2 = null,
					},
					[64094] = new Feature
					{
						_0 = new int[] { 33401 },
						_1 = null,
						_2 = null,
					},
					[64095] = new Feature
					{
						_0 = new int[] { 33879 },
						_1 = null,
						_2 = null,
					},
					[64096] = new Feature
					{
						_0 = new int[] { 35088 },
						_1 = null,
						_2 = null,
					},
					[64097] = new Feature
					{
						_0 = new int[] { 35222 },
						_1 = null,
						_2 = null,
					},
					[64098] = new Feature
					{
						_0 = new int[] { 35585 },
						_1 = null,
						_2 = null,
					},
					[64099] = new Feature
					{
						_0 = new int[] { 35641 },
						_1 = null,
						_2 = null,
					},
					[64100] = new Feature
					{
						_0 = new int[] { 36051 },
						_1 = null,
						_2 = null,
					},
					[64101] = new Feature
					{
						_0 = new int[] { 36104 },
						_1 = null,
						_2 = null,
					},
					[64102] = new Feature
					{
						_0 = new int[] { 36790 },
						_1 = null,
						_2 = null,
					},
					[64103] = new Feature
					{
						_0 = new int[] { 36920 },
						_1 = null,
						_2 = null,
					},
					[64104] = new Feature
					{
						_0 = new int[] { 38627 },
						_1 = null,
						_2 = null,
					},
					[64105] = new Feature
					{
						_0 = new int[] { 38911 },
						_1 = null,
						_2 = null,
					},
					[64106] = new Feature
					{
						_0 = new int[] { 38971 },
						_1 = null,
						_2 = null,
					},
					[64107] = new Feature
					{
						_0 = new int[] { 24693 },
						_1 = null,
						_2 = null,
					},
					[64108] = new Feature
					{
						_0 = new int[] { 148206 },
						_1 = null,
						_2 = null,
					},
					[64109] = new Feature
					{
						_0 = new int[] { 33304 },
						_1 = null,
						_2 = null,
					},
					[64112] = new Feature
					{
						_0 = new int[] { 20006 },
						_1 = null,
						_2 = null,
					},
					[64113] = new Feature
					{
						_0 = new int[] { 20917 },
						_1 = null,
						_2 = null,
					},
					[64114] = new Feature
					{
						_0 = new int[] { 20840 },
						_1 = null,
						_2 = null,
					},
					[64115] = new Feature
					{
						_0 = new int[] { 20352 },
						_1 = null,
						_2 = null,
					},
					[64116] = new Feature
					{
						_0 = new int[] { 20805 },
						_1 = null,
						_2 = null,
					},
					[64117] = new Feature
					{
						_0 = new int[] { 20864 },
						_1 = null,
						_2 = null,
					},
					[64118] = new Feature
					{
						_0 = new int[] { 21191 },
						_1 = null,
						_2 = null,
					},
					[64119] = new Feature
					{
						_0 = new int[] { 21242 },
						_1 = null,
						_2 = null,
					},
					[64120] = new Feature
					{
						_0 = new int[] { 21917 },
						_1 = null,
						_2 = null,
					},
					[64121] = new Feature
					{
						_0 = new int[] { 21845 },
						_1 = null,
						_2 = null,
					},
					[64122] = new Feature
					{
						_0 = new int[] { 21913 },
						_1 = null,
						_2 = null,
					},
					[64123] = new Feature
					{
						_0 = new int[] { 21986 },
						_1 = null,
						_2 = null,
					},
					[64124] = new Feature
					{
						_0 = new int[] { 22618 },
						_1 = null,
						_2 = null,
					},
					[64125] = new Feature
					{
						_0 = new int[] { 22707 },
						_1 = null,
						_2 = null,
					},
					[64126] = new Feature
					{
						_0 = new int[] { 22852 },
						_1 = null,
						_2 = null,
					},
					[64127] = new Feature
					{
						_0 = new int[] { 22868 },
						_1 = null,
						_2 = null,
					},
					[64128] = new Feature
					{
						_0 = new int[] { 23138 },
						_1 = null,
						_2 = null,
					},
					[64129] = new Feature
					{
						_0 = new int[] { 23336 },
						_1 = null,
						_2 = null,
					},
					[64130] = new Feature
					{
						_0 = new int[] { 24274 },
						_1 = null,
						_2 = null,
					},
					[64131] = new Feature
					{
						_0 = new int[] { 24281 },
						_1 = null,
						_2 = null,
					},
					[64132] = new Feature
					{
						_0 = new int[] { 24425 },
						_1 = null,
						_2 = null,
					},
					[64133] = new Feature
					{
						_0 = new int[] { 24493 },
						_1 = null,
						_2 = null,
					},
					[64134] = new Feature
					{
						_0 = new int[] { 24792 },
						_1 = null,
						_2 = null,
					},
					[64135] = new Feature
					{
						_0 = new int[] { 24910 },
						_1 = null,
						_2 = null,
					},
					[64136] = new Feature
					{
						_0 = new int[] { 24840 },
						_1 = null,
						_2 = null,
					},
					[64137] = new Feature
					{
						_0 = new int[] { 24974 },
						_1 = null,
						_2 = null,
					},
					[64138] = new Feature
					{
						_0 = new int[] { 24928 },
						_1 = null,
						_2 = null,
					},
					[64139] = new Feature
					{
						_0 = new int[] { 25074 },
						_1 = null,
						_2 = null,
					},
					[64140] = new Feature
					{
						_0 = new int[] { 25140 },
						_1 = null,
						_2 = null,
					},
					[64141] = new Feature
					{
						_0 = new int[] { 25540 },
						_1 = null,
						_2 = null,
					},
					[64142] = new Feature
					{
						_0 = new int[] { 25628 },
						_1 = null,
						_2 = null,
					},
					[64143] = new Feature
					{
						_0 = new int[] { 25682 },
						_1 = null,
						_2 = null,
					},
					[64144] = new Feature
					{
						_0 = new int[] { 25942 },
						_1 = null,
						_2 = null,
					},
					[64145] = new Feature
					{
						_0 = new int[] { 26228 },
						_1 = null,
						_2 = null,
					},
					[64146] = new Feature
					{
						_0 = new int[] { 26391 },
						_1 = null,
						_2 = null,
					},
					[64147] = new Feature
					{
						_0 = new int[] { 26395 },
						_1 = null,
						_2 = null,
					},
					[64148] = new Feature
					{
						_0 = new int[] { 26454 },
						_1 = null,
						_2 = null,
					},
					[64149] = new Feature
					{
						_0 = new int[] { 27513 },
						_1 = null,
						_2 = null,
					},
					[64150] = new Feature
					{
						_0 = new int[] { 27578 },
						_1 = null,
						_2 = null,
					},
					[64151] = new Feature
					{
						_0 = new int[] { 27969 },
						_1 = null,
						_2 = null,
					},
					[64152] = new Feature
					{
						_0 = new int[] { 28379 },
						_1 = null,
						_2 = null,
					},
					[64153] = new Feature
					{
						_0 = new int[] { 28363 },
						_1 = null,
						_2 = null,
					},
					[64154] = new Feature
					{
						_0 = new int[] { 28450 },
						_1 = null,
						_2 = null,
					},
					[64155] = new Feature
					{
						_0 = new int[] { 28702 },
						_1 = null,
						_2 = null,
					},
					[64156] = new Feature
					{
						_0 = new int[] { 29038 },
						_1 = null,
						_2 = null,
					},
					[64157] = new Feature
					{
						_0 = new int[] { 30631 },
						_1 = null,
						_2 = null,
					},
					[64158] = new Feature
					{
						_0 = new int[] { 29237 },
						_1 = null,
						_2 = null,
					},
					[64159] = new Feature
					{
						_0 = new int[] { 29359 },
						_1 = null,
						_2 = null,
					},
					[64160] = new Feature
					{
						_0 = new int[] { 29482 },
						_1 = null,
						_2 = null,
					},
					[64161] = new Feature
					{
						_0 = new int[] { 29809 },
						_1 = null,
						_2 = null,
					},
					[64162] = new Feature
					{
						_0 = new int[] { 29958 },
						_1 = null,
						_2 = null,
					},
					[64163] = new Feature
					{
						_0 = new int[] { 30011 },
						_1 = null,
						_2 = null,
					},
					[64164] = new Feature
					{
						_0 = new int[] { 30237 },
						_1 = null,
						_2 = null,
					},
					[64165] = new Feature
					{
						_0 = new int[] { 30239 },
						_1 = null,
						_2 = null,
					},
					[64166] = new Feature
					{
						_0 = new int[] { 30410 },
						_1 = null,
						_2 = null,
					},
					[64167] = new Feature
					{
						_0 = new int[] { 30427 },
						_1 = null,
						_2 = null,
					},
					[64168] = new Feature
					{
						_0 = new int[] { 30452 },
						_1 = null,
						_2 = null,
					},
					[64169] = new Feature
					{
						_0 = new int[] { 30538 },
						_1 = null,
						_2 = null,
					},
					[64170] = new Feature
					{
						_0 = new int[] { 30528 },
						_1 = null,
						_2 = null,
					},
					[64171] = new Feature
					{
						_0 = new int[] { 30924 },
						_1 = null,
						_2 = null,
					},
					[64172] = new Feature
					{
						_0 = new int[] { 31409 },
						_1 = null,
						_2 = null,
					},
					[64173] = new Feature
					{
						_0 = new int[] { 31680 },
						_1 = null,
						_2 = null,
					},
					[64174] = new Feature
					{
						_0 = new int[] { 31867 },
						_1 = null,
						_2 = null,
					},
					[64175] = new Feature
					{
						_0 = new int[] { 32091 },
						_1 = null,
						_2 = null,
					},
					[64176] = new Feature
					{
						_0 = new int[] { 32244 },
						_1 = null,
						_2 = null,
					},
					[64177] = new Feature
					{
						_0 = new int[] { 32574 },
						_1 = null,
						_2 = null,
					},
					[64178] = new Feature
					{
						_0 = new int[] { 32773 },
						_1 = null,
						_2 = null,
					},
					[64179] = new Feature
					{
						_0 = new int[] { 33618 },
						_1 = null,
						_2 = null,
					},
					[64180] = new Feature
					{
						_0 = new int[] { 33775 },
						_1 = null,
						_2 = null,
					},
					[64181] = new Feature
					{
						_0 = new int[] { 34681 },
						_1 = null,
						_2 = null,
					},
					[64182] = new Feature
					{
						_0 = new int[] { 35137 },
						_1 = null,
						_2 = null,
					},
					[64183] = new Feature
					{
						_0 = new int[] { 35206 },
						_1 = null,
						_2 = null,
					},
					[64184] = new Feature
					{
						_0 = new int[] { 35222 },
						_1 = null,
						_2 = null,
					},
					[64185] = new Feature
					{
						_0 = new int[] { 35519 },
						_1 = null,
						_2 = null,
					},
					[64186] = new Feature
					{
						_0 = new int[] { 35576 },
						_1 = null,
						_2 = null,
					},
					[64187] = new Feature
					{
						_0 = new int[] { 35531 },
						_1 = null,
						_2 = null,
					},
					[64188] = new Feature
					{
						_0 = new int[] { 35585 },
						_1 = null,
						_2 = null,
					},
					[64189] = new Feature
					{
						_0 = new int[] { 35582 },
						_1 = null,
						_2 = null,
					},
					[64190] = new Feature
					{
						_0 = new int[] { 35565 },
						_1 = null,
						_2 = null,
					},
					[64191] = new Feature
					{
						_0 = new int[] { 35641 },
						_1 = null,
						_2 = null,
					},
					[64192] = new Feature
					{
						_0 = new int[] { 35722 },
						_1 = null,
						_2 = null,
					},
					[64193] = new Feature
					{
						_0 = new int[] { 36104 },
						_1 = null,
						_2 = null,
					},
					[64194] = new Feature
					{
						_0 = new int[] { 36664 },
						_1 = null,
						_2 = null,
					},
					[64195] = new Feature
					{
						_0 = new int[] { 36978 },
						_1 = null,
						_2 = null,
					},
					[64196] = new Feature
					{
						_0 = new int[] { 37273 },
						_1 = null,
						_2 = null,
					},
					[64197] = new Feature
					{
						_0 = new int[] { 37494 },
						_1 = null,
						_2 = null,
					},
					[64198] = new Feature
					{
						_0 = new int[] { 38524 },
						_1 = null,
						_2 = null,
					},
					[64199] = new Feature
					{
						_0 = new int[] { 38627 },
						_1 = null,
						_2 = null,
					},
					[64200] = new Feature
					{
						_0 = new int[] { 38742 },
						_1 = null,
						_2 = null,
					},
					[64201] = new Feature
					{
						_0 = new int[] { 38875 },
						_1 = null,
						_2 = null,
					},
					[64202] = new Feature
					{
						_0 = new int[] { 38911 },
						_1 = null,
						_2 = null,
					},
					[64203] = new Feature
					{
						_0 = new int[] { 38923 },
						_1 = null,
						_2 = null,
					},
					[64204] = new Feature
					{
						_0 = new int[] { 38971 },
						_1 = null,
						_2 = null,
					},
					[64205] = new Feature
					{
						_0 = new int[] { 39698 },
						_1 = null,
						_2 = null,
					},
					[64206] = new Feature
					{
						_0 = new int[] { 40860 },
						_1 = null,
						_2 = null,
					},
					[64207] = new Feature
					{
						_0 = new int[] { 141386 },
						_1 = null,
						_2 = null,
					},
					[64208] = new Feature
					{
						_0 = new int[] { 141380 },
						_1 = null,
						_2 = null,
					},
					[64209] = new Feature
					{
						_0 = new int[] { 144341 },
						_1 = null,
						_2 = null,
					},
					[64210] = new Feature
					{
						_0 = new int[] { 15261 },
						_1 = null,
						_2 = null,
					},
					[64211] = new Feature
					{
						_0 = new int[] { 16408 },
						_1 = null,
						_2 = null,
					},
					[64212] = new Feature
					{
						_0 = new int[] { 16441 },
						_1 = null,
						_2 = null,
					},
					[64213] = new Feature
					{
						_0 = new int[] { 152137 },
						_1 = null,
						_2 = null,
					},
					[64214] = new Feature
					{
						_0 = new int[] { 154832 },
						_1 = null,
						_2 = null,
					},
					[64215] = new Feature
					{
						_0 = new int[] { 163539 },
						_1 = null,
						_2 = null,
					},
					[64216] = new Feature
					{
						_0 = new int[] { 40771 },
						_1 = null,
						_2 = null,
					},
					[64217] = new Feature
					{
						_0 = new int[] { 40846 },
						_1 = null,
						_2 = null,
					},
					[195072] = new Feature
					{
						_0 = new int[] { 38953 },
						_1 = null,
						_2 = null,
					},
					[195073] = new Feature
					{
						_0 = new int[] { 169398 },
						_1 = null,
						_2 = null,
					},
					[195074] = new Feature
					{
						_0 = new int[] { 39138 },
						_1 = null,
						_2 = null,
					},
					[195075] = new Feature
					{
						_0 = new int[] { 19251 },
						_1 = null,
						_2 = null,
					},
					[195076] = new Feature
					{
						_0 = new int[] { 39209 },
						_1 = null,
						_2 = null,
					},
					[195077] = new Feature
					{
						_0 = new int[] { 39335 },
						_1 = null,
						_2 = null,
					},
					[195078] = new Feature
					{
						_0 = new int[] { 39362 },
						_1 = null,
						_2 = null,
					},
					[195079] = new Feature
					{
						_0 = new int[] { 39422 },
						_1 = null,
						_2 = null,
					},
					[195080] = new Feature
					{
						_0 = new int[] { 19406 },
						_1 = null,
						_2 = null,
					},
					[195081] = new Feature
					{
						_0 = new int[] { 170800 },
						_1 = null,
						_2 = null,
					},
					[195082] = new Feature
					{
						_0 = new int[] { 39698 },
						_1 = null,
						_2 = null,
					},
					[195083] = new Feature
					{
						_0 = new int[] { 40000 },
						_1 = null,
						_2 = null,
					},
					[195084] = new Feature
					{
						_0 = new int[] { 40189 },
						_1 = null,
						_2 = null,
					},
					[195085] = new Feature
					{
						_0 = new int[] { 19662 },
						_1 = null,
						_2 = null,
					},
					[195086] = new Feature
					{
						_0 = new int[] { 19693 },
						_1 = null,
						_2 = null,
					},
					[195087] = new Feature
					{
						_0 = new int[] { 40295 },
						_1 = null,
						_2 = null,
					},
					[195088] = new Feature
					{
						_0 = new int[] { 172238 },
						_1 = null,
						_2 = null,
					},
					[195089] = new Feature
					{
						_0 = new int[] { 19704 },
						_1 = null,
						_2 = null,
					},
					[195090] = new Feature
					{
						_0 = new int[] { 172293 },
						_1 = null,
						_2 = null,
					},
					[195091] = new Feature
					{
						_0 = new int[] { 172558 },
						_1 = null,
						_2 = null,
					},
					[195092] = new Feature
					{
						_0 = new int[] { 172689 },
						_1 = null,
						_2 = null,
					},
					[195093] = new Feature
					{
						_0 = new int[] { 40635 },
						_1 = null,
						_2 = null,
					},
					[195094] = new Feature
					{
						_0 = new int[] { 19798 },
						_1 = null,
						_2 = null,
					},
					[195095] = new Feature
					{
						_0 = new int[] { 40697 },
						_1 = null,
						_2 = null,
					},
					[195096] = new Feature
					{
						_0 = new int[] { 40702 },
						_1 = null,
						_2 = null,
					},
					[195097] = new Feature
					{
						_0 = new int[] { 40709 },
						_1 = null,
						_2 = null,
					},
					[195098] = new Feature
					{
						_0 = new int[] { 40719 },
						_1 = null,
						_2 = null,
					},
					[195099] = new Feature
					{
						_0 = new int[] { 40726 },
						_1 = null,
						_2 = null,
					},
					[195100] = new Feature
					{
						_0 = new int[] { 40763 },
						_1 = null,
						_2 = null,
					},
					[195101] = new Feature
					{
						_0 = new int[] { 173568 },
						_1 = null,
						_2 = null,
					},
				},
				[64256] = new Dictionary<int, Feature>
				{
					[64256] = new Feature
					{
						_0 = new int[] { 102, 102 },
						_1 = 256,
						_2 = null,
					},
					[64257] = new Feature
					{
						_0 = new int[] { 102, 105 },
						_1 = 256,
						_2 = null,
					},
					[64258] = new Feature
					{
						_0 = new int[] { 102, 108 },
						_1 = 256,
						_2 = null,
					},
					[64259] = new Feature
					{
						_0 = new int[] { 102, 102, 105 },
						_1 = 256,
						_2 = null,
					},
					[64260] = new Feature
					{
						_0 = new int[] { 102, 102, 108 },
						_1 = 256,
						_2 = null,
					},
					[64261] = new Feature
					{
						_0 = new int[] { 383, 116 },
						_1 = 256,
						_2 = null,
					},
					[64262] = new Feature
					{
						_0 = new int[] { 115, 116 },
						_1 = 256,
						_2 = null,
					},
					[64275] = new Feature
					{
						_0 = new int[] { 1396, 1398 },
						_1 = 256,
						_2 = null,
					},
					[64276] = new Feature
					{
						_0 = new int[] { 1396, 1381 },
						_1 = 256,
						_2 = null,
					},
					[64277] = new Feature
					{
						_0 = new int[] { 1396, 1387 },
						_1 = 256,
						_2 = null,
					},
					[64278] = new Feature
					{
						_0 = new int[] { 1406, 1398 },
						_1 = 256,
						_2 = null,
					},
					[64279] = new Feature
					{
						_0 = new int[] { 1396, 1389 },
						_1 = 256,
						_2 = null,
					},
					[64285] = new Feature
					{
						_0 = new int[] { 1497, 1460 },
						_1 = 512,
						_2 = null,
					},
					[64286] = new Feature
					{
						_0 = null,
						_1 = 26,
						_2 = null,
					},
					[64287] = new Feature
					{
						_0 = new int[] { 1522, 1463 },
						_1 = 512,
						_2 = null,
					},
					[64288] = new Feature
					{
						_0 = new int[] { 1506 },
						_1 = 256,
						_2 = null,
					},
					[64289] = new Feature
					{
						_0 = new int[] { 1488 },
						_1 = 256,
						_2 = null,
					},
					[64290] = new Feature
					{
						_0 = new int[] { 1491 },
						_1 = 256,
						_2 = null,
					},
					[64291] = new Feature
					{
						_0 = new int[] { 1492 },
						_1 = 256,
						_2 = null,
					},
					[64292] = new Feature
					{
						_0 = new int[] { 1499 },
						_1 = 256,
						_2 = null,
					},
					[64293] = new Feature
					{
						_0 = new int[] { 1500 },
						_1 = 256,
						_2 = null,
					},
					[64294] = new Feature
					{
						_0 = new int[] { 1501 },
						_1 = 256,
						_2 = null,
					},
					[64295] = new Feature
					{
						_0 = new int[] { 1512 },
						_1 = 256,
						_2 = null,
					},
					[64296] = new Feature
					{
						_0 = new int[] { 1514 },
						_1 = 256,
						_2 = null,
					},
					[64297] = new Feature
					{
						_0 = new int[] { 43 },
						_1 = 256,
						_2 = null,
					},
					[64298] = new Feature
					{
						_0 = new int[] { 1513, 1473 },
						_1 = 512,
						_2 = null,
					},
					[64299] = new Feature
					{
						_0 = new int[] { 1513, 1474 },
						_1 = 512,
						_2 = null,
					},
					[64300] = new Feature
					{
						_0 = new int[] { 64329, 1473 },
						_1 = 512,
						_2 = null,
					},
					[64301] = new Feature
					{
						_0 = new int[] { 64329, 1474 },
						_1 = 512,
						_2 = null,
					},
					[64302] = new Feature
					{
						_0 = new int[] { 1488, 1463 },
						_1 = 512,
						_2 = null,
					},
					[64303] = new Feature
					{
						_0 = new int[] { 1488, 1464 },
						_1 = 512,
						_2 = null,
					},
					[64304] = new Feature
					{
						_0 = new int[] { 1488, 1468 },


						_1 = 512,
						_2 = null,
					},
					[64305] = new Feature
					{
						_0 = new int[] { 1489, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64306] = new Feature
					{
						_0 = new int[] { 1490, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64307] = new Feature
					{
						_0 = new int[] { 1491, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64308] = new Feature
					{
						_0 = new int[] { 1492, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64309] = new Feature
					{
						_0 = new int[] { 1493, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64310] = new Feature
					{
						_0 = new int[] { 1494, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64312] = new Feature
					{
						_0 = new int[] { 1496, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64313] = new Feature
					{
						_0 = new int[] { 1497, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64314] = new Feature
					{
						_0 = new int[] { 1498, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64315] = new Feature
					{
						_0 = new int[] { 1499, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64316] = new Feature
					{
						_0 = new int[] { 1500, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64318] = new Feature
					{
						_0 = new int[] { 1502, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64320] = new Feature
					{
						_0 = new int[] { 1504, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64321] = new Feature
					{
						_0 = new int[] { 1505, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64323] = new Feature
					{
						_0 = new int[] { 1507, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64324] = new Feature
					{
						_0 = new int[] { 1508, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64326] = new Feature
					{
						_0 = new int[] { 1510, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64327] = new Feature
					{
						_0 = new int[] { 1511, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64328] = new Feature
					{
						_0 = new int[] { 1512, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64329] = new Feature
					{
						_0 = new int[] { 1513, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64330] = new Feature
					{
						_0 = new int[] { 1514, 1468 },
						_1 = 512,
						_2 = null,
					},
					[64331] = new Feature
					{
						_0 = new int[] { 1493, 1465 },
						_1 = 512,
						_2 = null,
					},
					[64332] = new Feature
					{
						_0 = new int[] { 1489, 1471 },
						_1 = 512,
						_2 = null,
					},
					[64333] = new Feature
					{
						_0 = new int[] { 1499, 1471 },
						_1 = 512,
						_2 = null,
					},
					[64334] = new Feature
					{
						_0 = new int[] { 1508, 1471 },
						_1 = 512,
						_2 = null,
					},
					[64335] = new Feature
					{
						_0 = new int[] { 1488, 1500 },
						_1 = 256,
						_2 = null,
					},
					[64336] = new Feature
					{
						_0 = new int[] { 1649 },
						_1 = 256,
						_2 = null,
					},
					[64337] = new Feature
					{
						_0 = new int[] { 1649 },
						_1 = 256,
						_2 = null,
					},
					[64338] = new Feature
					{
						_0 = new int[] { 1659 },
						_1 = 256,
						_2 = null,
					},
					[64339] = new Feature
					{
						_0 = new int[] { 1659 },
						_1 = 256,
						_2 = null,
					},
					[64340] = new Feature
					{
						_0 = new int[] { 1659 },
						_1 = 256,
						_2 = null,
					},
					[64341] = new Feature
					{
						_0 = new int[] { 1659 },
						_1 = 256,
						_2 = null,
					},
					[64342] = new Feature
					{
						_0 = new int[] { 1662 },
						_1 = 256,
						_2 = null,
					},
					[64343] = new Feature
					{
						_0 = new int[] { 1662 },
						_1 = 256,
						_2 = null,
					},
					[64344] = new Feature
					{
						_0 = new int[] { 1662 },
						_1 = 256,
						_2 = null,
					},
					[64345] = new Feature
					{
						_0 = new int[] { 1662 },
						_1 = 256,
						_2 = null,
					},
					[64346] = new Feature
					{
						_0 = new int[] { 1664 },
						_1 = 256,
						_2 = null,
					},
					[64347] = new Feature
					{
						_0 = new int[] { 1664 },
						_1 = 256,
						_2 = null,
					},
					[64348] = new Feature
					{
						_0 = new int[] { 1664 },
						_1 = 256,
						_2 = null,
					},
					[64349] = new Feature
					{
						_0 = new int[] { 1664 },
						_1 = 256,
						_2 = null,
					},
					[64350] = new Feature
					{
						_0 = new int[] { 1658 },
						_1 = 256,
						_2 = null,
					},
					[64351] = new Feature
					{
						_0 = new int[] { 1658 },
						_1 = 256,
						_2 = null,
					},
					[64352] = new Feature
					{
						_0 = new int[] { 1658 },
						_1 = 256,
						_2 = null,
					},
					[64353] = new Feature
					{
						_0 = new int[] { 1658 },
						_1 = 256,
						_2 = null,
					},
					[64354] = new Feature
					{
						_0 = new int[] { 1663 },
						_1 = 256,
						_2 = null,
					},
					[64355] = new Feature
					{
						_0 = new int[] { 1663 },
						_1 = 256,
						_2 = null,
					},
					[64356] = new Feature
					{
						_0 = new int[] { 1663 },
						_1 = 256,
						_2 = null,
					},
					[64357] = new Feature
					{
						_0 = new int[] { 1663 },
						_1 = 256,
						_2 = null,
					},
					[64358] = new Feature
					{
						_0 = new int[] { 1657 },
						_1 = 256,
						_2 = null,
					},
					[64359] = new Feature
					{
						_0 = new int[] { 1657 },
						_1 = 256,
						_2 = null,
					},
					[64360] = new Feature
					{
						_0 = new int[] { 1657 },
						_1 = 256,
						_2 = null,
					},
					[64361] = new Feature
					{
						_0 = new int[] { 1657 },
						_1 = 256,
						_2 = null,
					},
					[64362] = new Feature
					{
						_0 = new int[] { 1700 },
						_1 = 256,
						_2 = null,
					},
					[64363] = new Feature
					{
						_0 = new int[] { 1700 },
						_1 = 256,
						_2 = null,
					},
					[64364] = new Feature
					{
						_0 = new int[] { 1700 },
						_1 = 256,
						_2 = null,
					},
					[64365] = new Feature
					{
						_0 = new int[] { 1700 },
						_1 = 256,
						_2 = null,
					},
					[64366] = new Feature
					{
						_0 = new int[] { 1702 },
						_1 = 256,
						_2 = null,
					},
					[64367] = new Feature
					{
						_0 = new int[] { 1702 },
						_1 = 256,
						_2 = null,
					},
					[64368] = new Feature
					{
						_0 = new int[] { 1702 },
						_1 = 256,
						_2 = null,
					},
					[64369] = new Feature
					{
						_0 = new int[] { 1702 },
						_1 = 256,
						_2 = null,
					},
					[64370] = new Feature
					{
						_0 = new int[] { 1668 },
						_1 = 256,
						_2 = null,
					},
					[64371] = new Feature
					{
						_0 = new int[] { 1668 },
						_1 = 256,
						_2 = null,
					},
					[64372] = new Feature
					{
						_0 = new int[] { 1668 },
						_1 = 256,
						_2 = null,
					},
					[64373] = new Feature
					{
						_0 = new int[] { 1668 },
						_1 = 256,
						_2 = null,
					},
					[64374] = new Feature
					{
						_0 = new int[] { 1667 },
						_1 = 256,
						_2 = null,
					},
					[64375] = new Feature
					{
						_0 = new int[] { 1667 },
						_1 = 256,
						_2 = null,
					},
					[64376] = new Feature
					{
						_0 = new int[] { 1667 },
						_1 = 256,
						_2 = null,
					},
					[64377] = new Feature
					{
						_0 = new int[] { 1667 },
						_1 = 256,
						_2 = null,
					},
					[64378] = new Feature
					{
						_0 = new int[] { 1670 },
						_1 = 256,
						_2 = null,
					},
					[64379] = new Feature
					{
						_0 = new int[] { 1670 },
						_1 = 256,
						_2 = null,
					},
					[64380] = new Feature
					{
						_0 = new int[] { 1670 },
						_1 = 256,
						_2 = null,
					},
					[64381] = new Feature
					{
						_0 = new int[] { 1670 },
						_1 = 256,
						_2 = null,
					},
					[64382] = new Feature
					{
						_0 = new int[] { 1671 },
						_1 = 256,
						_2 = null,
					},
					[64383] = new Feature
					{
						_0 = new int[] { 1671 },
						_1 = 256,
						_2 = null,
					},
					[64384] = new Feature
					{
						_0 = new int[] { 1671 },
						_1 = 256,
						_2 = null,
					},
					[64385] = new Feature
					{
						_0 = new int[] { 1671 },
						_1 = 256,
						_2 = null,
					},
					[64386] = new Feature
					{
						_0 = new int[] { 1677 },
						_1 = 256,
						_2 = null,
					},
					[64387] = new Feature
					{
						_0 = new int[] { 1677 },
						_1 = 256,
						_2 = null,
					},
					[64388] = new Feature
					{
						_0 = new int[] { 1676 },
						_1 = 256,
						_2 = null,
					},
					[64389] = new Feature
					{
						_0 = new int[] { 1676 },
						_1 = 256,
						_2 = null,
					},
					[64390] = new Feature
					{
						_0 = new int[] { 1678 },
						_1 = 256,
						_2 = null,
					},
					[64391] = new Feature
					{
						_0 = new int[] { 1678 },
						_1 = 256,
						_2 = null,
					},
					[64392] = new Feature
					{
						_0 = new int[] { 1672 },
						_1 = 256,
						_2 = null,
					},
					[64393] = new Feature
					{
						_0 = new int[] { 1672 },
						_1 = 256,
						_2 = null,
					},
					[64394] = new Feature
					{
						_0 = new int[] { 1688 },
						_1 = 256,
						_2 = null,
					},
					[64395] = new Feature
					{
						_0 = new int[] { 1688 },
						_1 = 256,
						_2 = null,
					},
					[64396] = new Feature
					{
						_0 = new int[] { 1681 },
						_1 = 256,
						_2 = null,
					},
					[64397] = new Feature
					{
						_0 = new int[] { 1681 },
						_1 = 256,
						_2 = null,
					},
					[64398] = new Feature
					{
						_0 = new int[] { 1705 },
						_1 = 256,
						_2 = null,
					},
					[64399] = new Feature
					{
						_0 = new int[] { 1705 },
						_1 = 256,
						_2 = null,
					},
					[64400] = new Feature
					{
						_0 = new int[] { 1705 },
						_1 = 256,
						_2 = null,
					},
					[64401] = new Feature
					{
						_0 = new int[] { 1705 },
						_1 = 256,
						_2 = null,
					},
					[64402] = new Feature
					{
						_0 = new int[] { 1711 },
						_1 = 256,
						_2 = null,
					},
					[64403] = new Feature
					{
						_0 = new int[] { 1711 },
						_1 = 256,
						_2 = null,
					},
					[64404] = new Feature
					{
						_0 = new int[] { 1711 },
						_1 = 256,
						_2 = null,
					},
					[64405] = new Feature
					{
						_0 = new int[] { 1711 },
						_1 = 256,
						_2 = null,
					},
					[64406] = new Feature
					{
						_0 = new int[] { 1715 },
						_1 = 256,
						_2 = null,
					},
					[64407] = new Feature
					{
						_0 = new int[] { 1715 },
						_1 = 256,
						_2 = null,
					},
					[64408] = new Feature
					{
						_0 = new int[] { 1715 },
						_1 = 256,
						_2 = null,
					},
					[64409] = new Feature
					{
						_0 = new int[] { 1715 },
						_1 = 256,
						_2 = null,
					},
					[64410] = new Feature
					{
						_0 = new int[] { 1713 },
						_1 = 256,
						_2 = null,
					},
					[64411] = new Feature
					{
						_0 = new int[] { 1713 },
						_1 = 256,
						_2 = null,
					},
					[64412] = new Feature
					{
						_0 = new int[] { 1713 },
						_1 = 256,
						_2 = null,
					},
					[64413] = new Feature
					{
						_0 = new int[] { 1713 },
						_1 = 256,
						_2 = null,
					},
					[64414] = new Feature
					{
						_0 = new int[] { 1722 },
						_1 = 256,
						_2 = null,
					},
					[64415] = new Feature
					{
						_0 = new int[] { 1722 },
						_1 = 256,
						_2 = null,
					},
					[64416] = new Feature
					{
						_0 = new int[] { 1723 },
						_1 = 256,
						_2 = null,
					},
					[64417] = new Feature
					{
						_0 = new int[] { 1723 },
						_1 = 256,
						_2 = null,
					},
					[64418] = new Feature
					{
						_0 = new int[] { 1723 },
						_1 = 256,
						_2 = null,
					},
					[64419] = new Feature
					{
						_0 = new int[] { 1723 },
						_1 = 256,
						_2 = null,
					},
					[64420] = new Feature
					{
						_0 = new int[] { 1728 },
						_1 = 256,
						_2 = null,
					},
					[64421] = new Feature
					{
						_0 = new int[] { 1728 },
						_1 = 256,
						_2 = null,
					},
					[64422] = new Feature
					{
						_0 = new int[] { 1729 },
						_1 = 256,
						_2 = null,
					},
					[64423] = new Feature
					{
						_0 = new int[] { 1729 },
						_1 = 256,
						_2 = null,
					},
					[64424] = new Feature
					{
						_0 = new int[] { 1729 },
						_1 = 256,
						_2 = null,
					},
					[64425] = new Feature
					{
						_0 = new int[] { 1729 },
						_1 = 256,
						_2 = null,
					},
					[64426] = new Feature
					{
						_0 = new int[] { 1726 },
						_1 = 256,
						_2 = null,
					},
					[64427] = new Feature
					{
						_0 = new int[] { 1726 },
						_1 = 256,
						_2 = null,
					},
					[64428] = new Feature
					{
						_0 = new int[] { 1726 },
						_1 = 256,
						_2 = null,
					},
					[64429] = new Feature
					{
						_0 = new int[] { 1726 },
						_1 = 256,
						_2 = null,
					},
					[64430] = new Feature
					{
						_0 = new int[] { 1746 },
						_1 = 256,
						_2 = null,
					},
					[64431] = new Feature
					{
						_0 = new int[] { 1746 },
						_1 = 256,
						_2 = null,
					},
					[64432] = new Feature
					{
						_0 = new int[] { 1747 },
						_1 = 256,
						_2 = null,
					},
					[64433] = new Feature
					{
						_0 = new int[] { 1747 },
						_1 = 256,
						_2 = null,
					},
					[64467] = new Feature
					{
						_0 = new int[] { 1709 },
						_1 = 256,
						_2 = null,
					},
					[64468] = new Feature
					{
						_0 = new int[] { 1709 },
						_1 = 256,
						_2 = null,
					},
					[64469] = new Feature
					{
						_0 = new int[] { 1709 },
						_1 = 256,
						_2 = null,
					},
					[64470] = new Feature
					{
						_0 = new int[] { 1709 },
						_1 = 256,
						_2 = null,
					},
					[64471] = new Feature
					{
						_0 = new int[] { 1735 },
						_1 = 256,
						_2 = null,
					},
					[64472] = new Feature
					{
						_0 = new int[] { 1735 },
						_1 = 256,
						_2 = null,
					},
					[64473] = new Feature
					{
						_0 = new int[] { 1734 },
						_1 = 256,
						_2 = null,
					},
					[64474] = new Feature
					{
						_0 = new int[] { 1734 },
						_1 = 256,
						_2 = null,
					},
					[64475] = new Feature
					{
						_0 = new int[] { 1736 },
						_1 = 256,
						_2 = null,
					},
					[64476] = new Feature
					{
						_0 = new int[] { 1736 },
						_1 = 256,
						_2 = null,
					},
					[64477] = new Feature
					{
						_0 = new int[] { 1655 },
						_1 = 256,
						_2 = null,
					},
					[64478] = new Feature
					{
						_0 = new int[] { 1739 },
						_1 = 256,
						_2 = null,
					},
					[64479] = new Feature
					{
						_0 = new int[] { 1739 },
						_1 = 256,
						_2 = null,
					},
					[64480] = new Feature
					{
						_0 = new int[] { 1733 },
						_1 = 256,
						_2 = null,
					},
					[64481] = new Feature
					{
						_0 = new int[] { 1733 },
						_1 = 256,
						_2 = null,
					},
					[64482] = new Feature
					{
						_0 = new int[] { 1737 },
						_1 = 256,
						_2 = null,
					},
					[64483] = new Feature
					{
						_0 = new int[] { 1737 },
						_1 = 256,
						_2 = null,
					},
					[64484] = new Feature
					{
						_0 = new int[] { 1744 },
						_1 = 256,
						_2 = null,
					},
					[64485] = new Feature
					{
						_0 = new int[] { 1744 },
						_1 = 256,
						_2 = null,
					},
					[64486] = new Feature
					{
						_0 = new int[] { 1744 },
						_1 = 256,
						_2 = null,
					},
					[64487] = new Feature
					{
						_0 = new int[] { 1744 },
						_1 = 256,
						_2 = null,
					},
					[64488] = new Feature
					{
						_0 = new int[] { 1609 },
						_1 = 256,
						_2 = null,
					},
					[64489] = new Feature
					{
						_0 = new int[] { 1609 },
						_1 = 256,
						_2 = null,
					},
					[64490] = new Feature
					{
						_0 = new int[] { 1574, 1575 },
						_1 = 256,
						_2 = null,
					},
					[64491] = new Feature
					{
						_0 = new int[] { 1574, 1575 },
						_1 = 256,
						_2 = null,
					},
					[64492] = new Feature
					{
						_0 = new int[] { 1574, 1749 },
						_1 = 256,
						_2 = null,
					},
					[64493] = new Feature
					{
						_0 = new int[] { 1574, 1749 },
						_1 = 256,
						_2 = null,
					},
					[64494] = new Feature
					{
						_0 = new int[] { 1574, 1608 },
						_1 = 256,
						_2 = null,
					},
					[64495] = new Feature
					{
						_0 = new int[] { 1574, 1608 },
						_1 = 256,
						_2 = null,
					},
					[64496] = new Feature
					{
						_0 = new int[] { 1574, 1735 },
						_1 = 256,
						_2 = null,
					},
					[64497] = new Feature
					{
						_0 = new int[] { 1574, 1735 },
						_1 = 256,
						_2 = null,
					},
					[64498] = new Feature
					{
						_0 = new int[] { 1574, 1734 },
						_1 = 256,
						_2 = null,
					},
					[64499] = new Feature
					{
						_0 = new int[] { 1574, 1734 },
						_1 = 256,
						_2 = null,
					},
					[64500] = new Feature
					{
						_0 = new int[] { 1574, 1736 },
						_1 = 256,
						_2 = null,
					},
					[64501] = new Feature
					{
						_0 = new int[] { 1574, 1736 },
						_1 = 256,
						_2 = null,
					},
					[64502] = new Feature
					{
						_0 = new int[] { 1574, 1744 },
						_1 = 256,
						_2 = null,
					},
					[64503] = new Feature
					{
						_0 = new int[] { 1574, 1744 },
						_1 = 256,
						_2 = null,
					},
					[64504] = new Feature
					{
						_0 = new int[] { 1574, 1744 },
						_1 = 256,
						_2 = null,
					},
					[64505] = new Feature
					{
						_0 = new int[] { 1574, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64506] = new Feature
					{
						_0 = new int[] { 1574, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64507] = new Feature
					{
						_0 = new int[] { 1574, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64508] = new Feature
					{
						_0 = new int[] { 1740 },
						_1 = 256,
						_2 = null,
					},
					[64509] = new Feature
					{
						_0 = new int[] { 1740 },
						_1 = 256,
						_2 = null,
					},
					[64510] = new Feature
					{
						_0 = new int[] { 1740 },
						_1 = 256,
						_2 = null,
					},
					[64511] = new Feature
					{
						_0 = new int[] { 1740 },
						_1 = 256,
						_2 = null,
					},
				},
				[64512] = new Dictionary<int, Feature>
				{
					[64512] = new Feature
					{
						_0 = new int[] { 1574, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64513] = new Feature
					{
						_0 = new int[] { 1574, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64514] = new Feature
					{
						_0 = new int[] { 1574, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64515] = new Feature
					{
						_0 = new int[] { 1574, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64516] = new Feature
					{
						_0 = new int[] { 1574, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64517] = new Feature
					{
						_0 = new int[] { 1576, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64518] = new Feature
					{
						_0 = new int[] { 1576, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64519] = new Feature
					{
						_0 = new int[] { 1576, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64520] = new Feature
					{
						_0 = new int[] { 1576, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64521] = new Feature
					{
						_0 = new int[] { 1576, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64522] = new Feature
					{
						_0 = new int[] { 1576, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64523] = new Feature
					{
						_0 = new int[] { 1578, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64524] = new Feature
					{
						_0 = new int[] { 1578, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64525] = new Feature
					{
						_0 = new int[] { 1578, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64526] = new Feature
					{
						_0 = new int[] { 1578, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64527] = new Feature
					{
						_0 = new int[] { 1578, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64528] = new Feature
					{
						_0 = new int[] { 1578, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64529] = new Feature
					{
						_0 = new int[] { 1579, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64530] = new Feature
					{
						_0 = new int[] { 1579, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64531] = new Feature
					{
						_0 = new int[] { 1579, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64532] = new Feature
					{
						_0 = new int[] { 1579, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64533] = new Feature
					{
						_0 = new int[] { 1580, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64534] = new Feature
					{
						_0 = new int[] { 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64535] = new Feature
					{
						_0 = new int[] { 1581, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64536] = new Feature
					{
						_0 = new int[] { 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64537] = new Feature
					{
						_0 = new int[] { 1582, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64538] = new Feature
					{
						_0 = new int[] { 1582, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64539] = new Feature
					{
						_0 = new int[] { 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64540] = new Feature
					{
						_0 = new int[] { 1587, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64541] = new Feature
					{
						_0 = new int[] { 1587, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64542] = new Feature
					{
						_0 = new int[] { 1587, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64543] = new Feature
					{
						_0 = new int[] { 1587, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64544] = new Feature
					{
						_0 = new int[] { 1589, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64545] = new Feature
					{
						_0 = new int[] { 1589, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64546] = new Feature
					{
						_0 = new int[] { 1590, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64547] = new Feature
					{
						_0 = new int[] { 1590, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64548] = new Feature
					{
						_0 = new int[] { 1590, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64549] = new Feature
					{
						_0 = new int[] { 1590, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64550] = new Feature
					{
						_0 = new int[] { 1591, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64551] = new Feature
					{
						_0 = new int[] { 1591, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64552] = new Feature
					{
						_0 = new int[] { 1592, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64553] = new Feature
					{
						_0 = new int[] { 1593, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64554] = new Feature
					{
						_0 = new int[] { 1593, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64555] = new Feature
					{
						_0 = new int[] { 1594, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64556] = new Feature
					{
						_0 = new int[] { 1594, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64557] = new Feature
					{
						_0 = new int[] { 1601, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64558] = new Feature
					{
						_0 = new int[] { 1601, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64559] = new Feature
					{
						_0 = new int[] { 1601, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64560] = new Feature
					{
						_0 = new int[] { 1601, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64561] = new Feature
					{
						_0 = new int[] { 1601, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64562] = new Feature
					{
						_0 = new int[] { 1601, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64563] = new Feature
					{
						_0 = new int[] { 1602, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64564] = new Feature
					{
						_0 = new int[] { 1602, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64565] = new Feature
					{
						_0 = new int[] { 1602, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64566] = new Feature
					{
						_0 = new int[] { 1602, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64567] = new Feature
					{
						_0 = new int[] { 1603, 1575 },
						_1 = 256,
						_2 = null,
					},
					[64568] = new Feature
					{
						_0 = new int[] { 1603, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64569] = new Feature
					{
						_0 = new int[] { 1603, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64570] = new Feature
					{
						_0 = new int[] { 1603, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64571] = new Feature
					{
						_0 = new int[] { 1603, 1604 },
						_1 = 256,
						_2 = null,
					},
					[64572] = new Feature
					{
						_0 = new int[] { 1603, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64573] = new Feature
					{
						_0 = new int[] { 1603, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64574] = new Feature
					{
						_0 = new int[] { 1603, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64575] = new Feature
					{
						_0 = new int[] { 1604, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64576] = new Feature
					{
						_0 = new int[] { 1604, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64577] = new Feature
					{
						_0 = new int[] { 1604, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64578] = new Feature
					{
						_0 = new int[] { 1604, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64579] = new Feature
					{
						_0 = new int[] { 1604, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64580] = new Feature
					{
						_0 = new int[] { 1604, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64581] = new Feature
					{
						_0 = new int[] { 1605, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64582] = new Feature
					{
						_0 = new int[] { 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64583] = new Feature
					{
						_0 = new int[] { 1605, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64584] = new Feature
					{
						_0 = new int[] { 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64585] = new Feature
					{
						_0 = new int[] { 1605, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64586] = new Feature
					{
						_0 = new int[] { 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64587] = new Feature
					{
						_0 = new int[] { 1606, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64588] = new Feature
					{
						_0 = new int[] { 1606, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64589] = new Feature
					{
						_0 = new int[] { 1606, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64590] = new Feature
					{
						_0 = new int[] { 1606, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64591] = new Feature
					{
						_0 = new int[] { 1606, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64592] = new Feature
					{
						_0 = new int[] { 1606, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64593] = new Feature
					{
						_0 = new int[] { 1607, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64594] = new Feature
					{
						_0 = new int[] { 1607, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64595] = new Feature
					{
						_0 = new int[] { 1607, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64596] = new Feature
					{
						_0 = new int[] { 1607, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64597] = new Feature
					{
						_0 = new int[] { 1610, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64598] = new Feature
					{
						_0 = new int[] { 1610, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64599] = new Feature
					{
						_0 = new int[] { 1610, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64600] = new Feature
					{
						_0 = new int[] { 1610, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64601] = new Feature
					{
						_0 = new int[] { 1610, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64602] = new Feature
					{
						_0 = new int[] { 1610, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64603] = new Feature
					{
						_0 = new int[] { 1584, 1648 },
						_1 = 256,
						_2 = null,
					},
					[64604] = new Feature
					{
						_0 = new int[] { 1585, 1648 },
						_1 = 256,
						_2 = null,
					},
					[64605] = new Feature
					{
						_0 = new int[] { 1609, 1648 },
						_1 = 256,
						_2 = null,
					},
					[64606] = new Feature
					{
						_0 = new int[] { 32, 1612, 1617 },
						_1 = 256,
						_2 = null,
					},
					[64607] = new Feature
					{
						_0 = new int[] { 32, 1613, 1617 },
						_1 = 256,
						_2 = null,
					},
					[64608] = new Feature
					{
						_0 = new int[] { 32, 1614, 1617 },
						_1 = 256,
						_2 = null,
					},
					[64609] = new Feature
					{
						_0 = new int[] { 32, 1615, 1617 },
						_1 = 256,
						_2 = null,
					},
					[64610] = new Feature
					{
						_0 = new int[] { 32, 1616, 1617 },
						_1 = 256,
						_2 = null,
					},
					[64611] = new Feature
					{
						_0 = new int[] { 32, 1617, 1648 },
						_1 = 256,
						_2 = null,
					},
					[64612] = new Feature
					{
						_0 = new int[] { 1574, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64613] = new Feature
					{
						_0 = new int[] { 1574, 1586 },
						_1 = 256,
						_2 = null,
					},
					[64614] = new Feature
					{
						_0 = new int[] { 1574, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64615] = new Feature
					{
						_0 = new int[] { 1574, 1606 },
						_1 = 256,
						_2 = null,
					},
					[64616] = new Feature
					{
						_0 = new int[] { 1574, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64617] = new Feature
					{
						_0 = new int[] { 1574, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64618] = new Feature
					{
						_0 = new int[] { 1576, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64619] = new Feature
					{
						_0 = new int[] { 1576, 1586 },
						_1 = 256,
						_2 = null,
					},
					[64620] = new Feature
					{
						_0 = new int[] { 1576, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64621] = new Feature
					{
						_0 = new int[] { 1576, 1606 },
						_1 = 256,
						_2 = null,
					},
					[64622] = new Feature
					{
						_0 = new int[] { 1576, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64623] = new Feature
					{
						_0 = new int[] { 1576, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64624] = new Feature
					{
						_0 = new int[] { 1578, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64625] = new Feature
					{
						_0 = new int[] { 1578, 1586 },
						_1 = 256,
						_2 = null,
					},
					[64626] = new Feature
					{
						_0 = new int[] { 1578, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64627] = new Feature
					{
						_0 = new int[] { 1578, 1606 },
						_1 = 256,
						_2 = null,
					},
					[64628] = new Feature
					{
						_0 = new int[] { 1578, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64629] = new Feature
					{
						_0 = new int[] { 1578, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64630] = new Feature
					{
						_0 = new int[] { 1579, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64631] = new Feature
					{
						_0 = new int[] { 1579, 1586 },
						_1 = 256,
						_2 = null,
					},
					[64632] = new Feature
					{
						_0 = new int[] { 1579, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64633] = new Feature
					{
						_0 = new int[] { 1579, 1606 },
						_1 = 256,
						_2 = null,
					},
					[64634] = new Feature
					{
						_0 = new int[] { 1579, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64635] = new Feature
					{
						_0 = new int[] { 1579, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64636] = new Feature
					{
						_0 = new int[] { 1601, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64637] = new Feature
					{
						_0 = new int[] { 1601, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64638] = new Feature
					{
						_0 = new int[] { 1602, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64639] = new Feature
					{
						_0 = new int[] { 1602, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64640] = new Feature
					{
						_0 = new int[] { 1603, 1575 },
						_1 = 256,
						_2 = null,
					},
					[64641] = new Feature
					{
						_0 = new int[] { 1603, 1604 },
						_1 = 256,
						_2 = null,
					},
					[64642] = new Feature
					{
						_0 = new int[] { 1603, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64643] = new Feature
					{
						_0 = new int[] { 1603, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64644] = new Feature
					{
						_0 = new int[] { 1603, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64645] = new Feature
					{
						_0 = new int[] { 1604, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64646] = new Feature
					{
						_0 = new int[] { 1604, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64647] = new Feature
					{
						_0 = new int[] { 1604, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64648] = new Feature
					{
						_0 = new int[] { 1605, 1575 },
						_1 = 256,
						_2 = null,
					},
					[64649] = new Feature
					{
						_0 = new int[] { 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64650] = new Feature
					{
						_0 = new int[] { 1606, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64651] = new Feature
					{
						_0 = new int[] { 1606, 1586 },
						_1 = 256,
						_2 = null,
					},
					[64652] = new Feature
					{
						_0 = new int[] { 1606, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64653] = new Feature
					{
						_0 = new int[] { 1606, 1606 },
						_1 = 256,
						_2 = null,
					},
					[64654] = new Feature
					{
						_0 = new int[] { 1606, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64655] = new Feature
					{
						_0 = new int[] { 1606, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64656] = new Feature
					{
						_0 = new int[] { 1609, 1648 },
						_1 = 256,
						_2 = null,
					},
					[64657] = new Feature
					{
						_0 = new int[] { 1610, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64658] = new Feature
					{
						_0 = new int[] { 1610, 1586 },
						_1 = 256,
						_2 = null,
					},
					[64659] = new Feature
					{
						_0 = new int[] { 1610, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64660] = new Feature
					{
						_0 = new int[] { 1610, 1606 },
						_1 = 256,
						_2 = null,
					},
					[64661] = new Feature
					{
						_0 = new int[] { 1610, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64662] = new Feature
					{
						_0 = new int[] { 1610, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64663] = new Feature
					{
						_0 = new int[] { 1574, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64664] = new Feature
					{
						_0 = new int[] { 1574, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64665] = new Feature
					{
						_0 = new int[] { 1574, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64666] = new Feature
					{
						_0 = new int[] { 1574, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64667] = new Feature
					{
						_0 = new int[] { 1574, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64668] = new Feature
					{
						_0 = new int[] { 1576, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64669] = new Feature
					{
						_0 = new int[] { 1576, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64670] = new Feature
					{
						_0 = new int[] { 1576, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64671] = new Feature
					{
						_0 = new int[] { 1576, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64672] = new Feature
					{
						_0 = new int[] { 1576, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64673] = new Feature
					{
						_0 = new int[] { 1578, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64674] = new Feature
					{
						_0 = new int[] { 1578, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64675] = new Feature
					{
						_0 = new int[] { 1578, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64676] = new Feature
					{
						_0 = new int[] { 1578, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64677] = new Feature
					{
						_0 = new int[] { 1578, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64678] = new Feature
					{
						_0 = new int[] { 1579, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64679] = new Feature
					{
						_0 = new int[] { 1580, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64680] = new Feature
					{
						_0 = new int[] { 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64681] = new Feature
					{
						_0 = new int[] { 1581, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64682] = new Feature
					{
						_0 = new int[] { 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64683] = new Feature
					{
						_0 = new int[] { 1582, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64684] = new Feature
					{
						_0 = new int[] { 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64685] = new Feature
					{
						_0 = new int[] { 1587, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64686] = new Feature
					{
						_0 = new int[] { 1587, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64687] = new Feature
					{
						_0 = new int[] { 1587, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64688] = new Feature
					{
						_0 = new int[] { 1587, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64689] = new Feature
					{
						_0 = new int[] { 1589, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64690] = new Feature
					{
						_0 = new int[] { 1589, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64691] = new Feature
					{
						_0 = new int[] { 1589, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64692] = new Feature
					{
						_0 = new int[] { 1590, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64693] = new Feature
					{
						_0 = new int[] { 1590, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64694] = new Feature
					{
						_0 = new int[] { 1590, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64695] = new Feature
					{
						_0 = new int[] { 1590, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64696] = new Feature
					{
						_0 = new int[] { 1591, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64697] = new Feature
					{
						_0 = new int[] { 1592, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64698] = new Feature
					{
						_0 = new int[] { 1593, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64699] = new Feature
					{
						_0 = new int[] { 1593, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64700] = new Feature
					{
						_0 = new int[] { 1594, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64701] = new Feature
					{
						_0 = new int[] { 1594, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64702] = new Feature
					{
						_0 = new int[] { 1601, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64703] = new Feature
					{
						_0 = new int[] { 1601, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64704] = new Feature
					{
						_0 = new int[] { 1601, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64705] = new Feature
					{
						_0 = new int[] { 1601, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64706] = new Feature
					{
						_0 = new int[] { 1602, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64707] = new Feature
					{
						_0 = new int[] { 1602, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64708] = new Feature
					{
						_0 = new int[] { 1603, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64709] = new Feature
					{
						_0 = new int[] { 1603, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64710] = new Feature
					{
						_0 = new int[] { 1603, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64711] = new Feature
					{
						_0 = new int[] { 1603, 1604 },
						_1 = 256,
						_2 = null,
					},
					[64712] = new Feature
					{
						_0 = new int[] { 1603, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64713] = new Feature
					{
						_0 = new int[] { 1604, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64714] = new Feature
					{
						_0 = new int[] { 1604, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64715] = new Feature
					{
						_0 = new int[] { 1604, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64716] = new Feature
					{
						_0 = new int[] { 1604, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64717] = new Feature
					{
						_0 = new int[] { 1604, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64718] = new Feature
					{
						_0 = new int[] { 1605, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64719] = new Feature
					{
						_0 = new int[] { 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64720] = new Feature
					{
						_0 = new int[] { 1605, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64721] = new Feature
					{
						_0 = new int[] { 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64722] = new Feature
					{
						_0 = new int[] { 1606, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64723] = new Feature
					{
						_0 = new int[] { 1606, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64724] = new Feature
					{
						_0 = new int[] { 1606, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64725] = new Feature
					{
						_0 = new int[] { 1606, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64726] = new Feature
					{
						_0 = new int[] { 1606, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64727] = new Feature
					{
						_0 = new int[] { 1607, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64728] = new Feature
					{
						_0 = new int[] { 1607, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64729] = new Feature
					{
						_0 = new int[] { 1607, 1648 },
						_1 = 256,
						_2 = null,
					},
					[64730] = new Feature
					{
						_0 = new int[] { 1610, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64731] = new Feature
					{
						_0 = new int[] { 1610, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64732] = new Feature
					{
						_0 = new int[] { 1610, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64733] = new Feature
					{
						_0 = new int[] { 1610, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64734] = new Feature
					{
						_0 = new int[] { 1610, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64735] = new Feature
					{
						_0 = new int[] { 1574, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64736] = new Feature
					{
						_0 = new int[] { 1574, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64737] = new Feature
					{
						_0 = new int[] { 1576, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64738] = new Feature
					{
						_0 = new int[] { 1576, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64739] = new Feature
					{
						_0 = new int[] { 1578, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64740] = new Feature
					{
						_0 = new int[] { 1578, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64741] = new Feature
					{
						_0 = new int[] { 1579, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64742] = new Feature
					{
						_0 = new int[] { 1579, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64743] = new Feature
					{
						_0 = new int[] { 1587, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64744] = new Feature
					{
						_0 = new int[] { 1587, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64745] = new Feature
					{
						_0 = new int[] { 1588, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64746] = new Feature
					{
						_0 = new int[] { 1588, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64747] = new Feature
					{
						_0 = new int[] { 1603, 1604 },
						_1 = 256,
						_2 = null,
					},
					[64748] = new Feature
					{
						_0 = new int[] { 1603, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64749] = new Feature
					{
						_0 = new int[] { 1604, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64750] = new Feature
					{
						_0 = new int[] { 1606, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64751] = new Feature
					{
						_0 = new int[] { 1606, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64752] = new Feature
					{
						_0 = new int[] { 1610, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64753] = new Feature
					{
						_0 = new int[] { 1610, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64754] = new Feature
					{
						_0 = new int[] { 1600, 1614, 1617 },
						_1 = 256,
						_2 = null,
					},
					[64755] = new Feature
					{
						_0 = new int[] { 1600, 1615, 1617 },
						_1 = 256,
						_2 = null,
					},
					[64756] = new Feature
					{
						_0 = new int[] { 1600, 1616, 1617 },
						_1 = 256,
						_2 = null,
					},
					[64757] = new Feature
					{
						_0 = new int[] { 1591, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64758] = new Feature
					{
						_0 = new int[] { 1591, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64759] = new Feature
					{
						_0 = new int[] { 1593, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64760] = new Feature
					{
						_0 = new int[] { 1593, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64761] = new Feature
					{
						_0 = new int[] { 1594, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64762] = new Feature
					{
						_0 = new int[] { 1594, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64763] = new Feature
					{
						_0 = new int[] { 1587, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64764] = new Feature
					{
						_0 = new int[] { 1587, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64765] = new Feature
					{
						_0 = new int[] { 1588, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64766] = new Feature
					{
						_0 = new int[] { 1588, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64767] = new Feature
					{
						_0 = new int[] { 1581, 1609 },
						_1 = 256,
						_2 = null,
					},
				},
				[64768] = new Dictionary<int, Feature>
				{
					[64768] = new Feature
					{
						_0 = new int[] { 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64769] = new Feature
					{
						_0 = new int[] { 1580, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64770] = new Feature
					{
						_0 = new int[] { 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64771] = new Feature
					{
						_0 = new int[] { 1582, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64772] = new Feature
					{
						_0 = new int[] { 1582, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64773] = new Feature
					{
						_0 = new int[] { 1589, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64774] = new Feature
					{
						_0 = new int[] { 1589, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64775] = new Feature
					{
						_0 = new int[] { 1590, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64776] = new Feature
					{
						_0 = new int[] { 1590, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64777] = new Feature
					{
						_0 = new int[] { 1588, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64778] = new Feature
					{
						_0 = new int[] { 1588, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64779] = new Feature
					{
						_0 = new int[] { 1588, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64780] = new Feature
					{
						_0 = new int[] { 1588, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64781] = new Feature
					{
						_0 = new int[] { 1588, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64782] = new Feature
					{
						_0 = new int[] { 1587, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64783] = new Feature
					{
						_0 = new int[] { 1589, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64784] = new Feature
					{
						_0 = new int[] { 1590, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64785] = new Feature
					{
						_0 = new int[] { 1591, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64786] = new Feature
					{
						_0 = new int[] { 1591, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64787] = new Feature
					{
						_0 = new int[] { 1593, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64788] = new Feature
					{
						_0 = new int[] { 1593, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64789] = new Feature
					{
						_0 = new int[] { 1594, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64790] = new Feature
					{
						_0 = new int[] { 1594, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64791] = new Feature
					{
						_0 = new int[] { 1587, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64792] = new Feature
					{
						_0 = new int[] { 1587, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64793] = new Feature
					{
						_0 = new int[] { 1588, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64794] = new Feature
					{
						_0 = new int[] { 1588, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64795] = new Feature
					{
						_0 = new int[] { 1581, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64796] = new Feature
					{
						_0 = new int[] { 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64797] = new Feature
					{
						_0 = new int[] { 1580, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64798] = new Feature
					{
						_0 = new int[] { 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64799] = new Feature
					{
						_0 = new int[] { 1582, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64800] = new Feature
					{
						_0 = new int[] { 1582, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64801] = new Feature
					{
						_0 = new int[] { 1589, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64802] = new Feature
					{
						_0 = new int[] { 1589, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64803] = new Feature
					{
						_0 = new int[] { 1590, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64804] = new Feature
					{
						_0 = new int[] { 1590, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64805] = new Feature
					{
						_0 = new int[] { 1588, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64806] = new Feature
					{
						_0 = new int[] { 1588, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64807] = new Feature
					{
						_0 = new int[] { 1588, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64808] = new Feature
					{
						_0 = new int[] { 1588, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64809] = new Feature
					{
						_0 = new int[] { 1588, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64810] = new Feature
					{
						_0 = new int[] { 1587, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64811] = new Feature
					{
						_0 = new int[] { 1589, 1585 },
						_1 = 256,
						_2 = null,
					},
					[64812] = new Feature
					{
						_0 = new int[] { 1590, 1585 },
						_1 = 256,


						_2 = null,
					},
					[64813] = new Feature
					{
						_0 = new int[] { 1588, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64814] = new Feature
					{
						_0 = new int[] { 1588, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64815] = new Feature
					{
						_0 = new int[] { 1588, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64816] = new Feature
					{
						_0 = new int[] { 1588, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64817] = new Feature
					{
						_0 = new int[] { 1587, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64818] = new Feature
					{
						_0 = new int[] { 1588, 1607 },
						_1 = 256,
						_2 = null,
					},
					[64819] = new Feature
					{
						_0 = new int[] { 1591, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64820] = new Feature
					{
						_0 = new int[] { 1587, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64821] = new Feature
					{
						_0 = new int[] { 1587, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64822] = new Feature
					{
						_0 = new int[] { 1587, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64823] = new Feature
					{
						_0 = new int[] { 1588, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64824] = new Feature
					{
						_0 = new int[] { 1588, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64825] = new Feature
					{
						_0 = new int[] { 1588, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64826] = new Feature
					{
						_0 = new int[] { 1591, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64827] = new Feature
					{
						_0 = new int[] { 1592, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64828] = new Feature
					{
						_0 = new int[] { 1575, 1611 },
						_1 = 256,
						_2 = null,
					},
					[64829] = new Feature
					{
						_0 = new int[] { 1575, 1611 },
						_1 = 256,
						_2 = null,
					},
					[64848] = new Feature
					{
						_0 = new int[] { 1578, 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64849] = new Feature
					{
						_0 = new int[] { 1578, 1581, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64850] = new Feature
					{
						_0 = new int[] { 1578, 1581, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64851] = new Feature
					{
						_0 = new int[] { 1578, 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64852] = new Feature
					{
						_0 = new int[] { 1578, 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64853] = new Feature
					{
						_0 = new int[] { 1578, 1605, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64854] = new Feature
					{
						_0 = new int[] { 1578, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64855] = new Feature
					{
						_0 = new int[] { 1578, 1605, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64856] = new Feature
					{
						_0 = new int[] { 1580, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64857] = new Feature
					{
						_0 = new int[] { 1580, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64858] = new Feature
					{
						_0 = new int[] { 1581, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64859] = new Feature
					{
						_0 = new int[] { 1581, 1605, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64860] = new Feature
					{
						_0 = new int[] { 1587, 1581, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64861] = new Feature
					{
						_0 = new int[] { 1587, 1580, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64862] = new Feature
					{
						_0 = new int[] { 1587, 1580, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64863] = new Feature
					{
						_0 = new int[] { 1587, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64864] = new Feature
					{
						_0 = new int[] { 1587, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64865] = new Feature
					{
						_0 = new int[] { 1587, 1605, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64866] = new Feature
					{
						_0 = new int[] { 1587, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64867] = new Feature
					{
						_0 = new int[] { 1587, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64868] = new Feature
					{
						_0 = new int[] { 1589, 1581, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64869] = new Feature
					{
						_0 = new int[] { 1589, 1581, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64870] = new Feature
					{
						_0 = new int[] { 1589, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64871] = new Feature
					{
						_0 = new int[] { 1588, 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64872] = new Feature
					{
						_0 = new int[] { 1588, 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64873] = new Feature
					{
						_0 = new int[] { 1588, 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64874] = new Feature
					{
						_0 = new int[] { 1588, 1605, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64875] = new Feature
					{
						_0 = new int[] { 1588, 1605, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64876] = new Feature
					{
						_0 = new int[] { 1588, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64877] = new Feature
					{
						_0 = new int[] { 1588, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64878] = new Feature
					{
						_0 = new int[] { 1590, 1581, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64879] = new Feature
					{
						_0 = new int[] { 1590, 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64880] = new Feature
					{
						_0 = new int[] { 1590, 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64881] = new Feature
					{
						_0 = new int[] { 1591, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64882] = new Feature
					{
						_0 = new int[] { 1591, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64883] = new Feature
					{
						_0 = new int[] { 1591, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64884] = new Feature
					{
						_0 = new int[] { 1591, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64885] = new Feature
					{
						_0 = new int[] { 1593, 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64886] = new Feature
					{
						_0 = new int[] { 1593, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64887] = new Feature
					{
						_0 = new int[] { 1593, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64888] = new Feature
					{
						_0 = new int[] { 1593, 1605, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64889] = new Feature
					{
						_0 = new int[] { 1594, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64890] = new Feature
					{
						_0 = new int[] { 1594, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64891] = new Feature
					{
						_0 = new int[] { 1594, 1605, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64892] = new Feature
					{
						_0 = new int[] { 1601, 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64893] = new Feature
					{
						_0 = new int[] { 1601, 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64894] = new Feature
					{
						_0 = new int[] { 1602, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64895] = new Feature
					{
						_0 = new int[] { 1602, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64896] = new Feature
					{
						_0 = new int[] { 1604, 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64897] = new Feature
					{
						_0 = new int[] { 1604, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64898] = new Feature
					{
						_0 = new int[] { 1604, 1581, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64899] = new Feature
					{
						_0 = new int[] { 1604, 1580, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64900] = new Feature
					{
						_0 = new int[] { 1604, 1580, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64901] = new Feature
					{
						_0 = new int[] { 1604, 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64902] = new Feature
					{
						_0 = new int[] { 1604, 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64903] = new Feature
					{
						_0 = new int[] { 1604, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64904] = new Feature
					{
						_0 = new int[] { 1604, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64905] = new Feature
					{
						_0 = new int[] { 1605, 1581, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64906] = new Feature
					{
						_0 = new int[] { 1605, 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64907] = new Feature
					{
						_0 = new int[] { 1605, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64908] = new Feature
					{
						_0 = new int[] { 1605, 1580, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64909] = new Feature
					{
						_0 = new int[] { 1605, 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64910] = new Feature
					{
						_0 = new int[] { 1605, 1582, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64911] = new Feature
					{
						_0 = new int[] { 1605, 1582, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64914] = new Feature
					{
						_0 = new int[] { 1605, 1580, 1582 },
						_1 = 256,
						_2 = null,
					},
					[64915] = new Feature
					{
						_0 = new int[] { 1607, 1605, 1580 },
						_1 = 256,
						_2 = null,
					},
					[64916] = new Feature
					{
						_0 = new int[] { 1607, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64917] = new Feature
					{
						_0 = new int[] { 1606, 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64918] = new Feature
					{
						_0 = new int[] { 1606, 1581, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64919] = new Feature
					{
						_0 = new int[] { 1606, 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64920] = new Feature
					{
						_0 = new int[] { 1606, 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64921] = new Feature
					{
						_0 = new int[] { 1606, 1580, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64922] = new Feature
					{
						_0 = new int[] { 1606, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64923] = new Feature
					{
						_0 = new int[] { 1606, 1605, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64924] = new Feature
					{
						_0 = new int[] { 1610, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64925] = new Feature
					{
						_0 = new int[] { 1610, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64926] = new Feature
					{
						_0 = new int[] { 1576, 1582, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64927] = new Feature
					{
						_0 = new int[] { 1578, 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64928] = new Feature
					{
						_0 = new int[] { 1578, 1580, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64929] = new Feature
					{
						_0 = new int[] { 1578, 1582, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64930] = new Feature
					{
						_0 = new int[] { 1578, 1582, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64931] = new Feature
					{
						_0 = new int[] { 1578, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64932] = new Feature
					{
						_0 = new int[] { 1578, 1605, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64933] = new Feature
					{
						_0 = new int[] { 1580, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64934] = new Feature
					{
						_0 = new int[] { 1580, 1581, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64935] = new Feature
					{
						_0 = new int[] { 1580, 1605, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64936] = new Feature
					{
						_0 = new int[] { 1587, 1582, 1609 },
						_1 = 256,
						_2 = null,
					},
					[64937] = new Feature
					{
						_0 = new int[] { 1589, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64938] = new Feature
					{
						_0 = new int[] { 1588, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64939] = new Feature
					{
						_0 = new int[] { 1590, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64940] = new Feature
					{
						_0 = new int[] { 1604, 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64941] = new Feature
					{
						_0 = new int[] { 1604, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64942] = new Feature
					{
						_0 = new int[] { 1610, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64943] = new Feature
					{
						_0 = new int[] { 1610, 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64944] = new Feature
					{
						_0 = new int[] { 1610, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64945] = new Feature
					{
						_0 = new int[] { 1605, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64946] = new Feature
					{
						_0 = new int[] { 1602, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64947] = new Feature
					{
						_0 = new int[] { 1606, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64948] = new Feature
					{
						_0 = new int[] { 1602, 1605, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64949] = new Feature
					{
						_0 = new int[] { 1604, 1581, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64950] = new Feature
					{
						_0 = new int[] { 1593, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64951] = new Feature
					{
						_0 = new int[] { 1603, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64952] = new Feature
					{
						_0 = new int[] { 1606, 1580, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64953] = new Feature
					{
						_0 = new int[] { 1605, 1582, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64954] = new Feature
					{
						_0 = new int[] { 1604, 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64955] = new Feature
					{
						_0 = new int[] { 1603, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64956] = new Feature
					{
						_0 = new int[] { 1604, 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64957] = new Feature
					{
						_0 = new int[] { 1606, 1580, 1581 },
						_1 = 256,
						_2 = null,
					},
					[64958] = new Feature
					{
						_0 = new int[] { 1580, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64959] = new Feature
					{
						_0 = new int[] { 1581, 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64960] = new Feature
					{
						_0 = new int[] { 1605, 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64961] = new Feature
					{
						_0 = new int[] { 1601, 1605, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64962] = new Feature
					{
						_0 = new int[] { 1576, 1581, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64963] = new Feature
					{
						_0 = new int[] { 1603, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64964] = new Feature
					{
						_0 = new int[] { 1593, 1580, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64965] = new Feature
					{
						_0 = new int[] { 1589, 1605, 1605 },
						_1 = 256,
						_2 = null,
					},
					[64966] = new Feature
					{
						_0 = new int[] { 1587, 1582, 1610 },
						_1 = 256,
						_2 = null,
					},
					[64967] = new Feature
					{
						_0 = new int[] { 1606, 1580, 1610 },
						_1 = 256,
						_2 = null,
					},
					[65008] = new Feature
					{
						_0 = new int[] { 1589, 1604, 1746 },
						_1 = 256,
						_2 = null,
					},
					[65009] = new Feature
					{
						_0 = new int[] { 1602, 1604, 1746 },
						_1 = 256,
						_2 = null,
					},
					[65010] = new Feature
					{
						_0 = new int[] { 1575, 1604, 1604, 1607 },
						_1 = 256,
						_2 = null,
					},
					[65011] = new Feature
					{
						_0 = new int[] { 1575, 1603, 1576, 1585 },
						_1 = 256,
						_2 = null,
					},
					[65012] = new Feature
					{
						_0 = new int[] { 1605, 1581, 1605, 1583 },
						_1 = 256,
						_2 = null,
					},
					[65013] = new Feature
					{
						_0 = new int[] { 1589, 1604, 1593, 1605 },
						_1 = 256,
						_2 = null,
					},
					[65014] = new Feature
					{
						_0 = new int[] { 1585, 1587, 1608, 1604 },
						_1 = 256,
						_2 = null,
					},
					[65015] = new Feature
					{
						_0 = new int[] { 1593, 1604, 1610, 1607 },
						_1 = 256,
						_2 = null,
					},
					[65016] = new Feature
					{
						_0 = new int[] { 1608, 1587, 1604, 1605 },
						_1 = 256,
						_2 = null,
					},
					[65017] = new Feature
					{
						_0 = new int[] { 1589, 1604, 1609 },
						_1 = 256,
						_2 = null,
					},
					[65018] = new Feature
					{
						_0 = new int[] { 1589, 1604, 1609, 32, 1575, 1604, 1604, 1607, 32, 1593, 1604, 1610, 1607, 32, 1608, 1587, 1604, 1605 },
						_1 = 256,
						_2 = null,
					},
					[65019] = new Feature
					{
						_0 = new int[] { 1580, 1604, 32, 1580, 1604, 1575, 1604, 1607 },
						_1 = 256,
						_2 = null,
					},
					[65020] = new Feature
					{
						_0 = new int[] { 1585, 1740, 1575, 1604 },
						_1 = 256,
						_2 = null,
					},
				},
				[65024] = new Dictionary<int, Feature>
				{
					[65040] = new Feature
					{
						_0 = new int[] { 44 },
						_1 = 256,
						_2 = null,
					},
					[65041] = new Feature
					{
						_0 = new int[] { 12289 },
						_1 = 256,
						_2 = null,
					},
					[65042] = new Feature
					{
						_0 = new int[] { 12290 },
						_1 = 256,
						_2 = null,
					},
					[65043] = new Feature
					{
						_0 = new int[] { 58 },
						_1 = 256,
						_2 = null,
					},
					[65044] = new Feature
					{
						_0 = new int[] { 59 },
						_1 = 256,
						_2 = null,
					},
					[65045] = new Feature
					{
						_0 = new int[] { 33 },
						_1 = 256,
						_2 = null,
					},
					[65046] = new Feature
					{
						_0 = new int[] { 63 },
						_1 = 256,
						_2 = null,
					},
					[65047] = new Feature
					{
						_0 = new int[] { 12310 },
						_1 = 256,
						_2 = null,
					},
					[65048] = new Feature
					{
						_0 = new int[] { 12311 },
						_1 = 256,
						_2 = null,
					},
					[65049] = new Feature
					{
						_0 = new int[] { 8230 },
						_1 = 256,
						_2 = null,
					},
					[65056] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65057] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65058] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65059] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65060] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65061] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65062] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65063] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[65064] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[65065] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[65066] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[65067] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[65068] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[65069] = new Feature
					{
						_0 = null,
						_1 = 220,
						_2 = null,
					},
					[65070] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65071] = new Feature
					{
						_0 = null,
						_1 = 230,
						_2 = null,
					},
					[65072] = new Feature
					{
						_0 = new int[] { 8229 },
						_1 = 256,
						_2 = null,
					},
					[65073] = new Feature
					{
						_0 = new int[] { 8212 },
						_1 = 256,
						_2 = null,
					},
					[65074] = new Feature
					{
						_0 = new int[] { 8211 },
						_1 = 256,
						_2 = null,
					},
					[65075] = new Feature
					{
						_0 = new int[] { 95 },
						_1 = 256,
						_2 = null,
					},
					[65076] = new Feature
					{
						_0 = new int[] { 95 },
						_1 = 256,
						_2 = null,
					},
					[65077] = new Feature
					{
						_0 = new int[] { 40 },
						_1 = 256,
						_2 = null,
					},
					[65078] = new Feature
					{
						_0 = new int[] { 41 },
						_1 = 256,
						_2 = null,
					},
					[65079] = new Feature
					{
						_0 = new int[] { 123 },
						_1 = 256,
						_2 = null,
					},
					[65080] = new Feature
					{
						_0 = new int[] { 125 },
						_1 = 256,
						_2 = null,
					},
					[65081] = new Feature
					{
						_0 = new int[] { 12308 },
						_1 = 256,
						_2 = null,
					},
					[65082] = new Feature
					{
						_0 = new int[] { 12309 },
						_1 = 256,
						_2 = null,
					},
					[65083] = new Feature
					{
						_0 = new int[] { 12304 },
						_1 = 256,
						_2 = null,
					},
					[65084] = new Feature
					{
						_0 = new int[] { 12305 },
						_1 = 256,
						_2 = null,
					},
					[65085] = new Feature
					{
						_0 = new int[] { 12298 },
						_1 = 256,
						_2 = null,
					},
					[65086] = new Feature
					{
						_0 = new int[] { 12299 },
						_1 = 256,
						_2 = null,
					},
					[65087] = new Feature
					{
						_0 = new int[] { 12296 },
						_1 = 256,
						_2 = null,
					},
					[65088] = new Feature
					{
						_0 = new int[] { 12297 },
						_1 = 256,
						_2 = null,
					},
					[65089] = new Feature
					{
						_0 = new int[] { 12300 },
						_1 = 256,
						_2 = null,
					},
					[65090] = new Feature
					{
						_0 = new int[] { 12301 },
						_1 = 256,
						_2 = null,
					},
					[65091] = new Feature
					{
						_0 = new int[] { 12302 },
						_1 = 256,
						_2 = null,
					},
					[65092] = new Feature
					{
						_0 = new int[] { 12303 },
						_1 = 256,
						_2 = null,
					},
					[65095] = new Feature
					{
						_0 = new int[] { 91 },
						_1 = 256,
						_2 = null,
					},
					[65096] = new Feature
					{
						_0 = new int[] { 93 },
						_1 = 256,
						_2 = null,
					},
					[65097] = new Feature
					{
						_0 = new int[] { 8254 },
						_1 = 256,
						_2 = null,
					},
					[65098] = new Feature
					{
						_0 = new int[] { 8254 },
						_1 = 256,
						_2 = null,
					},
					[65099] = new Feature
					{
						_0 = new int[] { 8254 },
						_1 = 256,
						_2 = null,
					},
					[65100] = new Feature
					{
						_0 = new int[] { 8254 },
						_1 = 256,
						_2 = null,
					},
					[65101] = new Feature
					{
						_0 = new int[] { 95 },
						_1 = 256,
						_2 = null,
					},
					[65102] = new Feature
					{
						_0 = new int[] { 95 },
						_1 = 256,
						_2 = null,
					},
					[65103] = new Feature
					{
						_0 = new int[] { 95 },
						_1 = 256,
						_2 = null,
					},
					[65104] = new Feature
					{
						_0 = new int[] { 44 },
						_1 = 256,
						_2 = null,
					},
					[65105] = new Feature
					{
						_0 = new int[] { 12289 },
						_1 = 256,
						_2 = null,
					},
					[65106] = new Feature
					{
						_0 = new int[] { 46 },
						_1 = 256,
						_2 = null,
					},
					[65108] = new Feature
					{
						_0 = new int[] { 59 },
						_1 = 256,
						_2 = null,
					},
					[65109] = new Feature
					{
						_0 = new int[] { 58 },
						_1 = 256,
						_2 = null,
					},
					[65110] = new Feature
					{
						_0 = new int[] { 63 },
						_1 = 256,
						_2 = null,
					},
					[65111] = new Feature
					{
						_0 = new int[] { 33 },
						_1 = 256,
						_2 = null,
					},
					[65112] = new Feature
					{
						_0 = new int[] { 8212 },
						_1 = 256,
						_2 = null,
					},
					[65113] = new Feature
					{
						_0 = new int[] { 40 },
						_1 = 256,
						_2 = null,
					},
					[65114] = new Feature
					{
						_0 = new int[] { 41 },
						_1 = 256,
						_2 = null,
					},
					[65115] = new Feature
					{
						_0 = new int[] { 123 },
						_1 = 256,
						_2 = null,
					},
					[65116] = new Feature
					{
						_0 = new int[] { 125 },
						_1 = 256,
						_2 = null,
					},
					[65117] = new Feature
					{
						_0 = new int[] { 12308 },
						_1 = 256,
						_2 = null,
					},
					[65118] = new Feature
					{
						_0 = new int[] { 12309 },
						_1 = 256,
						_2 = null,
					},
					[65119] = new Feature
					{
						_0 = new int[] { 35 },
						_1 = 256,
						_2 = null,
					},
					[65120] = new Feature
					{
						_0 = new int[] { 38 },
						_1 = 256,
						_2 = null,
					},
					[65121] = new Feature
					{
						_0 = new int[] { 42 },
						_1 = 256,
						_2 = null,
					},
					[65122] = new Feature
					{
						_0 = new int[] { 43 },
						_1 = 256,
						_2 = null,
					},
					[65123] = new Feature
					{
						_0 = new int[] { 45 },
						_1 = 256,
						_2 = null,
					},
					[65124] = new Feature
					{
						_0 = new int[] { 60 },
						_1 = 256,
						_2 = null,
					},
					[65125] = new Feature
					{
						_0 = new int[] { 62 },
						_1 = 256,
						_2 = null,
					},
					[65126] = new Feature
					{
						_0 = new int[] { 61 },
						_1 = 256,
						_2 = null,
					},
					[65128] = new Feature
					{
						_0 = new int[] { 92 },
						_1 = 256,
						_2 = null,
					},
					[65129] = new Feature
					{
						_0 = new int[] { 36 },
						_1 = 256,
						_2 = null,
					},
					[65130] = new Feature
					{
						_0 = new int[] { 37 },
						_1 = 256,
						_2 = null,
					},
					[65131] = new Feature
					{
						_0 = new int[] { 64 },
						_1 = 256,
						_2 = null,
					},
					[65136] = new Feature
					{
						_0 = new int[] { 32, 1611 },
						_1 = 256,
						_2 = null,
					},
					[65137] = new Feature
					{
						_0 = new int[] { 1600, 1611 },
						_1 = 256,
						_2 = null,
					},
					[65138] = new Feature
					{
						_0 = new int[] { 32, 1612 },
						_1 = 256,
						_2 = null,
					},
					[65140] = new Feature
					{
						_0 = new int[] { 32, 1613 },
						_1 = 256,
						_2 = null,
					},
					[65142] = new Feature
					{
						_0 = new int[] { 32, 1614 },
						_1 = 256,
						_2 = null,
					},
					[65143] = new Feature
					{
						_0 = new int[] { 1600, 1614 },
						_1 = 256,
						_2 = null,
					},
					[65144] = new Feature
					{
						_0 = new int[] { 32, 1615 },
						_1 = 256,
						_2 = null,
					},
					[65145] = new Feature
					{
						_0 = new int[] { 1600, 1615 },
						_1 = 256,
						_2 = null,
					},
					[65146] = new Feature
					{
						_0 = new int[] { 32, 1616 },
						_1 = 256,
						_2 = null,
					},
					[65147] = new Feature
					{
						_0 = new int[] { 1600, 1616 },
						_1 = 256,
						_2 = null,
					},
					[65148] = new Feature
					{
						_0 = new int[] { 32, 1617 },
						_1 = 256,
						_2 = null,
					},
					[65149] = new Feature
					{
						_0 = new int[] { 1600, 1617 },
						_1 = 256,
						_2 = null,
					},
					[65150] = new Feature
					{
						_0 = new int[] { 32, 1618 },
						_1 = 256,
						_2 = null,
					},
					[65151] = new Feature
					{
						_0 = new int[] { 1600, 1618 },
						_1 = 256,
						_2 = null,
					},
					[65152] = new Feature
					{
						_0 = new int[] { 1569 },
						_1 = 256,
						_2 = null,
					},
					[65153] = new Feature
					{
						_0 = new int[] { 1570 },
						_1 = 256,
						_2 = null,
					},
					[65154] = new Feature
					{
						_0 = new int[] { 1570 },
						_1 = 256,
						_2 = null,
					},
					[65155] = new Feature
					{
						_0 = new int[] { 1571 },
						_1 = 256,
						_2 = null,
					},
					[65156] = new Feature
					{
						_0 = new int[] { 1571 },
						_1 = 256,
						_2 = null,
					},
					[65157] = new Feature
					{
						_0 = new int[] { 1572 },
						_1 = 256,
						_2 = null,
					},
					[65158] = new Feature
					{
						_0 = new int[] { 1572 },
						_1 = 256,
						_2 = null,
					},
					[65159] = new Feature
					{
						_0 = new int[] { 1573 },
						_1 = 256,
						_2 = null,
					},
					[65160] = new Feature
					{
						_0 = new int[] { 1573 },
						_1 = 256,
						_2 = null,
					},
					[65161] = new Feature
					{
						_0 = new int[] { 1574 },
						_1 = 256,
						_2 = null,
					},
					[65162] = new Feature
					{
						_0 = new int[] { 1574 },
						_1 = 256,
						_2 = null,
					},
					[65163] = new Feature
					{
						_0 = new int[] { 1574 },
						_1 = 256,
						_2 = null,
					},
					[65164] = new Feature
					{
						_0 = new int[] { 1574 },
						_1 = 256,
						_2 = null,
					},
					[65165] = new Feature
					{
						_0 = new int[] { 1575 },
						_1 = 256,
						_2 = null,
					},
					[65166] = new Feature
					{
						_0 = new int[] { 1575 },
						_1 = 256,
						_2 = null,
					},
					[65167] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[65168] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[65169] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[65170] = new Feature
					{
						_0 = new int[] { 1576 },
						_1 = 256,
						_2 = null,
					},
					[65171] = new Feature
					{
						_0 = new int[] { 1577 },
						_1 = 256,
						_2 = null,
					},
					[65172] = new Feature
					{
						_0 = new int[] { 1577 },
						_1 = 256,
						_2 = null,
					},
					[65173] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[65174] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[65175] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[65176] = new Feature
					{
						_0 = new int[] { 1578 },
						_1 = 256,
						_2 = null,
					},
					[65177] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[65178] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[65179] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[65180] = new Feature
					{
						_0 = new int[] { 1579 },
						_1 = 256,
						_2 = null,
					},
					[65181] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[65182] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[65183] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[65184] = new Feature
					{
						_0 = new int[] { 1580 },
						_1 = 256,
						_2 = null,
					},
					[65185] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[65186] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[65187] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[65188] = new Feature
					{
						_0 = new int[] { 1581 },
						_1 = 256,
						_2 = null,
					},
					[65189] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[65190] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[65191] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[65192] = new Feature
					{
						_0 = new int[] { 1582 },
						_1 = 256,
						_2 = null,
					},
					[65193] = new Feature
					{
						_0 = new int[] { 1583 },
						_1 = 256,
						_2 = null,
					},
					[65194] = new Feature
					{
						_0 = new int[] { 1583 },
						_1 = 256,
						_2 = null,
					},
					[65195] = new Feature
					{
						_0 = new int[] { 1584 },
						_1 = 256,
						_2 = null,
					},
					[65196] = new Feature
					{
						_0 = new int[] { 1584 },
						_1 = 256,
						_2 = null,
					},
					[65197] = new Feature
					{
						_0 = new int[] { 1585 },
						_1 = 256,
						_2 = null,
					},
					[65198] = new Feature
					{
						_0 = new int[] { 1585 },
						_1 = 256,
						_2 = null,
					},
					[65199] = new Feature
					{
						_0 = new int[] { 1586 },
						_1 = 256,
						_2 = null,
					},
					[65200] = new Feature
					{
						_0 = new int[] { 1586 },
						_1 = 256,
						_2 = null,
					},
					[65201] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[65202] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[65203] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[65204] = new Feature
					{
						_0 = new int[] { 1587 },
						_1 = 256,
						_2 = null,
					},
					[65205] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[65206] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[65207] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[65208] = new Feature
					{
						_0 = new int[] { 1588 },
						_1 = 256,
						_2 = null,
					},
					[65209] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[65210] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[65211] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[65212] = new Feature
					{
						_0 = new int[] { 1589 },
						_1 = 256,
						_2 = null,
					},
					[65213] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[65214] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[65215] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[65216] = new Feature
					{
						_0 = new int[] { 1590 },
						_1 = 256,
						_2 = null,
					},
					[65217] = new Feature
					{
						_0 = new int[] { 1591 },
						_1 = 256,
						_2 = null,
					},
					[65218] = new Feature
					{
						_0 = new int[] { 1591 },
						_1 = 256,
						_2 = null,
					},
					[65219] = new Feature
					{
						_0 = new int[] { 1591 },
						_1 = 256,
						_2 = null,
					},
					[65220] = new Feature
					{
						_0 = new int[] { 1591 },
						_1 = 256,
						_2 = null,
					},
					[65221] = new Feature
					{
						_0 = new int[] { 1592 },
						_1 = 256,
						_2 = null,
					},
					[65222] = new Feature
					{
						_0 = new int[] { 1592 },
						_1 = 256,
						_2 = null,
					},
					[65223] = new Feature
					{
						_0 = new int[] { 1592 },
						_1 = 256,
						_2 = null,
					},
					[65224] = new Feature
					{
						_0 = new int[] { 1592 },
						_1 = 256,
						_2 = null,
					},
					[65225] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[65226] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[65227] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[65228] = new Feature
					{
						_0 = new int[] { 1593 },
						_1 = 256,
						_2 = null,
					},
					[65229] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[65230] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[65231] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[65232] = new Feature
					{
						_0 = new int[] { 1594 },
						_1 = 256,
						_2 = null,
					},
					[65233] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[65234] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[65235] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[65236] = new Feature
					{
						_0 = new int[] { 1601 },
						_1 = 256,
						_2 = null,
					},
					[65237] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[65238] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[65239] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[65240] = new Feature
					{
						_0 = new int[] { 1602 },
						_1 = 256,
						_2 = null,
					},
					[65241] = new Feature
					{
						_0 = new int[] { 1603 },
						_1 = 256,
						_2 = null,
					},
					[65242] = new Feature
					{
						_0 = new int[] { 1603 },
						_1 = 256,
						_2 = null,
					},
					[65243] = new Feature
					{
						_0 = new int[] { 1603 },
						_1 = 256,
						_2 = null,
					},
					[65244] = new Feature
					{
						_0 = new int[] { 1603 },
						_1 = 256,
						_2 = null,
					},
					[65245] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[65246] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[65247] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[65248] = new Feature
					{
						_0 = new int[] { 1604 },
						_1 = 256,
						_2 = null,
					},
					[65249] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[65250] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[65251] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[65252] = new Feature
					{
						_0 = new int[] { 1605 },
						_1 = 256,
						_2 = null,
					},
					[65253] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[65254] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[65255] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[65256] = new Feature
					{
						_0 = new int[] { 1606 },
						_1 = 256,
						_2 = null,
					},
					[65257] = new Feature
					{
						_0 = new int[] { 1607 },
						_1 = 256,
						_2 = null,
					},
					[65258] = new Feature
					{
						_0 = new int[] { 1607 },
						_1 = 256,
						_2 = null,
					},
					[65259] = new Feature
					{
						_0 = new int[] { 1607 },
						_1 = 256,
						_2 = null,
					},
					[65260] = new Feature
					{
						_0 = new int[] { 1607 },
						_1 = 256,
						_2 = null,
					},
					[65261] = new Feature
					{
						_0 = new int[] { 1608 },
						_1 = 256,
						_2 = null,
					},
					[65262] = new Feature
					{
						_0 = new int[] { 1608 },
						_1 = 256,
						_2 = null,
					},
					[65263] = new Feature
					{
						_0 = new int[] { 1609 },
						_1 = 256,
						_2 = null,
					},
					[65264] = new Feature
					{
						_0 = new int[] { 1609 },
						_1 = 256,
						_2 = null,
					},
					[65265] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[65266] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[65267] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[65268] = new Feature
					{
						_0 = new int[] { 1610 },
						_1 = 256,
						_2 = null,
					},
					[65269] = new Feature
					{
						_0 = new int[] { 1604, 1570 },
						_1 = 256,
						_2 = null,
					},
					[65270] = new Feature
					{
						_0 = new int[] { 1604, 1570 },
						_1 = 256,
						_2 = null,
					},
					[65271] = new Feature
					{
						_0 = new int[] { 1604, 1571 },
						_1 = 256,
						_2 = null,
					},
					[65272] = new Feature
					{
						_0 = new int[] { 1604, 1571 },
						_1 = 256,
						_2 = null,
					},
					[65273] = new Feature
					{
						_0 = new int[] { 1604, 1573 },
						_1 = 256,
						_2 = null,
					},
					[65274] = new Feature
					{
						_0 = new int[] { 1604, 1573 },
						_1 = 256,
						_2 = null,
					},
					[65275] = new Feature
					{
						_0 = new int[] { 1604, 1575 },
						_1 = 256,
						_2 = null,
					},
					[65276] = new Feature
					{
						_0 = new int[] { 1604, 1575 },
						_1 = 256,
						_2 = null,
					},
				},
				[65280] = new Dictionary<int, Feature>
				{
					[65281] = new Feature
					{
						_0 = new int[] { 33 },
						_1 = 256,
						_2 = null,
					},
					[65282] = new Feature
					{
						_0 = new int[] { 34 },
						_1 = 256,
						_2 = null,
					},
					[65283] = new Feature
					{
						_0 = new int[] { 35 },
						_1 = 256,
						_2 = null,
					},
					[65284] = new Feature
					{
						_0 = new int[] { 36 },
						_1 = 256,
						_2 = null,
					},
					[65285] = new Feature
					{
						_0 = new int[] { 37 },
						_1 = 256,
						_2 = null,
					},
					[65286] = new Feature
					{
						_0 = new int[] { 38 },
						_1 = 256,
						_2 = null,
					},
					[65287] = new Feature
					{
						_0 = new int[] { 39 },
						_1 = 256,
						_2 = null,
					},
					[65288] = new Feature
					{
						_0 = new int[] { 40 },
						_1 = 256,
						_2 = null,
					},
					[65289] = new Feature
					{
						_0 = new int[] { 41 },
						_1 = 256,
						_2 = null,
					},
					[65290] = new Feature
					{
						_0 = new int[] { 42 },
						_1 = 256,
						_2 = null,
					},
					[65291] = new Feature
					{
						_0 = new int[] { 43 },
						_1 = 256,
						_2 = null,
					},
					[65292] = new Feature
					{
						_0 = new int[] { 44 },
						_1 = 256,
						_2 = null,
					},
					[65293] = new Feature
					{
						_0 = new int[] { 45 },
						_1 = 256,
						_2 = null,
					},
					[65294] = new Feature
					{
						_0 = new int[] { 46 },
						_1 = 256,
						_2 = null,
					},
					[65295] = new Feature
					{
						_0 = new int[] { 47 },
						_1 = 256,
						_2 = null,
					},
					[65296] = new Feature
					{
						_0 = new int[] { 48 },
						_1 = 256,
						_2 = null,
					},
					[65297] = new Feature
					{
						_0 = new int[] { 49 },
						_1 = 256,
						_2 = null,
					},
					[65298] = new Feature
					{
						_0 = new int[] { 50 },
						_1 = 256,
						_2 = null,
					},
					[65299] = new Feature
					{
						_0 = new int[] { 51 },
						_1 = 256,
						_2 = null,
					},
					[65300] = new Feature
					{
						_0 = new int[] { 52 },
						_1 = 256,
						_2 = null,
					},
					[65301] = new Feature
					{
						_0 = new int[] { 53 },
						_1 = 256,
						_2 = null,
					},
					[65302] = new Feature
					{
						_0 = new int[] { 54 },
						_1 = 256,
						_2 = null,
					},
					[65303] = new Feature
					{
						_0 = new int[] { 55 },
						_1 = 256,
						_2 = null,
					},
					[65304] = new Feature
					{
						_0 = new int[] { 56 },
						_1 = 256,
						_2 = null,
					},
					[65305] = new Feature
					{
						_0 = new int[] { 57 },
						_1 = 256,
						_2 = null,
					},
					[65306] = new Feature
					{
						_0 = new int[] { 58 },
						_1 = 256,
						_2 = null,
					},
					[65307] = new Feature
					{
						_0 = new int[] { 59 },
						_1 = 256,
						_2 = null,
					},
					[65308] = new Feature
					{
						_0 = new int[] { 60 },
						_1 = 256,
						_2 = null,
					},
					[65309] = new Feature
					{
						_0 = new int[] { 61 },
						_1 = 256,
						_2 = null,
					},
					[65310] = new Feature
					{
						_0 = new int[] { 62 },
						_1 = 256,
						_2 = null,
					},
					[65311] = new Feature
					{
						_0 = new int[] { 63 },
						_1 = 256,
						_2 = null,
					},
					[65312] = new Feature
					{
						_0 = new int[] { 64 },
						_1 = 256,
						_2 = null,
					},
					[65313] = new Feature
					{
						_0 = new int[] { 65 },
						_1 = 256,
						_2 = null,
					},
					[65314] = new Feature
					{
						_0 = new int[] { 66 },
						_1 = 256,
						_2 = null,
					},
					[65315] = new Feature
					{
						_0 = new int[] { 67 },
						_1 = 256,
						_2 = null,
					},
					[65316] = new Feature
					{
						_0 = new int[] { 68 },
						_1 = 256,
						_2 = null,
					},
					[65317] = new Feature
					{
						_0 = new int[] { 69 },
						_1 = 256,
						_2 = null,
					},
					[65318] = new Feature
					{
						_0 = new int[] { 70 },
						_1 = 256,
						_2 = null,
					},
					[65319] = new Feature
					{
						_0 = new int[] { 71 },
						_1 = 256,
						_2 = null,
					},
					[65320] = new Feature
					{
						_0 = new int[] { 72 },
						_1 = 256,
						_2 = null,
					},
					[65321] = new Feature
					{
						_0 = new int[] { 73 },
						_1 = 256,
						_2 = null,
					},
					[65322] = new Feature
					{
						_0 = new int[] { 74 },
						_1 = 256,
						_2 = null,
					},
					[65323] = new Feature
					{
						_0 = new int[] { 75 },
						_1 = 256,
						_2 = null,
					},
					[65324] = new Feature
					{
						_0 = new int[] { 76 },
						_1 = 256,
						_2 = null,
					},
					[65325] = new Feature
					{
						_0 = new int[] { 77 },
						_1 = 256,
						_2 = null,
					},
					[65326] = new Feature
					{
						_0 = new int[] { 78 },
						_1 = 256,
						_2 = null,
					},
					[65327] = new Feature
					{
						_0 = new int[] { 79 },
						_1 = 256,
						_2 = null,
					},
					[65328] = new Feature
					{
						_0 = new int[] { 80 },
						_1 = 256,
						_2 = null,
					},
					[65329] = new Feature
					{
						_0 = new int[] { 81 },
						_1 = 256,
						_2 = null,
					},
					[65330] = new Feature
					{
						_0 = new int[] { 82 },
						_1 = 256,
						_2 = null,
					},
					[65331] = new Feature
					{
						_0 = new int[] { 83 },
						_1 = 256,
						_2 = null,
					},
					[65332] = new Feature
					{
						_0 = new int[] { 84 },
						_1 = 256,
						_2 = null,
					},
					[65333] = new Feature
					{
						_0 = new int[] { 85 },
						_1 = 256,
						_2 = null,
					},
					[65334] = new Feature
					{
						_0 = new int[] { 86 },
						_1 = 256,
						_2 = null,
					},
					[65335] = new Feature
					{
						_0 = new int[] { 87 },
						_1 = 256,
						_2 = null,
					},
					[65336] = new Feature
					{
						_0 = new int[] { 88 },
						_1 = 256,
						_2 = null,
					},
					[65337] = new Feature
					{
						_0 = new int[] { 89 },
						_1 = 256,
						_2 = null,
					},
					[65338] = new Feature
					{
						_0 = new int[] { 90 },
						_1 = 256,
						_2 = null,
					},
					[65339] = new Feature
					{
						_0 = new int[] { 91 },
						_1 = 256,
						_2 = null,
					},
					[65340] = new Feature
					{
						_0 = new int[] { 92 },
						_1 = 256,
						_2 = null,
					},
					[65341] = new Feature
					{
						_0 = new int[] { 93 },
						_1 = 256,
						_2 = null,
					},
					[65342] = new Feature
					{
						_0 = new int[] { 94 },
						_1 = 256,
						_2 = null,
					},
					[65343] = new Feature
					{
						_0 = new int[] { 95 },
						_1 = 256,
						_2 = null,
					},
					[65344] = new Feature
					{
						_0 = new int[] { 96 },
						_1 = 256,
						_2 = null,
					},
					[65345] = new Feature
					{
						_0 = new int[] { 97 },
						_1 = 256,
						_2 = null,
					},
					[65346] = new Feature
					{
						_0 = new int[] { 98 },
						_1 = 256,
						_2 = null,
					},
					[65347] = new Feature
					{
						_0 = new int[] { 99 },
						_1 = 256,
						_2 = null,
					},
					[65348] = new Feature
					{
						_0 = new int[] { 100 },
						_1 = 256,
						_2 = null,
					},
					[65349] = new Feature
					{
						_0 = new int[] { 101 },
						_1 = 256,
						_2 = null,
					},
					[65350] = new Feature
					{
						_0 = new int[] { 102 },
						_1 = 256,
						_2 = null,
					},
					[65351] = new Feature
					{
						_0 = new int[] { 103 },
						_1 = 256,
						_2 = null,
					},
					[65352] = new Feature
					{
						_0 = new int[] { 104 },
						_1 = 256,
						_2 = null,
					},
					[65353] = new Feature
					{
						_0 = new int[] { 105 },
						_1 = 256,
						_2 = null,
					},
					[65354] = new Feature
					{
						_0 = new int[] { 106 },
						_1 = 256,
						_2 = null,
					},
					[65355] = new Feature
					{
						_0 = new int[] { 107 },
						_1 = 256,
						_2 = null,
					},
					[65356] = new Feature
					{
						_0 = new int[] { 108 },
						_1 = 256,
						_2 = null,
					},
					[65357] = new Feature
					{
						_0 = new int[] { 109 },
						_1 = 256,
						_2 = null,
					},
					[65358] = new Feature
					{
						_0 = new int[] { 110 },
						_1 = 256,
						_2 = null,
					},
					[65359] = new Feature
					{
						_0 = new int[] { 111 },
						_1 = 256,
						_2 = null,
					},
					[65360] = new Feature
					{
						_0 = new int[] { 112 },
						_1 = 256,
						_2 = null,
					},
					[65361] = new Feature
					{
						_0 = new int[] { 113 },
						_1 = 256,
						_2 = null,
					},
					[65362] = new Feature
					{
						_0 = new int[] { 114 },
						_1 = 256,
						_2 = null,
					},
					[65363] = new Feature
					{
						_0 = new int[] { 115 },
						_1 = 256,
						_2 = null,
					},
					[65364] = new Feature
					{
						_0 = new int[] { 116 },
						_1 = 256,
						_2 = null,
					},
					[65365] = new Feature
					{
						_0 = new int[] { 117 },
						_1 = 256,
						_2 = null,
					},
					[65366] = new Feature
					{
						_0 = new int[] { 118 },
						_1 = 256,
						_2 = null,
					},
					[65367] = new Feature
					{
						_0 = new int[] { 119 },
						_1 = 256,
						_2 = null,
					},
					[65368] = new Feature
					{
						_0 = new int[] { 120 },
						_1 = 256,
						_2 = null,
					},
					[65369] = new Feature
					{
						_0 = new int[] { 121 },
						_1 = 256,
						_2 = null,
					},
					[65370] = new Feature
					{
						_0 = new int[] { 122 },
						_1 = 256,
						_2 = null,
					},
					[65371] = new Feature
					{
						_0 = new int[] { 123 },
						_1 = 256,
						_2 = null,
					},
					[65372] = new Feature
					{
						_0 = new int[] { 124 },
						_1 = 256,
						_2 = null,
					},
					[65373] = new Feature
					{
						_0 = new int[] { 125 },
						_1 = 256,
						_2 = null,
					},
					[65374] = new Feature
					{
						_0 = new int[] { 126 },
						_1 = 256,
						_2 = null,
					},
					[65375] = new Feature
					{
						_0 = new int[] { 10629 },
						_1 = 256,
						_2 = null,
					},
					[65376] = new Feature
					{
						_0 = new int[] { 10630 },
						_1 = 256,
						_2 = null,
					},
					[65377] = new Feature
					{
						_0 = new int[] { 12290 },
						_1 = 256,
						_2 = null,
					},
					[65378] = new Feature
					{
						_0 = new int[] { 12300 },
						_1 = 256,
						_2 = null,
					},
					[65379] = new Feature
					{
						_0 = new int[] { 12301 },
						_1 = 256,
						_2 = null,
					},
					[65380] = new Feature
					{
						_0 = new int[] { 12289 },
						_1 = 256,
						_2 = null,
					},
					[65381] = new Feature
					{
						_0 = new int[] { 12539 },
						_1 = 256,
						_2 = null,
					},
					[65382] = new Feature
					{
						_0 = new int[] { 12530 },
						_1 = 256,
						_2 = null,
					},
					[65383] = new Feature
					{
						_0 = new int[] { 12449 },
						_1 = 256,
						_2 = null,
					},
					[65384] = new Feature
					{
						_0 = new int[] { 12451 },


						_1 = 256,
						_2 = null,
					},
					[65385] = new Feature
					{
						_0 = new int[] { 12453 },
						_1 = 256,
						_2 = null,
					},
					[65386] = new Feature
					{
						_0 = new int[] { 12455 },
						_1 = 256,
						_2 = null,
					},
					[65387] = new Feature
					{
						_0 = new int[] { 12457 },
						_1 = 256,
						_2 = null,
					},
					[65388] = new Feature
					{
						_0 = new int[] { 12515 },
						_1 = 256,
						_2 = null,
					},
					[65389] = new Feature
					{
						_0 = new int[] { 12517 },
						_1 = 256,
						_2 = null,
					},
					[65390] = new Feature
					{
						_0 = new int[] { 12519 },
						_1 = 256,
						_2 = null,
					},
					[65391] = new Feature
					{
						_0 = new int[] { 12483 },
						_1 = 256,
						_2 = null,
					},
					[65392] = new Feature
					{
						_0 = new int[] { 12540 },
						_1 = 256,
						_2 = null,
					},
					[65393] = new Feature
					{
						_0 = new int[] { 12450 },
						_1 = 256,
						_2 = null,
					},
					[65394] = new Feature
					{
						_0 = new int[] { 12452 },
						_1 = 256,
						_2 = null,
					},
					[65395] = new Feature
					{
						_0 = new int[] { 12454 },
						_1 = 256,
						_2 = null,
					},
					[65396] = new Feature
					{
						_0 = new int[] { 12456 },
						_1 = 256,
						_2 = null,
					},
					[65397] = new Feature
					{
						_0 = new int[] { 12458 },
						_1 = 256,
						_2 = null,
					},
					[65398] = new Feature
					{
						_0 = new int[] { 12459 },
						_1 = 256,
						_2 = null,
					},
					[65399] = new Feature
					{
						_0 = new int[] { 12461 },
						_1 = 256,
						_2 = null,
					},
					[65400] = new Feature
					{
						_0 = new int[] { 12463 },
						_1 = 256,
						_2 = null,
					},
					[65401] = new Feature
					{
						_0 = new int[] { 12465 },
						_1 = 256,
						_2 = null,
					},
					[65402] = new Feature
					{
						_0 = new int[] { 12467 },
						_1 = 256,
						_2 = null,
					},
					[65403] = new Feature
					{
						_0 = new int[] { 12469 },
						_1 = 256,
						_2 = null,
					},
					[65404] = new Feature
					{
						_0 = new int[] { 12471 },
						_1 = 256,
						_2 = null,
					},
					[65405] = new Feature
					{
						_0 = new int[] { 12473 },
						_1 = 256,
						_2 = null,
					},
					[65406] = new Feature
					{
						_0 = new int[] { 12475 },
						_1 = 256,
						_2 = null,
					},
					[65407] = new Feature
					{
						_0 = new int[] { 12477 },
						_1 = 256,
						_2 = null,
					},
					[65408] = new Feature
					{
						_0 = new int[] { 12479 },
						_1 = 256,
						_2 = null,
					},
					[65409] = new Feature
					{
						_0 = new int[] { 12481 },
						_1 = 256,
						_2 = null,
					},
					[65410] = new Feature
					{
						_0 = new int[] { 12484 },
						_1 = 256,
						_2 = null,
					},
					[65411] = new Feature
					{
						_0 = new int[] { 12486 },
						_1 = 256,
						_2 = null,
					},
					[65412] = new Feature
					{
						_0 = new int[] { 12488 },
						_1 = 256,
						_2 = null,
					},
					[65413] = new Feature
					{
						_0 = new int[] { 12490 },
						_1 = 256,
						_2 = null,
					},
					[65414] = new Feature
					{
						_0 = new int[] { 12491 },
						_1 = 256,
						_2 = null,
					},
					[65415] = new Feature
					{
						_0 = new int[] { 12492 },
						_1 = 256,
						_2 = null,
					},
					[65416] = new Feature
					{
						_0 = new int[] { 12493 },
						_1 = 256,
						_2 = null,
					},
					[65417] = new Feature
					{
						_0 = new int[] { 12494 },
						_1 = 256,
						_2 = null,
					},
					[65418] = new Feature
					{
						_0 = new int[] { 12495 },
						_1 = 256,
						_2 = null,
					},
					[65419] = new Feature
					{
						_0 = new int[] { 12498 },
						_1 = 256,
						_2 = null,
					},
					[65420] = new Feature
					{
						_0 = new int[] { 12501 },
						_1 = 256,
						_2 = null,
					},
					[65421] = new Feature
					{
						_0 = new int[] { 12504 },
						_1 = 256,
						_2 = null,
					},
					[65422] = new Feature
					{
						_0 = new int[] { 12507 },
						_1 = 256,
						_2 = null,
					},
					[65423] = new Feature
					{
						_0 = new int[] { 12510 },
						_1 = 256,
						_2 = null,
					},
					[65424] = new Feature
					{
						_0 = new int[] { 12511 },
						_1 = 256,
						_2 = null,
					},
					[65425] = new Feature
					{
						_0 = new int[] { 12512 },
						_1 = 256,
						_2 = null,
					},
					[65426] = new Feature
					{
						_0 = new int[] { 12513 },
						_1 = 256,
						_2 = null,
					},
					[65427] = new Feature
					{
						_0 = new int[] { 12514 },
						_1 = 256,
						_2 = null,
					},
					[65428] = new Feature
					{
						_0 = new int[] { 12516 },
						_1 = 256,
						_2 = null,
					},
					[65429] = new Feature
					{
						_0 = new int[] { 12518 },
						_1 = 256,
						_2 = null,
					},
					[65430] = new Feature
					{
						_0 = new int[] { 12520 },
						_1 = 256,
						_2 = null,
					},
					[65431] = new Feature
					{
						_0 = new int[] { 12521 },
						_1 = 256,
						_2 = null,
					},
					[65432] = new Feature
					{
						_0 = new int[] { 12522 },
						_1 = 256,
						_2 = null,
					},
					[65433] = new Feature
					{
						_0 = new int[] { 12523 },
						_1 = 256,
						_2 = null,
					},
					[65434] = new Feature
					{
						_0 = new int[] { 12524 },
						_1 = 256,
						_2 = null,
					},
					[65435] = new Feature
					{
						_0 = new int[] { 12525 },
						_1 = 256,
						_2 = null,
					},
					[65436] = new Feature
					{
						_0 = new int[] { 12527 },
						_1 = 256,
						_2 = null,
					},
					[65437] = new Feature
					{
						_0 = new int[] { 12531 },
						_1 = 256,
						_2 = null,
					},
					[65438] = new Feature
					{
						_0 = new int[] { 12441 },
						_1 = 256,
						_2 = null,
					},
					[65439] = new Feature
					{
						_0 = new int[] { 12442 },
						_1 = 256,
						_2 = null,
					},
					[65440] = new Feature
					{
						_0 = new int[] { 12644 },
						_1 = 256,
						_2 = null,
					},
					[65441] = new Feature
					{
						_0 = new int[] { 12593 },
						_1 = 256,
						_2 = null,
					},
					[65442] = new Feature
					{
						_0 = new int[] { 12594 },
						_1 = 256,
						_2 = null,
					},
					[65443] = new Feature
					{
						_0 = new int[] { 12595 },
						_1 = 256,
						_2 = null,
					},
					[65444] = new Feature
					{
						_0 = new int[] { 12596 },
						_1 = 256,
						_2 = null,
					},
					[65445] = new Feature
					{
						_0 = new int[] { 12597 },
						_1 = 256,
						_2 = null,
					},
					[65446] = new Feature
					{
						_0 = new int[] { 12598 },
						_1 = 256,
						_2 = null,
					},
					[65447] = new Feature
					{
						_0 = new int[] { 12599 },
						_1 = 256,
						_2 = null,
					},
					[65448] = new Feature
					{
						_0 = new int[] { 12600 },
						_1 = 256,
						_2 = null,
					},
					[65449] = new Feature
					{
						_0 = new int[] { 12601 },
						_1 = 256,
						_2 = null,
					},
					[65450] = new Feature
					{
						_0 = new int[] { 12602 },
						_1 = 256,
						_2 = null,
					},
					[65451] = new Feature
					{
						_0 = new int[] { 12603 },
						_1 = 256,
						_2 = null,
					},
					[65452] = new Feature
					{
						_0 = new int[] { 12604 },
						_1 = 256,
						_2 = null,
					},
					[65453] = new Feature
					{
						_0 = new int[] { 12605 },
						_1 = 256,
						_2 = null,
					},
					[65454] = new Feature
					{
						_0 = new int[] { 12606 },
						_1 = 256,
						_2 = null,
					},
					[65455] = new Feature
					{
						_0 = new int[] { 12607 },
						_1 = 256,
						_2 = null,
					},
					[65456] = new Feature
					{
						_0 = new int[] { 12608 },
						_1 = 256,
						_2 = null,
					},
					[65457] = new Feature
					{
						_0 = new int[] { 12609 },
						_1 = 256,
						_2 = null,
					},
					[65458] = new Feature
					{
						_0 = new int[] { 12610 },
						_1 = 256,
						_2 = null,
					},
					[65459] = new Feature
					{
						_0 = new int[] { 12611 },
						_1 = 256,
						_2 = null,
					},
					[65460] = new Feature
					{
						_0 = new int[] { 12612 },
						_1 = 256,
						_2 = null,
					},
					[65461] = new Feature
					{
						_0 = new int[] { 12613 },
						_1 = 256,
						_2 = null,
					},
					[65462] = new Feature
					{
						_0 = new int[] { 12614 },
						_1 = 256,
						_2 = null,
					},
					[65463] = new Feature
					{
						_0 = new int[] { 12615 },
						_1 = 256,
						_2 = null,
					},
					[65464] = new Feature
					{
						_0 = new int[] { 12616 },
						_1 = 256,
						_2 = null,
					},
					[65465] = new Feature
					{
						_0 = new int[] { 12617 },
						_1 = 256,
						_2 = null,
					},
					[65466] = new Feature
					{
						_0 = new int[] { 12618 },
						_1 = 256,
						_2 = null,
					},
					[65467] = new Feature
					{
						_0 = new int[] { 12619 },
						_1 = 256,
						_2 = null,
					},
					[65468] = new Feature
					{
						_0 = new int[] { 12620 },
						_1 = 256,
						_2 = null,
					},
					[65469] = new Feature
					{
						_0 = new int[] { 12621 },
						_1 = 256,
						_2 = null,
					},
					[65470] = new Feature
					{
						_0 = new int[] { 12622 },
						_1 = 256,
						_2 = null,
					},
					[65474] = new Feature
					{
						_0 = new int[] { 12623 },
						_1 = 256,
						_2 = null,
					},
					[65475] = new Feature
					{
						_0 = new int[] { 12624 },
						_1 = 256,
						_2 = null,
					},
					[65476] = new Feature
					{
						_0 = new int[] { 12625 },
						_1 = 256,
						_2 = null,
					},
					[65477] = new Feature
					{
						_0 = new int[] { 12626 },
						_1 = 256,
						_2 = null,
					},
					[65478] = new Feature
					{
						_0 = new int[] { 12627 },
						_1 = 256,
						_2 = null,
					},
					[65479] = new Feature
					{
						_0 = new int[] { 12628 },
						_1 = 256,
						_2 = null,
					},
					[65482] = new Feature
					{
						_0 = new int[] { 12629 },
						_1 = 256,
						_2 = null,
					},
					[65483] = new Feature
					{
						_0 = new int[] { 12630 },
						_1 = 256,
						_2 = null,
					},
					[65484] = new Feature
					{
						_0 = new int[] { 12631 },
						_1 = 256,
						_2 = null,
					},
					[65485] = new Feature
					{
						_0 = new int[] { 12632 },
						_1 = 256,
						_2 = null,
					},
					[65486] = new Feature
					{
						_0 = new int[] { 12633 },
						_1 = 256,
						_2 = null,
					},
					[65487] = new Feature
					{
						_0 = new int[] { 12634 },
						_1 = 256,
						_2 = null,
					},
					[65490] = new Feature
					{
						_0 = new int[] { 12635 },
						_1 = 256,
						_2 = null,
					},
					[65491] = new Feature
					{
						_0 = new int[] { 12636 },
						_1 = 256,
						_2 = null,
					},
					[65492] = new Feature
					{
						_0 = new int[] { 12637 },
						_1 = 256,
						_2 = null,
					},
					[65493] = new Feature
					{
						_0 = new int[] { 12638 },
						_1 = 256,
						_2 = null,
					},
					[65494] = new Feature
					{
						_0 = new int[] { 12639 },
						_1 = 256,
						_2 = null,
					},
					[65495] = new Feature
					{
						_0 = new int[] { 12640 },
						_1 = 256,
						_2 = null,
					},
					[65498] = new Feature
					{
						_0 = new int[] { 12641 },
						_1 = 256,
						_2 = null,
					},
					[65499] = new Feature
					{
						_0 = new int[] { 12642 },
						_1 = 256,
						_2 = null,
					},
					[65500] = new Feature
					{
						_0 = new int[] { 12643 },
						_1 = 256,
						_2 = null,
					},
					[65504] = new Feature
					{
						_0 = new int[] { 162 },
						_1 = 256,
						_2 = null,
					},
					[65505] = new Feature
					{
						_0 = new int[] { 163 },
						_1 = 256,
						_2 = null,
					},
					[65506] = new Feature
					{
						_0 = new int[] { 172 },
						_1 = 256,
						_2 = null,
					},
					[65507] = new Feature
					{
						_0 = new int[] { 175 },
						_1 = 256,
						_2 = null,
					},
					[65508] = new Feature
					{
						_0 = new int[] { 166 },
						_1 = 256,
						_2 = null,
					},
					[65509] = new Feature
					{
						_0 = new int[] { 165 },
						_1 = 256,
						_2 = null,
					},
					[65510] = new Feature
					{
						_0 = new int[] { 8361 },
						_1 = 256,
						_2 = null,
					},
					[65512] = new Feature
					{
						_0 = new int[] { 9474 },
						_1 = 256,
						_2 = null,
					},
					[65513] = new Feature
					{
						_0 = new int[] { 8592 },
						_1 = 256,
						_2 = null,
					},
					[65514] = new Feature
					{
						_0 = new int[] { 8593 },
						_1 = 256,
						_2 = null,
					},
					[65515] = new Feature
					{
						_0 = new int[] { 8594 },
						_1 = 256,
						_2 = null,
					},
					[65516] = new Feature
					{
						_0 = new int[] { 8595 },
						_1 = 256,
						_2 = null,
					},
					[65517] = new Feature
					{
						_0 = new int[] { 9632 },
						_1 = 256,
						_2 = null,
					},
					[65518] = new Feature
					{
						_0 = new int[] { 9675 },
						_1 = 256,
						_2 = null,
					},
				},
			};
		}
	}
}