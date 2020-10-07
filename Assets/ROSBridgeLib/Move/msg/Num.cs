using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;

/* 
 * @brief ROSBridgeLib
 * @author Michael Jenkin, Robert Codd-Downey, Andrew Speers and Miquel Massot Campos
 */

namespace ROSBridgeLib {
	namespace  Move{
            public class Num : ROSBridgeMsg {
                   public long _num2;
                   public long _num;
           public Num(JSONNode msg) {
				_num2 = long.Parse(msg["num2"]);
				_num = long.Parse(msg["num"]);
				
			}
			
			public Num(long num2, long num) {
				_num2=num2;
                                _num=num;
			}
           public static string GetMessageType() {
				return "Move/Num";
			}
			
			public long Getnum2() {
				return _num2;
			}
			
			public long Getnum() {
				return _num;
			}
	public override string ToString() {
				return "Num [num2=" + _num2 + ",  num="+ _num +  "]";
			}
			
			public override string ToYAMLString() {
				return "{\"num2\" : " + _num2 + ", \"num\" : " + _num +   "}";
			}
}}}
           





