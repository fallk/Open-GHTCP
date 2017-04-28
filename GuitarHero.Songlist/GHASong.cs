using System;
using ns15;
using ns18;
using ns19;
using ns20;
using ns21;

namespace GuitarHero.Songlist
{
	[Serializable]
	public class GhaSong : Gh3Song
	{
		public string CoveredBy = "Wavegroup";

		public string Band = "default_band";

		public string SingerAnimPak = "";

		public int ThinFretbar_8NoteParamsHighBpm;

		public bool PerryMicStand;

		public bool GuitaristChecksum;

		public GhaSong()
		{
		}

		public GhaSong(StructurePointerNode class3020)
		{
			vmethod_4(class3020);
		}

		public GhaSong(string string0)
		{
			Title = string0;
			Name = string0;
			Leaderboard = true;
			Editable = true;
		}

		public override void vmethod_0(INterface16 interface160)
		{
			base.vmethod_0(interface160);
			if (interface160 is GhaSong)
			{
				var gHaSong = interface160 as GhaSong;
				gHaSong.CoveredBy = CoveredBy;
				gHaSong.Band = Band;
				gHaSong.GuitaristChecksum = GuitaristChecksum;
				gHaSong.SingerAnimPak = SingerAnimPak;
				gHaSong.ThinFretbar_8NoteParamsHighBpm = ThinFretbar_8NoteParamsHighBpm;
				gHaSong.PerryMicStand = PerryMicStand;
			}
		}

		public override void vmethod_4(StructurePointerNode class3020)
		{
			base.vmethod_4(class3020);
			UnicodeStructureNode @class;
			CoveredBy = (((@class = class3020.method_5(new UnicodeStructureNode("covered_by"))) != null) ? @class.method_8() : "");
			TagStructureNode class2;
			Band = (((class2 = class3020.method_5(new TagStructureNode("band"))) != null) ? class2.method_8() : "default_band");
			GuitaristChecksum = ((class2 = class3020.method_5(new TagStructureNode("guitarist_checksum"))) != null && class2.method_8() == "aerosmith");
			AsciiStructureNode class3;
			SingerAnimPak = (((class3 = class3020.method_5(new AsciiStructureNode("singer_anim_pak"))) != null) ? class3.method_8() : "");
			IntegerStructureNode class4;
			ThinFretbar_8NoteParamsHighBpm = (((class4 = class3020.method_5(new IntegerStructureNode("thin_fretbar_8note_params_high_bpm"))) != null) ? class4.method_8() : 0);
			PerryMicStand = ((class4 = class3020.method_5(new IntegerStructureNode("perry_mic_stand"))) != null && class4.method_8() == 1);
		}

		public override StructurePointerNode vmethod_5()
		{
			var @class = base.vmethod_5();
			var class2 = @class.method_8();
			if (!CoveredBy.Equals(""))
			{
				class2.method_3(new UnicodeStructureNode("covered_by", CoveredBy));
			}
			class2.method_3(new TagStructureNode("band", Band));
			if (GuitaristChecksum)
			{
				class2.method_3(new TagStructureNode("guitarist_checksum", "aerosmith"));
			}
			if (!SingerAnimPak.Equals(""))
			{
				class2.method_3(new AsciiStructureNode("singer_anim_pak", SingerAnimPak));
			}
			if (ThinFretbar_8NoteParamsHighBpm != 0)
			{
				class2.method_3(new IntegerStructureNode("band_playback_volume", ThinFretbar_8NoteParamsHighBpm));
			}
			if (PerryMicStand)
			{
				class2.method_3(new IntegerStructureNode("band_playback_volume", 1));
			}
			return @class;
		}
	}
}
