using System;
using System.Runtime.InteropServices;

namespace StbTrueTypeSharp
{
#if !STBSHARP_INTERNAL
	public
#else
	internal
#endif
	static partial class StbTrueType
	{
		public const int STBTT_vmove = 1;
		public const int STBTT_vline = 2;
		public const int STBTT_vcurve = 3;
		public const int STBTT_vcubic = 4;

		public const int STBTT_PLATFORM_ID_UNICODE = 0;
		public const int STBTT_PLATFORM_ID_MAC = 1;
		public const int STBTT_PLATFORM_ID_ISO = 2;
		public const int STBTT_PLATFORM_ID_MICROSOFT = 3;

		public const int STBTT_UNICODE_EID_UNICODE_1_0 = 0;
		public const int STBTT_UNICODE_EID_UNICODE_1_1 = 1;
		public const int STBTT_UNICODE_EID_ISO_10646 = 2;
		public const int STBTT_UNICODE_EID_UNICODE_2_0_BMP = 3;
		public const int STBTT_UNICODE_EID_UNICODE_2_0_FULL = 4;

		public const int STBTT_MS_EID_SYMBOL = 0;
		public const int STBTT_MS_EID_UNICODE_BMP = 1;
		public const int STBTT_MS_EID_SHIFTJIS = 2;
		public const int STBTT_MS_EID_UNICODE_FULL = 10;

		public const int STBTT_MAC_EID_ROMAN = 0;
		public const int STBTT_MAC_EID_ARABIC = 4;
		public const int STBTT_MAC_EID_JAPANESE = 1;
		public const int STBTT_MAC_EID_HEBREW = 5;
		public const int STBTT_MAC_EID_CHINESE_TRAD = 2;
		public const int STBTT_MAC_EID_GREEK = 6;
		public const int STBTT_MAC_EID_KOREAN = 3;
		public const int STBTT_MAC_EID_RUSSIAN = 7;

		public const int STBTT_MS_LANG_ENGLISH = 0x0409;
		public const int STBTT_MS_LANG_ITALIAN = 0x0410;
		public const int STBTT_MS_LANG_CHINESE = 0x0804;
		public const int STBTT_MS_LANG_JAPANESE = 0x0411;
		public const int STBTT_MS_LANG_DUTCH = 0x0413;
		public const int STBTT_MS_LANG_KOREAN = 0x0412;
		public const int STBTT_MS_LANG_FRENCH = 0x040c;
		public const int STBTT_MS_LANG_RUSSIAN = 0x0419;
		public const int STBTT_MS_LANG_GERMAN = 0x0407;
		public const int STBTT_MS_LANG_SPANISH = 0x0409;
		public const int STBTT_MS_LANG_HEBREW = 0x040d;
		public const int STBTT_MS_LANG_SWEDISH = 0x041D;

		public const int STBTT_MAC_LANG_ENGLISH = 0;
		public const int STBTT_MAC_LANG_JAPANESE = 11;
		public const int STBTT_MAC_LANG_ARABIC = 12;
		public const int STBTT_MAC_LANG_KOREAN = 23;
		public const int STBTT_MAC_LANG_DUTCH = 4;
		public const int STBTT_MAC_LANG_RUSSIAN = 32;
		public const int STBTT_MAC_LANG_FRENCH = 1;
		public const int STBTT_MAC_LANG_SPANISH = 6;
		public const int STBTT_MAC_LANG_GERMAN = 2;
		public const int STBTT_MAC_LANG_SWEDISH = 5;
		public const int STBTT_MAC_LANG_HEBREW = 10;
		public const int STBTT_MAC_LANG_CHINESE_SIMPLIFIED = 33;
		public const int STBTT_MAC_LANG_ITALIAN = 3;
		public const int STBTT_MAC_LANG_CHINESE_TRAD = 19;

		[StructLayout(LayoutKind.Sequential)]
		public class stbtt__buf
		{
			public FakePtr<byte> data;
			public int cursor;
			public int size;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct stbtt_bakedchar
		{
			public ushort x0;
			public ushort y0;
			public ushort x1;
			public ushort y1;
			public float xoff;
			public float yoff;
			public float xadvance;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct stbtt_aligned_quad
		{
			public float x0;
			public float y0;
			public float s0;
			public float t0;
			public float x1;
			public float y1;
			public float s1;
			public float t1;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class stbtt_packedchar
		{
			public ushort x0;
			public ushort y0;
			public ushort x1;
			public ushort y1;
			public float xoff;
			public float yoff;
			public float xadvance;
			public float xoff2;
			public float yoff2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class stbtt_pack_range
		{
			public float font_size;
			public int first_unicode_codepoint_in_range;
			public int[] array_of_unicode_codepoints;
			public int num_chars;
			public stbtt_packedchar[] chardata_for_range;
			public byte h_oversample;
			public byte v_oversample;
		}

		public class stbtt_pack_context
		{
			public int width;
			public int height;
			public int stride_in_bytes;
			public int padding;
			public int skip_missing;
			public uint h_oversample;
			public uint v_oversample;
			public FakePtr<byte> pixels;
			public stbrp_context pack_info;
		}

		public class stbtt_fontinfo
		{
			public FakePtr<byte> data;
			public int fontstart;
			public int numGlyphs;
			public int loca;
			public int head;
			public int glyf;
			public int hhea;
			public int hmtx;
			public int kern;
			public int gpos;
			public int svg;
			public int index_map;
			public int indexToLocFormat;
			public stbtt__buf cff = new stbtt__buf();
			public stbtt__buf charstrings = new stbtt__buf();
			public stbtt__buf gsubrs = new stbtt__buf();
			public stbtt__buf subrs = new stbtt__buf();
			public stbtt__buf fontdicts = new stbtt__buf();
			public stbtt__buf fdselect = new stbtt__buf();
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct stbtt_kerningentry
		{
			public int glyph1;
			public int glyph2;
			public int advance;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct stbtt_vertex
		{
			public short x;
			public short y;
			public short cx;
			public short cy;
			public short cx1;
			public short cy1;
			public byte type;
			public byte padding;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class stbtt__bitmap
		{
			public int w;
			public int h;
			public int stride;
			public FakePtr<byte> pixels;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class stbtt__csctx
		{
			public int bounds;
			public int started;
			public float first_x;
			public float first_y;
			public float x;
			public float y;
			public int min_x;
			public int max_x;
			public int min_y;
			public int max_y;
			public stbtt_vertex[] pvertices;
			public int num_vertices;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class stbtt__edge
		{
			public float x0;
			public float y0;
			public float x1;
			public float y1;
			public int invert;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class stbtt__active_edge
		{
			public stbtt__active_edge next;
			public float fx;
			public float fdx;
			public float fdy;
			public float direction;
			public float sy;
			public float ey;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct stbtt__point
		{
			public float x;
			public float y;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class stbrp_context
		{
			public int width;
			public int height;
			public int x;
			public int y;
			public int bottom_y;
		}

		[StructLayout(LayoutKind.Sequential)]
		public class stbrp_rect
		{
			public int x;
			public int y;
			public int id;
			public int w;
			public int h;
			public int was_packed;
		}

		public static uint stbtt__find_table(FakePtr<byte> data, uint fontstart, string tag)
		{
			int num_tables = ttUSHORT(data + fontstart + 4);
			var tabledir = fontstart + 12;
			int i;
			for (i = 0; i < num_tables; ++i)
			{
				var loc = (uint)(tabledir + 16 * i);
				if ((data + loc + 0)[0] == tag[0] && (data + loc + 0)[1] == tag[1] &&
					(data + loc + 0)[2] == tag[2] && (data + loc + 0)[3] == tag[3])
					return ttULONG(data + loc + 8);
			}

			return 0;
		}

		public static ushort ttUSHORT(FakePtr<byte> p)
		{
			return (ushort)(p[0] * 256 + p[1]);
		}

		public static short ttSHORT(FakePtr<byte> p)
		{
			return (short)(p[0] * 256 + p[1]);
		}

		public static uint ttULONG(FakePtr<byte> p)
		{
			return (uint)((p[0] << 24) + (p[1] << 16) + (p[2] << 8) + p[3]);
		}

		public static int ttLONG(FakePtr<byte> p)
		{
			return (int)((p[0] << 24) + (p[1] << 16) + (p[2] << 8) + p[3]);
		}

		public static int stbtt__isfont(FakePtr<byte> font)
		{
			if (((((((font)[0]) == ('1')) && (((font)[1]) == (0))) && (((font)[2]) == (0))) && (((font)[3]) == (0))))
				return (int)(1);
			if (((((((font)[0]) == ("typ1"[0])) && (((font)[1]) == ("typ1"[1]))) && (((font)[2]) == ("typ1"[2]))) && (((font)[3]) == ("typ1"[3]))))
				return (int)(1);
			if (((((((font)[0]) == ("OTTO"[0])) && (((font)[1]) == ("OTTO"[1]))) && (((font)[2]) == ("OTTO"[2]))) && (((font)[3]) == ("OTTO"[3]))))
				return (int)(1);
			if (((((((font)[0]) == (0)) && (((font)[1]) == (1))) && (((font)[2]) == (0))) && (((font)[3]) == (0))))
				return (int)(1);
			if (((((((font)[0]) == ("true"[0])) && (((font)[1]) == ("true"[1]))) && (((font)[2]) == ("true"[2]))) && (((font)[3]) == ("true"[3]))))
				return (int)(1);
			return (int)(0);
		}

		public static int stbtt_GetFontOffsetForIndex_internal(FakePtr<byte> font_collection, int index)
		{
			if ((stbtt__isfont(font_collection)) != 0)
				return (int)((index) == (0) ? 0 : -1);
			if (((((((font_collection)[0]) == ("ttcf"[0])) && (((font_collection)[1]) == ("ttcf"[1]))) && (((font_collection)[2]) == ("ttcf"[2]))) && (((font_collection)[3]) == ("ttcf"[3]))))
			{
				if (((ttULONG(font_collection + 4)) == (0x00010000)) || ((ttULONG(font_collection + 4)) == (0x00020000)))
				{
					int n = (int)(ttLONG(font_collection + 8));
					if ((index) >= (n))
						return (int)(-1);
					return (int)(ttULONG(font_collection + 12 + index * 4));
				}
			}

			return (int)(-1);
		}

		public static int stbtt_GetNumberOfFonts_internal(FakePtr<byte> font_collection)
		{
			if ((stbtt__isfont(font_collection)) != 0)
				return (int)(1);
			if (((((((font_collection)[0]) == ("ttcf"[0])) && (((font_collection)[1]) == ("ttcf"[1]))) && (((font_collection)[2]) == ("ttcf"[2]))) && (((font_collection)[3]) == ("ttcf"[3]))))
			{
				if (((ttULONG(font_collection + 4)) == (0x00010000)) || ((ttULONG(font_collection + 4)) == (0x00020000)))
				{
					return (int)(ttLONG(font_collection + 8));
				}
			}

			return (int)(0);
		}

		public static void stbtt_setvertex(ref stbtt_vertex v, byte type, int x, int y, int cx, int cy)
		{
			v.type = (byte)(type);
			v.x = ((short)(x));
			v.y = ((short)(y));
			v.cx = ((short)(cx));
			v.cy = ((short)(cy));
		}

		public static int stbtt__close_shape(stbtt_vertex[] vertices, int num_vertices, int was_off, int start_off, int sx, int sy, int scx, int scy, int cx, int cy)
		{
			stbtt_vertex v = new stbtt_vertex();
			if ((start_off) != 0)
			{
				if ((was_off) != 0)
				{
					stbtt_setvertex(ref v, (byte)(STBTT_vcurve), (int)((cx + scx) >> 1), (int)((cy + scy) >> 1), (int)(cx), (int)(cy));
					vertices[num_vertices++] = v;
				}

				stbtt_setvertex(ref v, (byte)(STBTT_vcurve), (int)(sx), (int)(sy), (int)(scx), (int)(scy));
				vertices[num_vertices++] = v;
			}
			else
			{
				if ((was_off) != 0)
				{
					stbtt_setvertex(ref v, (byte)(STBTT_vcurve), (int)(sx), (int)(sy), (int)(cx), (int)(cy));
					vertices[num_vertices++] = v;
				}
				else
				{
					stbtt_setvertex(ref v, (byte)(STBTT_vline), (int)(sx), (int)(sy), (int)(0), (int)(0));
					vertices[num_vertices++] = v;
				}
			}

			return (int)(num_vertices);
		}

		public static int stbtt__GetCoverageIndex(FakePtr<byte> coverageTable, int glyph)
		{
			ushort coverageFormat = (ushort)(ttUSHORT(coverageTable));
			switch (coverageFormat)
			{
				case 1:
				{
					ushort glyphCount = (ushort)(ttUSHORT(coverageTable + 2));
					int l = (int)(0);
					int r = (int)(glyphCount - 1);
					int m = 0;
					int straw = 0;
					int needle = (int)(glyph);
					while (l <= r)
					{
						FakePtr<byte> glyphArray = coverageTable + 4;
						ushort glyphID = 0;
						m = (int)((l + r) >> 1);
						glyphID = (ushort)(ttUSHORT(glyphArray + 2 * m));
						straw = (int)(glyphID);
						if ((needle) < (straw))
							r = (int)(m - 1);
						else if ((needle) > (straw))
							l = (int)(m + 1);
						else
						{
							return (int)(m);
						}
					}
				}
				break;
				case 2:
				{
					ushort rangeCount = (ushort)(ttUSHORT(coverageTable + 2));
					FakePtr<byte> rangeArray = coverageTable + 4;
					int l = (int)(0);
					int r = (int)(rangeCount - 1);
					int m = 0;
					int strawStart = 0;
					int strawEnd = 0;
					int needle = (int)(glyph);
					while (l <= r)
					{
						FakePtr<byte> rangeRecord;
						m = (int)((l + r) >> 1);
						rangeRecord = rangeArray + 6 * m;
						strawStart = (int)(ttUSHORT(rangeRecord));
						strawEnd = (int)(ttUSHORT(rangeRecord + 2));
						if ((needle) < (strawStart))
							r = (int)(m - 1);
						else if ((needle) > (strawEnd))
							l = (int)(m + 1);
						else
						{
							ushort startCoverageIndex = (ushort)(ttUSHORT(rangeRecord + 4));
							return (int)(startCoverageIndex + glyph - strawStart);
						}
					}
				}
				break;
				default:
				{
				}
				break;
			}

			return (int)(-1);
		}

		public static int stbtt__GetGlyphClass(FakePtr<byte> classDefTable, int glyph)
		{
			ushort classDefFormat = (ushort)(ttUSHORT(classDefTable));
			switch (classDefFormat)
			{
				case 1:
				{
					ushort startGlyphID = (ushort)(ttUSHORT(classDefTable + 2));
					ushort glyphCount = (ushort)(ttUSHORT(classDefTable + 4));
					FakePtr<byte> classDef1ValueArray = classDefTable + 6;
					if (((glyph) >= (startGlyphID)) && ((glyph) < (startGlyphID + glyphCount)))
						return (int)(ttUSHORT(classDef1ValueArray + 2 * (glyph - startGlyphID)));
					classDefTable = classDef1ValueArray + 2 * glyphCount;
				}
				break;
				case 2:
				{
					ushort classRangeCount = (ushort)(ttUSHORT(classDefTable + 2));
					FakePtr<byte> classRangeRecords = classDefTable + 4;
					int l = (int)(0);
					int r = (int)(classRangeCount - 1);
					int m = 0;
					int strawStart = 0;
					int strawEnd = 0;
					int needle = (int)(glyph);
					while (l <= r)
					{
						FakePtr<byte> classRangeRecord;
						m = (int)((l + r) >> 1);
						classRangeRecord = classRangeRecords + 6 * m;
						strawStart = (int)(ttUSHORT(classRangeRecord));
						strawEnd = (int)(ttUSHORT(classRangeRecord + 2));
						if ((needle) < (strawStart))
							r = (int)(m - 1);
						else if ((needle) > (strawEnd))
							l = (int)(m + 1);
						else
							return (int)(ttUSHORT(classRangeRecord + 4));
					}
					classDefTable = classRangeRecords + 6 * classRangeCount;
				}
				break;
				default:
				{
				}
				break;
			}

			return (int)(-1);
		}

		public static stbtt__active_edge stbtt__new_active(stbtt__edge e, int off_x, float start_point)
		{
			var z = new stbtt__active_edge();
			float dxdy = (float)((e.x1 - e.x0) / (e.y1 - e.y0));
			z.fdx = (float)(dxdy);
			z.fdy = (float)(dxdy != 0.0f ? (1.0f / dxdy) : 0.0f);
			z.fx = (float)(e.x0 + dxdy * (start_point - e.y0));
			z.fx -= (float)(off_x);
			z.direction = (float)((e.invert) != 0 ? 1.0f : -1.0f);
			z.sy = (float)(e.y0);
			z.ey = (float)(e.y1);
			z.next = null;
			return z;
		}

		public static void stbtt__handle_clipped_edge(FakePtr<float> scanline, int x, stbtt__active_edge e, float x0, float y0, float x1, float y1)
		{
			if ((y0) == (y1))
				return;
			if ((y0) > (e.ey))
				return;
			if ((y1) < (e.sy))
				return;
			if ((y0) < (e.sy))
			{
				x0 += (float)((x1 - x0) * (e.sy - y0) / (y1 - y0));
				y0 = (float)(e.sy);
			}

			if ((y1) > (e.ey))
			{
				x1 += (float)((x1 - x0) * (e.ey - y1) / (y1 - y0));
				y1 = (float)(e.ey);
			}

			if ((x0 <= x) && (x1 <= x))
			{
				scanline[x] += (float)(e.direction * (y1 - y0));
			}
			else if (((x0) >= (x + 1)) && ((x1) >= (x + 1)))
			{
			}
			else
			{
				scanline[x] += (float)(e.direction * (y1 - y0) * (1 - ((x0 - x) + (x1 - x)) / 2));
			}

		}

		public static void stbtt__fill_active_edges_new(FakePtr<float> scanline, FakePtr<float> scanline_fill, int len, stbtt__active_edge e, float y_top)
		{
			float y_bottom = (float)(y_top + 1);
			while ((e) != null)
			{
				if ((e.fdx) == (0))
				{
					float x0 = (float)(e.fx);
					if ((x0) < (len))
					{
						if ((x0) >= (0))
						{
							stbtt__handle_clipped_edge(scanline, (int)(x0), e, (float)(x0), (float)(y_top), (float)(x0), (float)(y_bottom));
							stbtt__handle_clipped_edge(scanline_fill - 1, (int)((int)(x0) + 1), e, (float)(x0), (float)(y_top), (float)(x0), (float)(y_bottom));
						}
						else
						{
							stbtt__handle_clipped_edge(scanline_fill - 1, (int)(0), e, (float)(x0), (float)(y_top), (float)(x0), (float)(y_bottom));
						}
					}
				}
				else
				{
					float x0 = (float)(e.fx);
					float dx = (float)(e.fdx);
					float xb = (float)(x0 + dx);
					float x_top = 0;
					float x_bottom = 0;
					float sy0 = 0;
					float sy1 = 0;
					float dy = (float)(e.fdy);
					if ((e.sy) > (y_top))
					{
						x_top = (float)(x0 + dx * (e.sy - y_top));
						sy0 = (float)(e.sy);
					}
					else
					{
						x_top = (float)(x0);
						sy0 = (float)(y_top);
					}
					if ((e.ey) < (y_bottom))
					{
						x_bottom = (float)(x0 + dx * (e.ey - y_top));
						sy1 = (float)(e.ey);
					}
					else
					{
						x_bottom = (float)(xb);
						sy1 = (float)(y_bottom);
					}
					if (((((x_top) >= (0)) && ((x_bottom) >= (0))) && ((x_top) < (len))) && ((x_bottom) < (len)))
					{
						if (((int)(x_top)) == ((int)(x_bottom)))
						{
							float height = 0;
							int x = (int)(x_top);
							height = (float)(sy1 - sy0);
							scanline[x] += (float)(e.direction * (1 - ((x_top - x) + (x_bottom - x)) / 2) * height);
							scanline_fill[x] += (float)(e.direction * height);
						}
						else
						{
							int x = 0;
							int x1 = 0;
							int x2 = 0;
							float y_crossing = 0;
							float step = 0;
							float sign = 0;
							float area = 0;
							if ((x_top) > (x_bottom))
							{
								float t = 0;
								sy0 = (float)(y_bottom - (sy0 - y_top));
								sy1 = (float)(y_bottom - (sy1 - y_top));
								t = (float)(sy0);
								sy0 = (float)(sy1);
								sy1 = (float)(t);
								t = (float)(x_bottom);
								x_bottom = (float)(x_top);
								x_top = (float)(t);
								dx = (float)(-dx);
								dy = (float)(-dy);
								t = (float)(x0);
								x0 = (float)(xb);
								xb = (float)(t);
							}
							x1 = ((int)(x_top));
							x2 = ((int)(x_bottom));
							y_crossing = (float)((x1 + 1 - x0) * dy + y_top);
							sign = (float)(e.direction);
							area = (float)(sign * (y_crossing - sy0));
							scanline[x1] += (float)(area * (1 - ((x_top - x1) + (x1 + 1 - x1)) / 2));
							step = (float)(sign * dy);
							for (x = (int)(x1 + 1); (x) < (x2); ++x)
							{
								scanline[x] += (float)(area + step / 2);
								area += (float)(step);
							}
							y_crossing += (float)(dy * (x2 - (x1 + 1)));
							scanline[x2] += (float)(area + sign * (1 - ((x2 - x2) + (x_bottom - x2)) / 2) * (sy1 - y_crossing));
							scanline_fill[x2] += (float)(sign * (sy1 - sy0));
						}
					}
					else
					{
						int x = 0;
						for (x = (int)(0); (x) < (len); ++x)
						{
							float y0 = (float)(y_top);
							float x1 = (float)(x);
							float x2 = (float)(x + 1);
							float x3 = (float)(xb);
							float y3 = (float)(y_bottom);
							float y1 = (float)((x - x0) / dx + y_top);
							float y2 = (float)((x + 1 - x0) / dx + y_top);
							if (((x0) < (x1)) && ((x3) > (x2)))
							{
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x0), (float)(y0), (float)(x1), (float)(y1));
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x1), (float)(y1), (float)(x2), (float)(y2));
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x2), (float)(y2), (float)(x3), (float)(y3));
							}
							else if (((x3) < (x1)) && ((x0) > (x2)))
							{
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x0), (float)(y0), (float)(x2), (float)(y2));
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x2), (float)(y2), (float)(x1), (float)(y1));
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x1), (float)(y1), (float)(x3), (float)(y3));
							}
							else if (((x0) < (x1)) && ((x3) > (x1)))
							{
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x0), (float)(y0), (float)(x1), (float)(y1));
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x1), (float)(y1), (float)(x3), (float)(y3));
							}
							else if (((x3) < (x1)) && ((x0) > (x1)))
							{
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x0), (float)(y0), (float)(x1), (float)(y1));
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x1), (float)(y1), (float)(x3), (float)(y3));
							}
							else if (((x0) < (x2)) && ((x3) > (x2)))
							{
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x0), (float)(y0), (float)(x2), (float)(y2));
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x2), (float)(y2), (float)(x3), (float)(y3));
							}
							else if (((x3) < (x2)) && ((x0) > (x2)))
							{
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x0), (float)(y0), (float)(x2), (float)(y2));
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x2), (float)(y2), (float)(x3), (float)(y3));
							}
							else
							{
								stbtt__handle_clipped_edge(scanline, (int)(x), e, (float)(x0), (float)(y0), (float)(x3), (float)(y3));
							}
						}
					}
				}
				e = e.next;
			}
		}

		public static void stbtt__rasterize_sorted_edges(stbtt__bitmap result, FakePtr<stbtt__edge> e, int n, int vsubsample, int off_x, int off_y)
		{
			stbtt__active_edge active = (null);
			int y = 0;
			int j = (int)(0);
			int i = 0;
			float[] scanline_data = new float[129];
			FakePtr<float> scanline;
			FakePtr<float> scanline2;
			if ((result.w) > (64))
				scanline = FakePtr<float>.CreateWithSize(result.w * 2 + 1);
			else
				scanline = new FakePtr<float>(scanline_data);
			scanline2 = scanline + result.w;
			y = (int)(off_y);
			e[n].y0 = (float)((float)(off_y + result.h) + 1);
			while ((j) < (result.h))
			{
				float scan_y_top = (float)(y + 0.0f);
				float scan_y_bottom = (float)(y + 1.0f);
				stbtt__active_edge step = active;
				scanline.memset(0, result.w);
				scanline2.memset(0, result.w + 1);
				while ((step) != null)
				{
					stbtt__active_edge z = step;
					if (z.ey <= scan_y_top)
					{
						step = z.next;
						z.direction = (float)(0);
					}
					else
					{
						step = step.next;
					}
				} while (e.Value.y0 <= scan_y_bottom)
				{
					if (e.Value.y0 != e.Value.y1)
					{
						stbtt__active_edge z = stbtt__new_active(e.Value, (int)(off_x), (float)(scan_y_top));
						if (z != (null))
						{
							if (((j) == (0)) && (off_y != 0))
							{
								if ((z.ey) < (scan_y_top))
								{
									z.ey = (float)(scan_y_top);
								}
							}
							z.next = active;
							active = z;
						}
					}
					++e;
				}
				if ((active) != null)
					stbtt__fill_active_edges_new(scanline, scanline2 + 1, (int)(result.w), active, (float)(scan_y_top));
				{
					float sum = (float)(0);
					for (i = (int)(0); (i) < (result.w); ++i)
					{
						float k = 0;
						int m = 0;
						sum += (float)(scanline2[i]);
						k = (float)(scanline[i] + sum);
						k = (float)((float)(Math.Abs((double)(k))) * 255 + 0.5f);
						m = ((int)(k));
						if ((m) > (255))
							m = (int)(255);
						result.pixels[j * result.stride + i] = ((byte)(m));
					}
				}
				step = active;
				while ((step) != null)
				{
					stbtt__active_edge z = step;
					z.fx += (float)(z.fdx);
					step = step.next;
				}
				++y;
				++j;
			}
		}

		public static void stbtt__sort_edges_ins_sort(FakePtr<stbtt__edge> p, int n)
		{
			int i = 0;
			int j = 0;
			for (i = (int)(1); (i) < (n); ++i)
			{
				stbtt__edge t = (stbtt__edge)(p[i]);
				stbtt__edge a = t;
				j = (int)(i);
				while ((j) > (0))
				{
					stbtt__edge b = p[j - 1];
					int c = (int)(a.y0 < b.y0 ? 1 : 0);
					if (c == 0)
						break;
					p[j] = (stbtt__edge)(p[j - 1]);
					--j;
				}
				if (i != j)
					p[j] = (stbtt__edge)(t);
			}
		}

		public static void stbtt__sort_edges_quicksort(FakePtr<stbtt__edge> p, int n)
		{
			while ((n) > (12))
			{
				stbtt__edge t = new stbtt__edge();
				int c01 = 0;
				int c12 = 0;
				int c = 0;
				int m = 0;
				int i = 0;
				int j = 0;
				m = (int)(n >> 1);
				c01 = (int)(((p[0]).y0) < ((p[m]).y0) ? 1 : 0);
				c12 = (int)(((p[m]).y0) < ((p[n - 1]).y0) ? 1 : 0);
				if (c01 != c12)
				{
					int z = 0;
					c = (int)(((p[0]).y0) < ((p[n - 1]).y0) ? 1 : 0);
					z = (int)(((c) == (c12)) ? 0 : n - 1);
					t = (stbtt__edge)(p[z]);
					p[z] = (stbtt__edge)(p[m]);
					p[m] = (stbtt__edge)(t);
				}
				t = (stbtt__edge)(p[0]);
				p[0] = (stbtt__edge)(p[m]);
				p[m] = (stbtt__edge)(t);
				i = (int)(1);
				j = (int)(n - 1);
				for (; ; )
				{
					for (; ; ++i)
					{
						if (!(((p[i]).y0) < ((p[0]).y0)))
							break;
					}
					for (; ; --j)
					{
						if (!(((p[0]).y0) < ((p[j]).y0)))
							break;
					}
					if ((i) >= (j))
						break;
					t = (stbtt__edge)(p[i]);
					p[i] = (stbtt__edge)(p[j]);
					p[j] = (stbtt__edge)(t);
					++i;
					--j;
				}
				if ((j) < (n - i))
				{
					stbtt__sort_edges_quicksort(p, (int)(j));
					p = p + i;
					n = (int)(n - i);
				}
				else
				{
					stbtt__sort_edges_quicksort(p + i, (int)(n - i));
					n = (int)(j);
				}
			}
		}

		public static void stbtt__sort_edges(FakePtr<stbtt__edge> p, int n)
		{
			stbtt__sort_edges_quicksort(p, (int)(n));
			stbtt__sort_edges_ins_sort(p, (int)(n));
		}

		public static void stbtt__add_point(stbtt__point[] points, int n, float x, float y)
		{
			if (points == null)
				return;
			points[n].x = (float)(x);
			points[n].y = (float)(y);
		}

		public static int stbtt__tesselate_curve(stbtt__point[] points, ref int num_points, float x0, float y0, float x1, float y1, float x2, float y2, float objspace_flatness_squared, int n)
		{
			float mx = (float)((x0 + 2 * x1 + x2) / 4);
			float my = (float)((y0 + 2 * y1 + y2) / 4);
			float dx = (float)((x0 + x2) / 2 - mx);
			float dy = (float)((y0 + y2) / 2 - my);
			if ((n) > (16))
				return (int)(1);
			if ((dx * dx + dy * dy) > (objspace_flatness_squared))
			{
				stbtt__tesselate_curve(points, ref num_points, (float)(x0), (float)(y0), (float)((x0 + x1) / 2.0f), (float)((y0 + y1) / 2.0f), (float)(mx), (float)(my), (float)(objspace_flatness_squared), (int)(n + 1));
				stbtt__tesselate_curve(points, ref num_points, (float)(mx), (float)(my), (float)((x1 + x2) / 2.0f), (float)((y1 + y2) / 2.0f), (float)(x2), (float)(y2), (float)(objspace_flatness_squared), (int)(n + 1));
			}
			else
			{
				stbtt__add_point(points, num_points, (float)(x2), (float)(y2));
				num_points++;
			}

			return (int)(1);
		}

		public static void stbtt__tesselate_cubic(stbtt__point[] points, ref int num_points, float x0, float y0, float x1, float y1, float x2, float y2, float x3, float y3, float objspace_flatness_squared, int n)
		{
			float dx0 = (float)(x1 - x0);
			float dy0 = (float)(y1 - y0);
			float dx1 = (float)(x2 - x1);
			float dy1 = (float)(y2 - y1);
			float dx2 = (float)(x3 - x2);
			float dy2 = (float)(y3 - y2);
			float dx = (float)(x3 - x0);
			float dy = (float)(y3 - y0);
			float longlen = (float)(Math.Sqrt((double)(dx0 * dx0 + dy0 * dy0)) + Math.Sqrt((double)(dx1 * dx1 + dy1 * dy1)) + Math.Sqrt((double)(dx2 * dx2 + dy2 * dy2)));
			float shortlen = (float)(Math.Sqrt((double)(dx * dx + dy * dy)));
			float flatness_squared = (float)(longlen * longlen - shortlen * shortlen);
			if ((n) > (16))
				return;
			if ((flatness_squared) > (objspace_flatness_squared))
			{
				float x01 = (float)((x0 + x1) / 2);
				float y01 = (float)((y0 + y1) / 2);
				float x12 = (float)((x1 + x2) / 2);
				float y12 = (float)((y1 + y2) / 2);
				float x23 = (float)((x2 + x3) / 2);
				float y23 = (float)((y2 + y3) / 2);
				float xa = (float)((x01 + x12) / 2);
				float ya = (float)((y01 + y12) / 2);
				float xb = (float)((x12 + x23) / 2);
				float yb = (float)((y12 + y23) / 2);
				float mx = (float)((xa + xb) / 2);
				float my = (float)((ya + yb) / 2);
				stbtt__tesselate_cubic(points, ref num_points, (float)(x0), (float)(y0), (float)(x01), (float)(y01), (float)(xa), (float)(ya), (float)(mx), (float)(my), (float)(objspace_flatness_squared), (int)(n + 1));
				stbtt__tesselate_cubic(points, ref num_points, (float)(mx), (float)(my), (float)(xb), (float)(yb), (float)(x23), (float)(y23), (float)(x3), (float)(y3), (float)(objspace_flatness_squared), (int)(n + 1));
			}
			else
			{
				stbtt__add_point(points, num_points, (float)(x3), (float)(y3));
				num_points++;
			}
		}

		public static stbtt__point[] stbtt_FlattenCurves(stbtt_vertex[] vertices, int num_verts, float objspace_flatness, out int[] contour_lengths, out int num_contours)
		{
			stbtt__point[] points = null;
			int num_points = (int)(0);
			float objspace_flatness_squared = (float)(objspace_flatness * objspace_flatness);
			int i = 0;
			int n = (int)(0);
			int start = (int)(0);
			int pass = 0;
			for (i = (int)(0); (i) < (num_verts); ++i)
			{ if ((vertices[i].type) == (STBTT_vmove)) ++n; }
			num_contours = (int)(n);
			contour_lengths = null;
			if ((n) == (0))
				return null;
			contour_lengths = new int[n];

			for (pass = (int)(0); (pass) < (2); ++pass)
			{
				float x = (float)(0);
				float y = (float)(0);
				if ((pass) == (1))
				{
					points = new stbtt__point[num_points];
				}
				num_points = (int)(0);
				n = (int)(-1);
				for (i = (int)(0); (i) < (num_verts); ++i)
				{
					switch (vertices[i].type)
					{
						case STBTT_vmove:
							if ((n) >= (0))
								contour_lengths[n] = (int)(num_points - start);
							++n;
							start = (int)(num_points);
							x = (float)(vertices[i].x);
							y = (float)(vertices[i].y);
							stbtt__add_point(points, (int)(num_points++), (float)(x), (float)(y));
							break;
						case STBTT_vline:
							x = (float)(vertices[i].x);
							y = (float)(vertices[i].y);
							stbtt__add_point(points, (int)(num_points++), (float)(x), (float)(y));
							break;
						case STBTT_vcurve:
							stbtt__tesselate_curve(points, ref num_points, (float)(x), (float)(y), (float)(vertices[i].cx), (float)(vertices[i].cy), (float)(vertices[i].x), (float)(vertices[i].y), (float)(objspace_flatness_squared), (int)(0));
							x = (float)(vertices[i].x);
							y = (float)(vertices[i].y);
							break;
						case STBTT_vcubic:
							stbtt__tesselate_cubic(points, ref num_points, (float)(x), (float)(y), (float)(vertices[i].cx), (float)(vertices[i].cy), (float)(vertices[i].cx1), (float)(vertices[i].cy1), (float)(vertices[i].x), (float)(vertices[i].y), (float)(objspace_flatness_squared), (int)(0));
							x = (float)(vertices[i].x);
							y = (float)(vertices[i].y);
							break;
					}
				} contour_lengths[n] = (int)(num_points - start);
			}

			return points;
		}

		public static int stbtt_BakeFontBitmap_internal(byte[] data, int offset, float pixel_height, FakePtr<byte> pixels, int pw, int ph, int first_char, int num_chars, stbtt_bakedchar[] chardata)
		{
			float scale = 0;
			int x = 0;
			int y = 0;
			int bottom_y = 0;
			int i = 0;
			stbtt_fontinfo f = new stbtt_fontinfo();
			if (stbtt_InitFont(f, data, (int)(offset)) == 0)
				return (int)(-1);
			pixels.memset(0, pw * ph);
			x = (int)(y = (int)(1));
			bottom_y = (int)(1);
			scale = (float)(stbtt_ScaleForPixelHeight(f, (float)(pixel_height)));
			for (i = (int)(0); (i) < (num_chars); ++i)
			{
				int advance = 0;
				int lsb = 0;
				int x0 = 0;
				int y0 = 0;
				int x1 = 0;
				int y1 = 0;
				int gw = 0;
				int gh = 0;
				int g = (int)(stbtt_FindGlyphIndex(f, (int)(first_char + i)));
				stbtt_GetGlyphHMetrics(f, (int)(g), ref advance, ref lsb);
				stbtt_GetGlyphBitmapBox(f, (int)(g), (float)(scale), (float)(scale), ref x0, ref y0, ref x1, ref y1);
				gw = (int)(x1 - x0);
				gh = (int)(y1 - y0);
				if ((x + gw + 1) >= (pw))
				{
					y = (int)(bottom_y);
					x = (int)(1);
				}
				if ((y + gh + 1) >= (ph))
					return (int)(-i);
				stbtt_MakeGlyphBitmap(f, pixels + x + y * pw, (int)(gw), (int)(gh), (int)(pw), (float)(scale), (float)(scale), (int)(g));
				chardata[i].x0 = (ushort)((short)(x));
				chardata[i].y0 = (ushort)((short)(y));
				chardata[i].x1 = (ushort)((short)(x + gw));
				chardata[i].y1 = (ushort)((short)(y + gh));
				chardata[i].xadvance = (float)(scale * advance);
				chardata[i].xoff = ((float)(x0));
				chardata[i].yoff = ((float)(y0));
				x = (int)(x + gw + 1);
				if ((y + gh + 1) > (bottom_y))
					bottom_y = (int)(y + gh + 1);
			}
			return (int)(bottom_y);
		}

		public static void stbtt_GetBakedQuad(stbtt_bakedchar[] chardata, int pw, int ph, int char_index, ref float xpos, ref float ypos, ref stbtt_aligned_quad q, int opengl_fillrule)
		{
			float d3d_bias = (float)((opengl_fillrule) != 0 ? 0 : -0.5f);
			float ipw = (float)(1.0f / pw);
			float iph = (float)(1.0f / ph);
			int round_x = ((int)(Math.Floor((double)((xpos + chardata[char_index].xoff) + 0.5f))));
			int round_y = ((int)(Math.Floor((double)((ypos + chardata[char_index].yoff) + 0.5f))));
			q.x0 = (float)(round_x + d3d_bias);
			q.y0 = (float)(round_y + d3d_bias);
			q.x1 = (float)(round_x + chardata[char_index].x1 - chardata[char_index].x0 + d3d_bias);
			q.y1 = (float)(round_y + chardata[char_index].y1 - chardata[char_index].y0 + d3d_bias);
			q.s0 = (float)(chardata[char_index].x0 * ipw);
			q.t0 = (float)(chardata[char_index].y0 * iph);
			q.s1 = (float)(chardata[char_index].x1 * ipw);
			q.t1 = (float)(chardata[char_index].y1 * iph);
			xpos += (float)(chardata[char_index].xadvance);
		}

		public static void stbtt__h_prefilter(FakePtr<byte> pixels, int w, int h, int stride_in_bytes, uint kernel_width)
		{
			byte[] buffer = new byte[8];
			int safe_w = (int)(w - kernel_width);
			int j = 0;

			Array.Clear(buffer, 0, 8);
			for (j = (int)(0); (j) < (h); ++j)
			{
				int i = 0;
				uint total = 0;
				Array.Clear(buffer, 0, (int)kernel_width);
				total = (uint)(0);
				switch (kernel_width)
				{
					case 2:
						for (i = (int)(0); i <= safe_w; ++i)
						{
							total += (uint)(pixels[i] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i]);
							pixels[i] = ((byte)(total / 2));
						}
						break;
					case 3:
						for (i = (int)(0); i <= safe_w; ++i)
						{
							total += (uint)(pixels[i] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i]);
							pixels[i] = ((byte)(total / 3));
						}
						break;
					case 4:
						for (i = (int)(0); i <= safe_w; ++i)
						{
							total += (uint)(pixels[i] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i]);
							pixels[i] = ((byte)(total / 4));
						}
						break;
					case 5:
						for (i = (int)(0); i <= safe_w; ++i)
						{
							total += (uint)(pixels[i] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i]);
							pixels[i] = ((byte)(total / 5));
						}
						break;
					default:
						for (i = (int)(0); i <= safe_w; ++i)
						{
							total += (uint)(pixels[i] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i]);
							pixels[i] = ((byte)(total / kernel_width));
						}
						break;
				}
				for (; (i) < (w); ++i)
				{
					total -= (uint)(buffer[i & (8 - 1)]);
					pixels[i] = ((byte)(total / kernel_width));
				}
				pixels += stride_in_bytes;
			}
		}

		public static void stbtt__v_prefilter(FakePtr<byte> pixels, int w, int h, int stride_in_bytes, uint kernel_width)
		{
			byte[] buffer = new byte[8];
			int safe_h = (int)(h - kernel_width);
			int j = 0;
			Array.Clear(buffer, 0, 8);
			for (j = (int)(0); (j) < (w); ++j)
			{
				int i = 0;
				uint total = 0;
				Array.Clear(buffer, 0, (int)kernel_width);
				total = (uint)(0);
				switch (kernel_width)
				{
					case 2:
						for (i = (int)(0); i <= safe_h; ++i)
						{
							total += (uint)(pixels[i * stride_in_bytes] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i * stride_in_bytes]);
							pixels[i * stride_in_bytes] = ((byte)(total / 2));
						}
						break;
					case 3:
						for (i = (int)(0); i <= safe_h; ++i)
						{
							total += (uint)(pixels[i * stride_in_bytes] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i * stride_in_bytes]);
							pixels[i * stride_in_bytes] = ((byte)(total / 3));
						}
						break;
					case 4:
						for (i = (int)(0); i <= safe_h; ++i)
						{
							total += (uint)(pixels[i * stride_in_bytes] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i * stride_in_bytes]);
							pixels[i * stride_in_bytes] = ((byte)(total / 4));
						}
						break;
					case 5:
						for (i = (int)(0); i <= safe_h; ++i)
						{
							total += (uint)(pixels[i * stride_in_bytes] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i * stride_in_bytes]);
							pixels[i * stride_in_bytes] = ((byte)(total / 5));
						}
						break;
					default:
						for (i = (int)(0); i <= safe_h; ++i)
						{
							total += (uint)(pixels[i * stride_in_bytes] - buffer[i & (8 - 1)]);
							buffer[(i + kernel_width) & (8 - 1)] = (byte)(pixels[i * stride_in_bytes]);
							pixels[i * stride_in_bytes] = ((byte)(total / kernel_width));
						}
						break;
				}
				for (; (i) < (h); ++i)
				{
					total -= (uint)(buffer[i & (8 - 1)]);
					pixels[i * stride_in_bytes] = ((byte)(total / kernel_width));
				}
				pixels += 1;
			}
		}

		public static float stbtt__oversample_shift(int oversample)
		{
			if (oversample == 0)
				return (float)(0.0f);
			return (float)((float)(-(oversample - 1)) / (2.0f * (float)(oversample)));
		}

		public static void stbtt_GetScaledFontVMetrics(byte[] fontdata, int index, float size, ref float ascent, ref float descent, ref float lineGap)
		{
			int i_ascent = 0;
			int i_descent = 0;
			int i_lineGap = 0;
			float scale = 0;
			stbtt_fontinfo info = new stbtt_fontinfo();
			stbtt_InitFont(info, fontdata, (int)(stbtt_GetFontOffsetForIndex(fontdata, (int)(index))));
			scale = (float)((size) > (0) ? stbtt_ScaleForPixelHeight(info, (float)(size)) : stbtt_ScaleForMappingEmToPixels(info, (float)(-size)));
			stbtt_GetFontVMetrics(info, out i_ascent, out i_descent, out i_lineGap);
			ascent = (float)((float)(i_ascent) * scale);
			descent = (float)((float)(i_descent) * scale);
			lineGap = (float)((float)(i_lineGap) * scale);
		}

		public static void stbtt_GetPackedQuad(stbtt_packedchar[] chardata, int pw, int ph, int char_index, ref float xpos, ref float ypos, ref stbtt_aligned_quad q, int align_to_integer)
		{
			float ipw = (float)(1.0f / pw);
			float iph = (float)(1.0f / ph);
			stbtt_packedchar b = chardata[char_index];
			if ((align_to_integer) != 0)
			{
				float x = (float)((int)(Math.Floor((double)((xpos + b.xoff) + 0.5f))));
				float y = (float)((int)(Math.Floor((double)((ypos + b.yoff) + 0.5f))));
				q.x0 = (float)(x);
				q.y0 = (float)(y);
				q.x1 = (float)(x + b.xoff2 - b.xoff);
				q.y1 = (float)(y + b.yoff2 - b.yoff);
			}
			else
			{
				q.x0 = (float)(xpos + b.xoff);
				q.y0 = (float)(ypos + b.yoff);
				q.x1 = (float)(xpos + b.xoff2);
				q.y1 = (float)(ypos + b.yoff2);
			}

			q.s0 = (float)(b.x0 * ipw);
			q.t0 = (float)(b.y0 * iph);
			q.s1 = (float)(b.x1 * ipw);
			q.t1 = (float)(b.y1 * iph);
			xpos += (float)(b.xadvance);
		}

		public static int stbtt__ray_intersect_bezier(float[] orig, float[] ray, float[] q0, float[] q1, float[] q2, float[] hits)
		{
			float q0perp = (float)(q0[1] * ray[0] - q0[0] * ray[1]);
			float q1perp = (float)(q1[1] * ray[0] - q1[0] * ray[1]);
			float q2perp = (float)(q2[1] * ray[0] - q2[0] * ray[1]);
			float roperp = (float)(orig[1] * ray[0] - orig[0] * ray[1]);
			float a = (float)(q0perp - 2 * q1perp + q2perp);
			float b = (float)(q1perp - q0perp);
			float c = (float)(q0perp - roperp);
			float s0 = (float)(0);
			float s1 = (float)(0);
			int num_s = (int)(0);
			if (a != 0.0)
			{
				float discr = (float)(b * b - a * c);
				if ((discr) > (0.0))
				{
					float rcpna = (float)(-1 / a);
					float d = (float)(Math.Sqrt((double)(discr)));
					s0 = (float)((b + d) * rcpna);
					s1 = (float)((b - d) * rcpna);
					if (((s0) >= (0.0)) && (s0 <= 1.0))
						num_s = (int)(1);
					if ((((d) > (0.0)) && ((s1) >= (0.0))) && (s1 <= 1.0))
					{
						if ((num_s) == (0))
							s0 = (float)(s1);
						++num_s;
					}
				}
			}
			else
			{
				s0 = (float)(c / (-2 * b));
				if (((s0) >= (0.0)) && (s0 <= 1.0))
					num_s = (int)(1);
			}

			if ((num_s) == (0))
				return (int)(0);
			else
			{
				float rcp_len2 = (float)(1 / (ray[0] * ray[0] + ray[1] * ray[1]));
				float rayn_x = (float)(ray[0] * rcp_len2);
				float rayn_y = (float)(ray[1] * rcp_len2);
				float q0d = (float)(q0[0] * rayn_x + q0[1] * rayn_y);
				float q1d = (float)(q1[0] * rayn_x + q1[1] * rayn_y);
				float q2d = (float)(q2[0] * rayn_x + q2[1] * rayn_y);
				float rod = (float)(orig[0] * rayn_x + orig[1] * rayn_y);
				float q10d = (float)(q1d - q0d);
				float q20d = (float)(q2d - q0d);
				float q0rd = (float)(q0d - rod);
				hits[0] = (float)(q0rd + s0 * (2.0f - 2.0f * s0) * q10d + s0 * s0 * q20d);
				hits[1] = (float)(a * s0 + b);
				if ((num_s) > (1))
				{
					hits[2] = (float)(q0rd + s1 * (2.0f - 2.0f * s1) * q10d + s1 * s1 * q20d);
					hits[3] = (float)(a * s1 + b);
					return (int)(2);
				}
				else
				{
					return (int)(1);
				}
			}

		}

		public static int equal(float[] a, float[] b)
		{
			return (int)(((a[0] == b[0]) && (a[1] == b[1])) ? 1 : 0);
		}

		public static int stbtt__compute_crossings_x(float x, float y, int nverts, stbtt_vertex[] verts)
		{
			int i = 0;
			float[] orig = new float[2];
			float[] ray = new float[2];
			ray[0] = (float)(1);
			ray[1] = (float)(0);

			float y_frac = 0;
			int winding = (int)(0);
			orig[0] = (float)(x);
			orig[1] = (float)(y);
			y_frac = ((float)(y % 1.0f));
			if ((y_frac) < (0.01f))
				y += (float)(0.01f);
			else if ((y_frac) > (0.99f))
				y -= (float)(0.01f);
			orig[1] = (float)(y);
			for (i = (int)(0); (i) < (nverts); ++i)
			{
				if ((verts[i].type) == (STBTT_vline))
				{
					int x0 = (int)(verts[i - 1].x);
					int y0 = (int)(verts[i - 1].y);
					int x1 = (int)(verts[i].x);
					int y1 = (int)(verts[i].y);
					if ((((y) > ((y0) < (y1) ? (y0) : (y1))) && ((y) < ((y0) < (y1) ? (y1) : (y0)))) && ((x) > ((x0) < (x1) ? (x0) : (x1))))
					{
						float x_inter = (float)((y - y0) / (y1 - y0) * (x1 - x0) + x0);
						if ((x_inter) < (x))
							winding += (int)(((y0) < (y1)) ? 1 : -1);
					}
				}
				if ((verts[i].type) == (STBTT_vcurve))
				{
					int x0 = (int)(verts[i - 1].x);
					int y0 = (int)(verts[i - 1].y);
					int x1 = (int)(verts[i].cx);
					int y1 = (int)(verts[i].cy);
					int x2 = (int)(verts[i].x);
					int y2 = (int)(verts[i].y);
					int ax = (int)((x0) < ((x1) < (x2) ? (x1) : (x2)) ? (x0) : ((x1) < (x2) ? (x1) : (x2)));
					int ay = (int)((y0) < ((y1) < (y2) ? (y1) : (y2)) ? (y0) : ((y1) < (y2) ? (y1) : (y2)));
					int by = (int)((y0) < ((y1) < (y2) ? (y2) : (y1)) ? ((y1) < (y2) ? (y2) : (y1)) : (y0));
					if ((((y) > (ay)) && ((y) < (by))) && ((x) > (ax)))
					{
						float[] q0 = new float[2];
						float[] q1 = new float[2];
						float[] q2 = new float[2];
						float[] hits = new float[4];
						q0[0] = ((float)(x0));
						q0[1] = ((float)(y0));
						q1[0] = ((float)(x1));
						q1[1] = ((float)(y1));
						q2[0] = ((float)(x2));
						q2[1] = ((float)(y2));
						if (((equal(q0, q1)) != 0) || ((equal(q1, q2)) != 0))
						{
							x0 = ((int)(verts[i - 1].x));
							y0 = ((int)(verts[i - 1].y));
							x1 = ((int)(verts[i].x));
							y1 = ((int)(verts[i].y));
							if ((((y) > ((y0) < (y1) ? (y0) : (y1))) && ((y) < ((y0) < (y1) ? (y1) : (y0)))) && ((x) > ((x0) < (x1) ? (x0) : (x1))))
							{
								float x_inter = (float)((y - y0) / (y1 - y0) * (x1 - x0) + x0);
								if ((x_inter) < (x))
									winding += (int)(((y0) < (y1)) ? 1 : -1);
							}
						}
						else
						{
							int num_hits = (int)(stbtt__ray_intersect_bezier(orig, ray, q0, q1, q2, hits));
							if ((num_hits) >= (1))
								if ((hits[0]) < (0))
									winding += (int)((hits[1]) < (0) ? -1 : 1);
							if ((num_hits) >= (2))
								if ((hits[2]) < (0))
									winding += (int)((hits[3]) < (0) ? -1 : 1);
						}
					}
				}
			}
			return (int)(winding);
		}

		public static float stbtt__cuberoot(float x)
		{
			if ((x) < (0))
				return (float)(-(float)(Math.Pow((double)(-x), (double)(1.0f / 3.0f))));
			else
				return (float)(Math.Pow((double)(x), (double)(1.0f / 3.0f)));
		}

		public static int stbtt__solve_cubic(float a, float b, float c, float[] r)
		{
			float s = (float)(-a / 3);
			float p = (float)(b - a * a / 3);
			float q = (float)(a * (2 * a * a - 9 * b) / 27 + c);
			float p3 = (float)(p * p * p);
			float d = (float)(q * q + 4 * p3 / 27);
			if ((d) >= (0))
			{
				float z = (float)(Math.Sqrt((double)(d)));
				float u = (float)((-q + z) / 2);
				float v = (float)((-q - z) / 2);
				u = (float)(stbtt__cuberoot((float)(u)));
				v = (float)(stbtt__cuberoot((float)(v)));
				r[0] = (float)(s + u + v);
				return (int)(1);
			}
			else
			{
				float u = (float)(Math.Sqrt((double)(-p / 3)));
				float v = (float)((float)(Math.Acos((double)(-Math.Sqrt((double)(-27 / p3)) * q / 2))) / 3);
				float m = (float)(Math.Cos((double)(v)));
				float n = (float)((float)(Math.Cos((double)(v - 3.141592 / 2))) * 1.732050808f);
				r[0] = (float)(s + u * 2 * m);
				r[1] = (float)(s - u * (m + n));
				r[2] = (float)(s - u * (m - n));
				return (int)(3);
			}
		}

		public static int stbtt__CompareUTF8toUTF16_bigendian_prefix(FakePtr<byte> s1, int len1, FakePtr<byte> s2, int len2)
		{
			int i = (int)(0);
			while ((len2) != 0)
			{
				ushort ch = (ushort)(s2[0] * 256 + s2[1]);
				if ((ch) < (0x80))
				{
					if ((i) >= (len1))
						return (int)(-1);
					if (s1[i++] != ch)
						return (int)(-1);
				}
				else if ((ch) < (0x800))
				{
					if ((i + 1) >= (len1))
						return (int)(-1);
					if (s1[i++] != 0xc0 + (ch >> 6))
						return (int)(-1);
					if (s1[i++] != 0x80 + (ch & 0x3f))
						return (int)(-1);
				}
				else if (((ch) >= (0xd800)) && ((ch) < (0xdc00)))
				{
					uint c = 0;
					ushort ch2 = (ushort)(s2[2] * 256 + s2[3]);
					if ((i + 3) >= (len1))
						return (int)(-1);
					c = (uint)(((ch - 0xd800) << 10) + (ch2 - 0xdc00) + 0x10000);
					if (s1[i++] != 0xf0 + (c >> 18))
						return (int)(-1);
					if (s1[i++] != 0x80 + ((c >> 12) & 0x3f))
						return (int)(-1);
					if (s1[i++] != 0x80 + ((c >> 6) & 0x3f))
						return (int)(-1);
					if (s1[i++] != 0x80 + ((c) & 0x3f))
						return (int)(-1);
					s2 += 2;
					len2 -= (int)(2);
				}
				else if (((ch) >= (0xdc00)) && ((ch) < (0xe000)))
				{
					return (int)(-1);
				}
				else
				{
					if ((i + 2) >= (len1))
						return (int)(-1);
					if (s1[i++] != 0xe0 + (ch >> 12))
						return (int)(-1);
					if (s1[i++] != 0x80 + ((ch >> 6) & 0x3f))
						return (int)(-1);
					if (s1[i++] != 0x80 + ((ch) & 0x3f))
						return (int)(-1);
				}
				s2 += 2;
				len2 -= (int)(2);
			}
			return (int)(i);
		}

		public static int stbtt_CompareUTF8toUTF16_bigendian_internal(FakePtr<byte> s1, int len1, FakePtr<byte> s2, int len2)
		{
			return (int)((len1) == (stbtt__CompareUTF8toUTF16_bigendian_prefix((FakePtr<byte>)(s1), (int)(len1), (FakePtr<byte>)(s2), (int)(len2))) ? 1 : 0);
		}

		public static int stbtt__matchpair(FakePtr<byte> fc, uint nm, FakePtr<byte> name, int nlen, int target_id, int next_id)
		{
			int i = 0;
			int count = (int)(ttUSHORT(fc + nm + 2));
			int stringOffset = (int)(nm + ttUSHORT(fc + nm + 4));
			for (i = (int)(0); (i) < (count); ++i)
			{
				uint loc = (uint)(nm + 6 + 12 * i);
				int id = (int)(ttUSHORT(fc + loc + 6));
				if ((id) == (target_id))
				{
					int platform = (int)(ttUSHORT(fc + loc + 0));
					int encoding = (int)(ttUSHORT(fc + loc + 2));
					int language = (int)(ttUSHORT(fc + loc + 4));
					if ((((platform) == (0)) || (((platform) == (3)) && ((encoding) == (1)))) || (((platform) == (3)) && ((encoding) == (10))))
					{
						int slen = (int)(ttUSHORT(fc + loc + 8));
						int off = (int)(ttUSHORT(fc + loc + 10));
						int matchlen = (int)(stbtt__CompareUTF8toUTF16_bigendian_prefix(name, (int)(nlen), fc + stringOffset + off, (int)(slen)));
						if ((matchlen) >= (0))
						{
							if ((((((i + 1) < (count)) && ((ttUSHORT(fc + loc + 12 + 6)) == (next_id))) && ((ttUSHORT(fc + loc + 12)) == (platform))) && ((ttUSHORT(fc + loc + 12 + 2)) == (encoding))) && ((ttUSHORT(fc + loc + 12 + 4)) == (language)))
							{
								slen = (int)(ttUSHORT(fc + loc + 12 + 8));
								off = (int)(ttUSHORT(fc + loc + 12 + 10));
								if ((slen) == (0))
								{
									if ((matchlen) == (nlen))
										return (int)(1);
								}
								else if (((matchlen) < (nlen)) && ((name[matchlen]) == (' ')))
								{
									++matchlen;
									if ((stbtt_CompareUTF8toUTF16_bigendian_internal((FakePtr<byte>)(name + matchlen), (int)(nlen - matchlen), (FakePtr<byte>)(fc + stringOffset + off), (int)(slen))) != 0)
										return (int)(1);
								}
							}
							else
							{
								if ((matchlen) == (nlen))
									return (int)(1);
							}
						}
					}
				}
			}
			return (int)(0);
		}

		public static int stbtt__matches(byte[] data, uint offset, FakePtr<byte> name, int flags)
		{
			int nlen = 0;
			var ptr = name;

			while (ptr.GetAndIncrease() != '\0')
				ptr++;

			nlen = ptr.Offset - name.Offset - 1;
			uint nm = 0;
			uint hd = 0;

			FakePtr<byte> fc = new FakePtr<byte>(data);
			if (stbtt__isfont(fc + offset) == 0)
				return (int)(0);
			if ((flags) != 0)
			{
				hd = (uint)(stbtt__find_table(fc, (uint)(offset), "head"));
				if ((ttUSHORT(fc + hd + 44) & 7) != (flags & 7))
					return (int)(0);
			}

			nm = (uint)(stbtt__find_table(fc, (uint)(offset), "name"));
			if (nm == 0)
				return (int)(0);
			if ((flags) != 0)
			{
				if ((stbtt__matchpair(fc, (uint)(nm), name, (int)(nlen), (int)(16), (int)(-1))) != 0)
					return (int)(1);
				if ((stbtt__matchpair(fc, (uint)(nm), name, (int)(nlen), (int)(1), (int)(-1))) != 0)
					return (int)(1);
				if ((stbtt__matchpair(fc, (uint)(nm), name, (int)(nlen), (int)(3), (int)(-1))) != 0)
					return (int)(1);
			}
			else
			{
				if ((stbtt__matchpair(fc, (uint)(nm), name, (int)(nlen), (int)(16), (int)(17))) != 0)
					return (int)(1);
				if ((stbtt__matchpair(fc, (uint)(nm), name, (int)(nlen), (int)(1), (int)(2))) != 0)
					return (int)(1);
				if ((stbtt__matchpair(fc, (uint)(nm), name, (int)(nlen), (int)(3), (int)(-1))) != 0)
					return (int)(1);
			}

			return (int)(0);
		}

		public static int stbtt_FindMatchingFont_internal(byte[] font_collection, FakePtr<byte> name_utf8, int flags)
		{
			int i = 0;
			for (i = (int)(0); ; ++i)
			{
				int off = (int)(stbtt_GetFontOffsetForIndex(font_collection, (int)(i)));
				if ((off) < (0))
					return (int)(off);
				if ((stbtt__matches(font_collection, (uint)(off), (FakePtr<byte>)(name_utf8), (int)(flags))) != 0)
					return (int)(off);
			}
		}

		public static int stbtt_BakeFontBitmap(byte[] data, int offset, float pixel_height, FakePtr<byte> pixels, int pw, int ph, int first_char, int num_chars, stbtt_bakedchar[] chardata)
		{
			return (int)(stbtt_BakeFontBitmap_internal(data, (int)(offset), (float)(pixel_height), pixels, (int)(pw), (int)(ph), (int)(first_char), (int)(num_chars), chardata));
		}

		public static int stbtt_GetFontOffsetForIndex(byte[] data, int index)
		{
			return (int)(stbtt_GetFontOffsetForIndex_internal(new FakePtr<byte>(data), (int)(index)));
		}

		public static int stbtt_GetNumberOfFonts(FakePtr<byte> data)
		{
			return (int)(stbtt_GetNumberOfFonts_internal(data));
		}

		public static int stbtt_FindMatchingFont(byte[] fontdata, FakePtr<byte> name, int flags)
		{
			return (int)(stbtt_FindMatchingFont_internal(fontdata, name, (int)(flags)));
		}

		public static int stbtt_CompareUTF8toUTF16_bigendian(FakePtr<byte> s1, int len1, FakePtr<byte> s2, int len2)
		{
			return (int)(stbtt_CompareUTF8toUTF16_bigendian_internal(s1, (int)(len1), s2, (int)(len2)));
		}
	}
}