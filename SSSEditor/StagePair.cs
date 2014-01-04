﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSEditor {
	public class StagePair {
		public byte stage;
		public byte icon;
		public override string ToString() {
			return "[0x" + stage.ToString("X2") + ", " + icon.ToString("D2") + "]";
		}
		public ushort ToUshort() {
			return (ushort)(stage * 0x100 + icon);
		}
		public override int GetHashCode() {
			return ToUshort();
		}
		public override bool Equals(object obj) {
			return (obj is StagePair && ((StagePair)obj).ToUshort() == this.ToUshort());
		}
	}
}
