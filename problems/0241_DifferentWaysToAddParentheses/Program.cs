﻿namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.DiffWaysToCompute, "6", IntArray("[6]"));
            Test.Check(solution.DiffWaysToCompute, "11", IntArray("[11]"));
            Test.Check(solution.DiffWaysToCompute, "2+1", IntArray("[3]"));
            Test.Check(solution.DiffWaysToCompute, "2+2*2", IntArray("[6,8]"));
            Test.Check(solution.DiffWaysToCompute, "2-1-1", IntArray("[0,2]"));
            Test.Check(solution.DiffWaysToCompute, "2*3-4*5", IntArray("[-34,-14,-10,-10,10]"));
            Test.Check(solution.DiffWaysToCompute, "2*3-4*5-6*7", IntArray(" [-322,-322,-280,-190,-154,-154,-154,-154,-140,-118,-112,-112,-94,-92,-76,-74,-56,-56,-52,-52,-32,-14,-14,14,14,14,14,14,28,28,34,34,50,62,62,70,74,74,98,98,154,302] "));
            Test.Check(solution.DiffWaysToCompute, "2*3-4*5-6*7-8*9", IntArray("[-3154,-3042,-3042,-2970,-2970,-2592,-1854,-1854,-1782,-1614,-1574,-1566,-1566,-1530,-1530,-1530,-1530,-1458,-1458,-1458,-1458,-1332,-1206,-1206,-1134,-1080,-1080,-990,-990,-918,-918,-918,-910,-910,-900,-814,-810,-810,-804,-790,-790,-786,-786,-756,-756,-738,-738,-738,-702,-702,-650,-646,-622,-612,-602,-576,-576,-540,-540,-522,-522,-514,-514,-466,-466,-466,-462,-432,-414,-414,-404,-396,-396,-394,-394,-390,-390,-360,-352,-342,-340,-334,-320,-316,-316,-298,-298,-296,-274,-270,-270,-262,-262,-260,-254,-254,-252,-238,-230,-230,-228,-226,-226,-226,-226,-218,-216,-212,-198,-198,-198,-198,-198,-198,-198,-198,-198,-190,-184,-184,-180,-166,-164,-158,-148,-146,-142,-142,-134,-130,-130,-130,-130,-130,-130,-130,-128,-128,-126,-126,-126,-126,-126,-124,-124,-118,-118,-118,-118,-104,-94,-94,-90,-90,-86,-86,-82,-82,-72,-70,-70,-70,-68,-68,-66,-66,-66,-66,-66,-58,-58,-58,-58,-58,-46,-46,-44,-44,-44,-38,-38,-36,-36,-36,-36,-30,-30,-30,-30,-30,-22,-20,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-18,-10,-10,-4,-2,2,2,16,18,18,18,18,18,18,18,18,18,20,20,20,20,26,26,26,40,40,40,44,44,44,44,50,54,54,54,54,54,64,64,70,72,72,74,74,82,98,98,100,106,106,118,118,130,130,132,132,132,144,144,144,144,144,158,158,158,180,180,180,180,180,180,194,198,198,198,198,198,198,198,198,198,198,198,198,206,206,218,218,226,230,234,234,258,258,258,270,270,270,270,270,276,292,306,306,306,306,306,306,322,324,330,330,356,360,360,376,378,378,378,380,380,400,414,414,414,414,414,414,414,414,414,442,446,486,486,520,522,522,522,522,522,522,522,546,546,546,558,578,594,594,594,594,594,602,602,638,654,654,702,702,702,702,738,738,746,770,790,810,810,810,810,810,810,810,878,916,1040,1040,1050,1050,1086,1086,1098,1134,1134,1210,1300,1314,1410,1430,1430,1430,1430,1458,1626,1626,1674,1826,2094,2094,2142,2142,2414,2574,2574,2600,2646,2814,2862,2862,2990,2990,3246,3246,3294,3294]"));
        }

    }
}