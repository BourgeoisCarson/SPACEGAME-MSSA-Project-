using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceClassLibrary
{
    public class ConsoleArt
    {

        public static void Start()
        {
            string title = @"
          _______  _        _______  _______  _______  _______   _________ _______    _______  _______  _______  _______  _______ 
|\     /|(  ____ \( \      (  ____ \(  ___  )(       )(  ____ \  \__   __/(  ___  )  (  ____ \(  ____ )(  ___  )(  ____ \(  ____ \
| )   ( || (    \/| (      | (    \/| (   ) || () () || (    \/     ) (   | (   ) |  | (    \/| (    )|| (   ) || (    \/| (    \/
| | _ | || (__    | |      | |      | |   | || || || || (__         | |   | |   | |  | (_____ | (____)|| (___) || |      | (__        0   
| |( )| ||  __)   | |      | |      | |   | || |(_)| ||  __)        | |   | |   | |  (_____  )|  _____)|  ___  || |      |  __)       |\>\
|_|___|_||_|______|_|____*_|_|______|_|_*_|_||_|___|_||_|___________|*|___|_|___|_|________|_||_|_____*|_______||_|__    | |     ____/\__||
______*______*__________________*___________________________*________________*_________*_____________________________-- - -   >@__-_-_-_-_/ 
| || || || (      | |      | |      | |   | || |   | || (           | |   | |   | |        ) || (      | (   ) || |      | (      
| () () || (____/\| (____/\| (____/\| (___) || )   ( || (____/\     | |   | (___) |  /\____) || )      | )   ( || (____/\| (____/\
(_______)(_______/(_______/(_______/(_______)|/     \|(_______/     )_(   (_______)  \_______)|/       |/     \|(_______/(_______/
                                                                                                                              ";
            Console.WriteLine(title);
            Console.ReadKey();
        }
        public static void AlbynioVista()
        {
            Console.Clear();
            string vista = @"
                               .``               .o:             ``                                                                                                                                     
                                               -sdho/           :y+/                   --.                                                                                                              
                                             -oNNmy .+.        .hs+`+`               `/sso:`                                                                                                            
                          :y:`            `/ssmNd++   ::       -ho+ `o`            `-+o/./oo-`                .                                 ``                             `/`                      
                        `ssyds       `---+dmmmh+..+    ./.     +dy/  `o         `:////-   ./+o:-`           -yd:                              `+ss.                           /y+y+`                    
                       -h: ssyy. --::-`` .++:.` `o`      ::`   /dh.   -/  `...-:ooohh-      `-/+o++-....` ./.ydm-                            `+os/:-`                      `/hs-.`:y/                   
                      +y.  odyhdy.`    `oyo`    +.        `-:-:/dh:    :/:/:---`./hysho`       `.-:::/so+//` /hmd-                          `+s:``.-::.`                  :dhs:`+  `/y:                 
                    .y+`   .hhdhys`  `+y:`:y+`  ::     `      .dhos     -o.`   `os.yyysh/             -+/`    sydd/`                        :o+`    ./++:-`          :yo+hdy/`  /.   `+y-               
                   /y-      o.ydy+y:/y/` ` `:y/  o   -sso.    /+/`::     `/-` :y: .ymNddms`          +-`      `omdds:`                     :oo.       ./++/+:-.      +hmh+:.    /.     .os.             
                 `so`  ..` ./ .sho+d/`  ::   `/y:s-.oo. -soo+:.    ::`     `+yo`  o/hmhmdyy:       .::          /ddd+:/`        ./oo-   `-+oo-          ``.://+/:..`.sms.       /.       -so`           
                -y:   .+/. +`  `/y+.   +-      `+yso.     :yo`      ./.    /y:   -+ohhydmd+os` `-::.`            +sdmo-/-     :oo/`-syo++/+-`                ``.--/ymdy.       -s          :s+`         
              `+s.   .+o+  :: .so.    `o`        .ss.       :y+`      +. .so`  `:+os+/oodmd/:yo+.                .+shhsooo--+s/. ///+//sy/`                     `:hdyo.      `::::`         `/y/`       
             .y+`   -os/`   /ys-       .:-.        -s+.      `:s/`    `./y-  ./-o:yy+.oosymds.os.                 o-+o++hhho-`   -oo+   ./s+.                 `/hdo:-      .os:  `::`.`       `+s:      
            /y-    :ys:   `+s-           `./-        :s+`      `/y/`  .s+`  -+` `/oyyssddhsymy-:y/                ::/+++y/.     `++s:     `-oo:`            `/hho:`      ./ydy/    `/ooo`       .os-    
          `so`   `:o+-  `/y:` `-::`         /-        `/s/`      `/s:+y-    `//   `.---shys:odh/.+s.               ++yo-  .....././s+        ./s+-         `+s:`      `/oyhhyy/      .ohss-`      .so.  
         -y:     +ys- `:s/`  .:/:.          -:          `+s:       :d/`    `::`         +sys+shho.-y+`           -+s/`    h+//ddo//o+      ``   -+s/`    `+s:       .::hshhyy+.        +hdyoo/-`    -s+`
       `+y.     `:/- -s+`   .::.     ``     `/:``         `+s-   `os.   `` `o`     `     /oossshhh:.+y-       `:oo-       d-.`smdhos+     .+/yoooosmy+-`/s/`      .:-` yshhh/`         `yhysoss+-`    :y
      .y+        ` -so.    .++.     .//-      .o::`         .os.-y/    `::- `o`   `/:.    /:-sssshdy+:y+`  `-os/`    .+/..m:/`omhso/.     -o/N` .` hy:syh-     `-/-    o+hdo.           `:oyysooso+/:.``
     /y-         .os.   ``-/o/`      /o+`        .::.         -sm-    .://`  /-   `o+-     -/:yy::sdh: /y-/s+-    `:+yhysoN- .odho/:::::::+ysN:://.hsso+/oo-` -/.      o/ydo.              ./s++shssoos+
   `so`        `+y-  `.:/o+:.`       `/+/`          -/          :s+`.-++:   +-     /s+.     `/sso+oys:`-yy:`     .oyh/. -yN-`-ohmo-:/--/:-/----/:y+h::syo..+ys/        .+shy.                `-:/+ososdh
  -h:        `/y:  `:+o/-.`           `/+:`          -/           :yo/:`   ``      `/so:      .-..///+s+.     `-+sys.    .m--`odd/ ... .`.-` `-.`s+h: -yyy-`y:oo-`       -/:`                    `-:osyy
`oy.````````:y/     ..`                 ./:-          ::           `/y:`             -oo:        `-oo:      `:syyo-       d-: odm/ . ..` ` -` `  s+h:  o:yo.   .+s+.       ./                        -:-
:y+++++++oyh+`            `-.`           ./o/-        +.             `+y-.............--........+s+`    -///oyy+`         d-  sdm/  . `/`  .+  `:s+h/  o.so:      -os:..................................
        -so`          `.-+os:.            `-:-        +.`              `smo//////////////oyyoyms-     ./+oooo/`           d--yhdN/  .  `.hoooooooysyd`:/shyo++++++++oyhdo///////////////////////////////
      .ss.       `.:-:/++:-`                           .::`              .so.          `/yhhy/`      `s---.               d- N` y/ :. `/.m `:   `:  N.s/M.../-..../.os -os:`                            
    `oy-         -://-```                                `:s`              -yo`     `-yhdds-                              d- N`:y/   /  .m`     ````N+/:M.`````./   +s   `/yo.                          
   .hhooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooohh`     ohmsooooooooooooooooooooooooooooooooom- N--y/ -:   ohh`   -N+++++++++++++yy .s`+dooooooss.                         
                                                                                     smh                           -//////mo/N++dy+++++sy /h   -m+` `- oooooooydoooohhos.                               
                                                                                     /dmo-                         os....../sdho/////--++s:+y  -d      d-              h:                               
                                                                                      ohmho+::.-``                 oo : :++-`             :ods -d      d-`-   :`   ..  h:                               
                                                                                      `/yhhhyyoyss+//::-....`      oo /o-     :yh+          :Ns-d      d-              h:                               
                                                                                        `.-/oyyshyssso++oossooo/.  oho.       mo-N:          +dyd      d-  -   -   ..  h:                               
                                                                                             `.-:/+sosoysyy+::ohs-.+`        `Ndhmhdo` /sy.  `oym      d-  .   .   ``  h:                               
                                                                                                     ``-:odds+.ooos`   `-  `+dy/```.smmh/M/  `y`h/     d-  `  ``    .  h:                               
                                                                                                   ```--:yhyysoyyd.    +N-:ms.      +d:+mm`   o `hdooooN-  -  -.   `:  h:                               
                                           .o`                                               `.-+osossso+o+ohhys+o  .. dmmNo` `hy`  ``.s/N+  .:  `h:   d-              h:                               
                                            /y.                                  ````-.--::/+oys+////:/+yyhds+-`:/  sm/M:-mNo `hy`       /m/ o- o`.d-  d-  .. +    +   h:                               
                                            .sm+.                      ```...::/o++oooo/+ooo+/+++osoyyyhho/-`   +-  smhNydy:              /NodsososhN::d+::::::-.      h:                               
                                           -o-mdms:              `.-:/++o+++oo+/::::://+++oso+ooyyysoo+-`       s.  /Nodm/` .  -s-        .Nd+/////:-...````...-:+/s-  h:                               
                                             `M/-ymy/.        .:++ossoo+/+o/o+++++oo+sshysshdhso//-``           .s  `md:` -o:`odym:   `-+yho.                     `/o..h:                               
                                             +M:  -yhso-   `-ossyssoo+oo/++////::++/oydhhssho/-`                 o:  /m/:o++ods. yh/oyyyo-.                         +h+o.                               
                                            .dN:   `:so+s/:oydddhysyhhhyosos++/::+ooso++oy+-`                     +/.`:yhyyy/-.-/dho:-`                              s.                                 
                                          `/y-d:     `/s/:sddyoshhhhys+////+++++yyhs/:/hs:                         .://://+/+/:-`ho                                -o:s:-`      `                       
                                  ``..-:/oo:` d:       `+s:-ohosyys+/:-/:::/++ssyy+//shdo                              ````     -Md                                //-/sssysssss/`                      
             ......----:::///+++ooo++/:-.`    d/`````````.os-./ydyssooosss+sysysssssysos+                                       :MN          `          `-         /:   `..--:-`                        
      .`    oddhyhdddddhhhyyysssoooooooooooooomhoooooooooooyhosyNNy+///::::://+osshshhyso-                                      .MM        `/d`         .M+        /:                                   
     -doo+/-.:os:                             s+           `-+yhhyososooossysyysyoyoyysss/                                      `MM:       oNM-         -MN`       /:                                   
     :h  .-:/+syNo                            s+       `./so++++ososs++osos+///://++ydsoo+.                                     .NMd      +/:sy-`.....:sNMMo       +-                                   
     :h``.-/+ooym/                            s+   `.:ohdd+:/+++++oo+yhhssyysssosyysyso:oo/                                     :NMM.     y   `--:::::NMNMdd:      -o                                   
     -do++:-`.ss.                             s+`-+o+:+ddhssoo/++/++osyysoososo/++++ohmhyoo.                                    sMNm+     y          :dMMMNhs      +:                                   
            odhooooooooooooooooooooooooooooooohho/.  `shy/-/+o+++/:::++////sshyyhdmdddh+.:ss.                                  -NMNNo     y          oMMNMmyy      o.                                   
                                                     `ohssyyyo+s++ssyys+yhhsss++//ydmhyoo/oso:                                 -//:-y     y          yhhhdh:s.     /:                                   
                                                     :odysyyyysso+oooyhddhyy+++o/+oysssshdmmdyo`                                    h/ooo/y/`              `ys`-:::+y/`                                 
                                                     +yyy/oyh++++/+//yhdmdmhyosossso+///+shmdsss/`                                 `+-` `-:-`               :+o/--::-.                                  
                                                    -smmdo+ohhhyyyyhdhydhhsssso+oo/o+ooosssdd/.+so:`                                                                                                    
                                                   `+dmdhosoosooo+syss+++oosos+ossoosssssoshds/+oyho:/:.                                                                                                
                                                `` .oyhy++sssoo+o/oo++ooyyos+oo+//+++oos+sssssyyhhh+oyy/                                                                                                
";
            Console.WriteLine(vista);
        }
        public static void CarsonopolisVista()
        {
            Console.Clear();
            string vista = @"


                                                                                                                                +y ::-                           .:/++/:-.``                      so` so
                                                                                                                                m..oo-                      :::::/++oo/:+ooo++::.`                    `N
                                                                                                                                m-`+oo-```                .+`        `-`  ``--+/++/-                   N
                                                                                                                                :h` -//o+++oo/-.         .+       .`          .+`-::`  -oo:           .m
     :--`                                                                                                                        -y+-` ```.-:--`.+               :/            o         `/y/         h/
     -` `..```                                                                                                                    `yyso+`        `/-           -/.             o     ..    `os      `y+ 
      --     ./   `..---:/:.                                                                                                      /y  ``           .::-------:/.              /-     /o:     y/   .+s-  
       -:`    `/:+o-.```.-:/oo/`                                                                                                  d-          :       ```````                /:     `+s:     :m++o+-    
        ``.  .oo-`           `:so`                                                                                                h:          +`               `:-.     `.-::`     ./o+`     :d.`       
          `.:+-                 -y:                                                                                               -h.         `/-`        .-     `.-::::-.```...-/+oo/`      y/         
           /+.`                  `s.                                                                                               -s+.         .::-----::-`                .:::o/:.`      `os          
          `m` `-.                 .+                                                                                                `-+o+s++o`  .--````            `//-        `m        `/s/           
          .s    -:`                m`                                                                                                   `oy-    .oo:      --``..```-so:        /do/::::/oo:`            
          ./     `..`              N`                                                                                                     -oo:.  -+-`   `.od/-+++oooo:`       :h.`.----.`               
           o.       -.`           /y                                                                                                       .+hys++o///+oo+:.so-``...`       .os.                        
           -h-       `..         .o`                                                                                                      /y:.```.od-..`     -oo/-``   `.-/oo-                          
            .y/`       `..     `-:.`                                                                                                 /+:  h:       d:          `-/++o+o++/-`                            
              :o:.`      ./-`.-/. `-`                                                                                                dod`:yh:.```.+y`  :///+////////+///+.                              
                .-::///////o/:`     :.                                                                                               `-.d/..+m+++/-    h+..y-..++...y-..d:                              
                     ....`   `..`    -`                                                                                         `..` /oodo--+y    `    h/``s.``//```y```h:                              
                               `....`:`                                                                                        -h/oh h+-:dhdy.   oos/  ho::y:::oo:::h:::d:                              
                                    `                                                                                          .sooo  -:-`h+y+  .m-+h  h:  s`  /:   s`  h:                              
                                                                                                                             .---` ----` `-/:`   -++.  h/``y.``//...y-..d:                              
                                                                                                                             ys:d/ N/:d/ sy/h+   m++m  h+--y:--o+...y-..d:                              
                                                                                                                             y/ y/ N` y/ s+ s+   N``N  ho::h:::oo---y---d+                              
                                                                                                                             y/ y/ N` y/ s+ s+   N``N  h/``s```//```y.``h/                              
                                                                                                                             y/ y/ N` y/ s+ s+   N``N  ho::h:::oo:::h:::d:                              
                                                                                                                             y/ y/ N` y/ s+ s+   N``N  h/``s```//```s```h:     :::`                     
                              `-:::++/.                                                          `::::::::               /oooddhNyoNysmyoddsdhoooNyyMoom/  s`  //   s`  h:`-:+osoo+/::`                 
                        `-/ooyso+sshho+/:::---.       `/:----::             `://+///////++/:/+ooys+soooso//:/.           d: :/ y s.   `s -o y   -+ `s  do::h/::oo:::h:::d:++osydo+++:/ys/`              
               `::/` :+o+/yys++///::shhsysyysyss+///:/-`      .+-:---:////o+ohdhyhyysssyyhsysso+o+//+oohmd+/syy---  -::-:d- :s/h:y`   `h:+y:h   -y:/h::m:  s`  /:   s`  hoshs+syosoooshddy+:-.  `-::.   
...........-//+-..-/ossooosooooo++ooooo+ydmdmmmhyo:```  ``    ```-///syhysssydhhdys+++oo++/+++//+//+yhhhddho+-`  `+o`    d/-+o:h-y:---:y-/s-h---/s-:y--mo::h/::so:::h/::d/oyyssosoossossyoo/:+s/:`  //` 
 `````````````      ````````...-..``````.:::::...`     ``  `         `````````.-:/-```.``.`.```````.---.--.````  ````` ``d:``.`.`.`````.``.`.````.``.``m:  s`  /:   s`  +.`-::////++ooossso+//:---.-...-
                                                                        .       `:/:+-                                   d-                            do::h/::oo:::h:::d:                              
                   ..               `    `                              `/-   `/:`  :h`                                  d-                            d/  s`  //   s`  h:                              
                  +yy+===============     `                                ./.-/`    +:/                                  d-                            do--y:--o+---y:--d:                              
       `--------:hy//dd//......`                                           .yo.    .+./                                  d-                            d/``s.``//```y.``h:                              
       -d//+++++ooooo++/N                                                 .+``:`  -/`+`                                  d-                            d:  s`  /:   s`  h:                              
     :+oyo++//////////----++.                                `           -/      :/-/.            ```                    so++++++++++++++++++++++++++++hs++yo++ss+++yo++y-                              
     ys+/:---........---:/oy/                                            o    `-//y/           ...-.                     ````````````````````````````````````````````````                               
      `.--:://///////:::-..`        ``                                  `o..-++//+yo/`                                                                                                                  
                                                                         .--:-.``o o`/-                                                                                                                 
                                    `:.`                                        o` o  /:                                                                                                    ``..        
                                    .ods-                                      .+  ::  /.                                   `.                                                             .``          
                                   `-/+-y/-`        ```.```                .:` ``   +                                       `.                   `````````                                              
                                 `./:.  +.-/:`           ``                .        `                        ``                                 `......```            `....```                          
                    ```....---://:-``````o. .//.                                                             ``                                                        ``...`.                          
                  `/-oy+/::/+++:::::::::::+::/oh-                                                                                                                                                       
                  /h:+ss                  `-/:-`                          .---.`                                                                                                                        
                  `:-s/o................:/:.                                    ``````.``````                                                             ```                                           
           ...``.``  -------------------`                                                                                       ```````.-                 ..-..---------.--....                         
                  `                                                                                        `..-..``            `.....````                                                               
                                                                                                                ```.``.````                                                                             
                                                             `..-..                                                                                                                                     
                                                                                                                                                                                                        
                                                                                                                                                                                                        
                                                                                                                                                                                                        
";
            Console.WriteLine(vista);
        }
        public static void DavesanityVista()
        {
            Console.Clear();
            string vista = @"
 
                                                                                                                                                                                         .:oho+:`       
                                                                                                                                                                  `                   -:::+yo:  -/-     
          `:+oooooooo/.                                                                         `                     `                                                            -:+:-/os+`     .:---:
        -ss:`       `.+s+`                                                                                                              `                                `:-:-://+so+s+o+:`            .
      `so`              :h-                     `                           `                                                                                         :+shyyyhhss+++/..`                
      h/                 `h:                   +`                                                           `                                                      `:ymhyyyyss+:.`                :     
     /y                   -d                                     `                                                                        `                      -/+hhd-` ````                   `o     
     oo         -/`        N                                                                                                                               `    .hohdy-                -:.       +`     
     :h         +shh.     -d                                                                                                                                   -dmdy+.               .+hy/      +.      
      y+        +sd+y/   .h-                                                                                   .+:         `              .-:--.              -yNy/`                `+hy+`    `+.       
      `os.      +sd-`os./y-                  `                                        `                      `/yoo+-                    :yyyo++:+:`      `.--+ydy-              ``.:shmy-    -/`        
        -oo/.`  +sd-  :hy`                                                                                 `:/syd+--/`              `.-oyhdyoyhosossooosysosyyo:`           .:/o+oydmdy:    :/          
          `-/oooydm-   `so`                                                                               -/-+yhs/  `//.         `-//+ohdy/.``-:/:++////:--...`   .-      `:+s++ohdhs/.    ::           
            `  `+yd-     /y-                                                                            -/::ohys+`    .:/:-:/+.-/++oshdy/`        `              `o      `/shhyoyy+-`     -/            
            s:oyosd-      .s+`                                                                        -+++oyooso-         `  .hyyoyddo-`                     `.-:-`     `:shdmdyho`      -/       /     
            y/yymsd-        +y.                                                                     -/+oyhy/`+s+`             /hyymds`                    `.:-.`        -oyhhs:shy.     -+        o     
            y/y/-hN-         -y/                   `                `                             -+:/shddds+ys.    ..         -oyhhso/..``            `.:-.           .sdh+-  .++-    ::         /.    
            y/y/ `ho          `os`                 `                                            .+::+yhyssyyys.    -/`           `-:/syhhyo:`         -:.             `sdh/`         ./.          `+    
          ` /-+-  `os`          :y:                                                           .//.+syys: `.-.`   `/-                  `./yos/`                     `-+shy:         `::             o`   
 `.`      ` s:s:    /y.          `so`                                                       `//./sosyo/        `::`                      -sso/                    `+hyo:`         `-.     -//`     .+   
 .+oo:.`    y/y/     -h:           /y-                                              `      .+:-+yosys:`       -/`                         -yys/`                   `.`                   .ydh-`     /   
    `-+oo/-`y/y/      .y/           .y+`                                                  .o:oys:+ss.     `-::-   `::.                     /o+yo:`                          `.          `+yhs/-         
         ./odyd+`      `ss`           +y.                                                .s+ssdss/sy.    :/`     `odms.       `-            -++ys+`        `-++/`          `+.          -ymyos+.        
            y+hyoo+:.`   /y.           .h/                                              -ysyydmmdhds-    o       :dmdso:       o              -/hy+        `ohhy:         `o`        `./shddhss+.       
            y/y/  `:+oo+-`-h-            os`                                           :dsyssyysyyo/     o      .ymmhhso/      `+               -ys`       .yhy+-         :-      `:/oyhyoosysso+`      
            y/y/       ./+ .h/            -h:                                        `oyyhy+` .--.`      .     .sdhohhyso-      .+                -      `:smms++         .+     /ydho++--o/-:+yh+`     
            y/y/             so            `so`          `                         `+yss:so-                   /hds+syyso+       `+`                    `+yddy++/          .+    .--  `/oys/  .:oo.     
            y/y/              +h`            /h.                                  :osso`+ys`                   :oo+/oysso/         +-                  .sdds+syoo.          ./        -sds:`            
            y/y/               -d.            `y+                               :o-+ydy/.yo-                        .oyyy:          /`                 /yy- `+sdys/.         +.       .hy+              
            y/y/                .h/             +h.                           -+.`+hmms-+oo`          `             :oyhs/                              `.`   `:+hy+`        `o        .:.              
            y/y/                 `so             .h/                        ./--osymNhoo+:`         .yho             `..`                            `:ohhy:`    `.`         `+                         
            y/y/                   +y`             oy`                    `+/-ooyoyhy/-`           .omds`                   `                  ``..:+yyhsyys+.               `-         `          o    
            y/y/                    :h.             -h:                  `s:/sysyso:`            `:syydy.                   +`          ```-:++ooysyhyo. -oyhy+--.`                   `:/          o    
oooooooooooodyd/                     .h/             `shooooooooooooooooo+.shy./ys.             -sso-+md.                `::`         `/osyyyss+++/+/:`   `-+ssyso+/:::-`           `::`           o    
            y/y/                      `so              /h-                `//. .+/.            /syyy+ody-              -:-`            .:+/:``      /::-:     .:///ooyhy+         `::`             /-   
            y/y/                        +y`             .y+                 ``````````````     +ssosyys/.           `::.                            o   .+.       `.---.`       -::`                o   
    ``      y/y/                         :h.              +y.   `````````                 .`   .-:..```           `::`                         `.-::.    `./--`                `.`                  /-  
     ```````y/y/                          -h:              -y+.`                           `````                   `                  .:----:::-.`          ``                                       +  
    ``      y/y/                           `y+              `os`                                `````````````                                                                                        `  
      ````  y/y/                            `os`              :y:``````````          `````                   ````                             ````````````                                              
            y+y/                              /y-..............-ys`        ```      `     `````                  ```` `      `````````````````            ````                      ````````````        
            yyd/                               -hh+++++++++++++++o-          `                ``                       ``````                                 ```````        ````````          ``````   
          ``yoh/                                .y+` `.`                                        .`                                                   `````                                              
        `.``y/y/                                 `os`  ````````             ``````               ``                      `           `````````````````                                                  
      ``    y/ss/////////////////+//+////////////++hy      `````         ```       ``.`             ``````            ````                                   `````                                      
       `````y+.-----------------::--::::-------..----``````   ```````````             `                   `         `                                   ````      ` `````                               
+oooooo+++++dy++++++++++++++++++++++++++++++++++++ooooooo++++////:::---....````                                                                     ````                 ``````            `````        
`           y/                                           ````....--::://///+++ooo++/::-..`                                              ````````````                           `````````````            
            y/                                                                   ``.-://++oo/-                                                          ```                                             
            y/                                                                             `:ho`````````````````              ````                ``````   ``````````````````                           
            -.                                                                     ````.:/syyo.                `````             `````````````````                                                      
                                                              `````````..--://+ooooo+++shh+-                        ```                                                                                 
oooooo+++++/////::::::::::::.::::::::-::://////++++oooooooooooo++++++++//::---.`````:oo/.               ```            ``        `                        ```````````````````                           
       ````.....------------`.-------`---......````                              `:::.``            ````   ``````        ````````                                            ````                `      
                                                                             .//-`      ````````````                                                                             ````````````````       
                                                                          -oso-                                                                                                                         
                                                                       :ss+.                                                                                                                             ";
            Console.WriteLine(vista);
        }
        public static void JamestownVista()
        {
            Console.Clear();
            string vista = @"


     oMMMMMMM/             oMMMMMMN          `MMMMMh                                                       oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo                 
     oMMMMMMMo:.           oMMMMMMN          `MMMMMh                                                       oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo                 
     oMMMMMMMddo           oMMMMMMN          `MMMMMh                                                       oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo                 
     oMMMMMMMdh+           oMMMMMMN          `MMMMMh                                                       oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo                 
     sMMMMMMMdh+           oMMMMMMM`         `MMMMMh                                                       oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMN                 
     yMMMMMMMhdo`          oMMMMMMM`   ```   `MMMMMh                                                       oMMMMMm                      +MMMMs  ```      +MMMMMMMy      `        mMMMMM.                
     yMMMMMMMhmh- ./:.     oMMMMMMM`  .os+/. `MMMMMh                                                       oMMMMMm                      +MMMMs `oyo.     +MMMMMMMy    /sh`       mMMMMM/                
     yMMMMMMMydms/shm/     oMMMMMMM`  /ymsso-`MMMMMh                                                       oMMMMMm                      +MMMMs :hNh/`    +MMMMMMMy   :hmh`       mMMMMNy.               
     yMMMMMMMdmmmmNmNs`    oMMMMMMM`  /dNyo+.`MMMMMh                                                       oMMMMMm                      +MMMMs-hddy+-    +MMMMMMMy ./ydhh`       mMMMMmh+`              
     yMMMMMMMds/dNNNMmssso.oMMMMMMM`  -sNh:` `MMMMMh                                                       oMMMMMm                  `--`+MMMMhodmmdo/    +MMMMMMMh:+soooh.       mMMMMhhs:              
    `hMMMMMMM+:+mNMNMmhdhy-oMMMMMMM`  -sNhso/`MMMMMh                                                       oMMMMMm                 .omh-+MMMMmmhyddho.   +MMMMMMMdosso:od:       mMMMMshso.             
     yMMMMMMMyhhNNMNN+..`  oMMMMMMM` /dNNdmms`MMMMMh                                                       oMMMMMm                 :hNd.+MMMMmo-+yhyho.  +MMMMMMMNyo+syhm+.      mMMMMohsy/             
     yMMMMMMMhyhNNMNNs:    oMMMMMMM.-yNMMmNh+.MMMMMh                                                       oMMMMMm                -ydNm/+MMMMs  /ys/hhy: +MMMMMMMm:-`/dhms+`     mMMMMhdoso/.           
     yMMMMMMMhsydNMdN+:  ``sMMMMMMM/odNMMNNdy-MMMMMh                                                       oMMMMMm                /ysmmysMMMMs `+s+ -ohs.+MMMMMMMh   .oodyyo`  `/NMMMMmm:`/so:          
   `:dMMMMMMMy/hmNNyh:++oy+hMMMMMMMyhhmNMmNms/MMMMMh                                                       oMMMMMm                 `/NNdyMMMMs :yds.  .` +MMMMMMMy   .++h/shs/-oyNMMMMmNo--sss`         
   -ymMMMMMMMssmmdNhNdhdds:sMMMMMMMsoyddNmmdyoMMMMMh                                                       oMMMMMm                 `+mNddMMMMs`oyNd+`    +MMMMMMMy   `+yd..+so/+sNMMMMdm/+/++:          
    `yMMMMMMMdmNNmNmNdhmNd-oMMMMMMM..smNNyyoyhMMMMMh                                                       oMMMMMm                 -sNNyyMMMMs.sydd+-    +MMMMMMMy    smN+   `  `mMMMMhd: ``            
     yMMMMMMMNmhhmNmmhhmNm+sMMMMMMM-:hmmNsyyosMMMMMh                                                       oMMMMMm                .sdMNdhMMMMs+dNmhoo-   +MMMMMMMy    sdN+-      mMMMMddo`              
     yMMMMMMMdo./mNyh:/ydhhmMMMMMMMoyyddNmNNd/MMMMMh                                                       oMMMMMm               -yhdNdsyMMMMdydhdy+so-  +MMMMMMMy   `dNNs+`     mMMMMyys:              
   -/dMMMMMMM/`-sdmsh.oyhosdMMMMMMMhhyydMNNmy/MMMMMh                                                       oMMMMMm             .ohhsoNdsyMMMMy::/yhoooo: +MMMMMMMy   :mNNys/     mMMMMo/yo-             
  .symMMMMMMMo/+yyNmNsy+yyhdMMMMMMMdhdmmMddmy:MMMMMh                                                       oMMMMMm            `oyo-:oMmhdMMMMs  /sy+o+ss:oMMMMMMMy  -dNmNsyy-    mMMMMysdso:`           
   ``yMMMMMMMy/+shmhmys:hsyhMMMMMMMsdNNmNdddh:MMMMMh                                 ````                  oMMMMMm             ```-odMNysMMMMs  /dmy+/osyhMMMMMMMy `ymmhmoshy.   mMMMMhymso++-`         
     yMMMMMMMs.shsmyNso+ho/hMMMMMMM+yhdyNhddo-MMMMMh                            ``-+ydNNdy+-``             oMMMMMm               :osdMNdmMMMMy  /dms:`/ohmMMMMMMMy `+hsodo-shy. `mMMMMhsmo+oss+.        
     yMMMMMMM//yh/dsmy+ody-yMMMMMMM.sys:h-+yhyMMMMMh                        `-/sdNMMMMMMMMMMNds+-`         oMMMMMm             ./oydmMdhmMMMMm/`/hds:  .-sMMMMMMMy.+soood+-.shh/oNMMMMhsh./ohyso:       
     yMMMMMMMsoys:myds//dy:sMMMMMMM/sdyomsoymmMMMMMh                      oyNMMMMMMMMMMMMMMMMMMMMNho       oMMMMMm           `+ssshhdMdooMMMMd:.+hdy-    +MMMMMMMhoyosddmo/ `+yh+mMMMMdsh  ./osyy:      
    -dMMMMMMMyssysmym/:smh:sMMMMMMMysyhymhyhhyMMMMMh                        MMMMMMMMMMMMMMMMMMMMMMy        oMMMMMm         .+yhydhs/hMdosMMMMy-:odds`    +MMMMMMMdysosdhmo/   -+:mMMMMdod     `..       
  .oodMMMMMMMh+ssymyh/+hNd+yMMMMMMMh+/+odoshyyMMMMMh                        MM+///oMMMMMMMMMMMMMMMy        oMMMMMm       -ohhsyyhs/+yNhydMMMMh+hddd+`    +MMMMMMMmhs/-sdms/      mMMMMy+m/`             
-oss/hMMMMMMMyoooymymoyhmssdMMMMMMM/-::/y-///oMMMMMm/.                      MM.   -MMMMMMMMMMMMMMMy        oMMMMMm       -/++ooo+so++moyhMMMMhydddy/     +MMMMMMMms:  oymyo:`    mMMMMo.ho-             
yys+odMMMMMMMhs/+sNhmyyym.smMMMMMMMyo//+dooooyMMMMMMdhh/`                   MM-```:MMMMMy-----oMMMy        oMMMMMm      `:++++//s+- :h.+dMMMMNdhsdmy/`   +MMMMMMMh`  .+/yhyys-   mMMMMo yso.            
..`.-hMMMMMMMs.:+odsdosoh``yMMMMMMMyooosmosssyMMMMMmo+yhs.                  MMMMMMMMMMMMo     /MMMy        oMMMMMm    `/hhhyo+/+-   :h  oMMMMd+``ohdys+. +MMMMMMMy  `+/:hs:/yy+. mMMMMy:yyos+-.         
 `-+smMMMMMMM/`+s/mymyysdoomMMMMMMMooo/+hos+:.MMMMMh   .-                   MMMMMMMMMMMMo     /MMMy        oMMMMMm    `/s/:-..      /y  +MMMMNy:.:/-/oyy+sMMMMMMMy`:sso.yy: `+hs:mMMMMo.oyyoo///-`      
 oyhodMMMMMMM/:osodsm::-h.`sMMMMMMM.-..`y.`  `MMMMMh                        MMMMMMMMMMMMo     /MMMy        oMMMMMm                  +s  +MMMMdhhs+:  `-syhMMMMMMMh+ydo::s+`   .-`mMMMMo :+/+o/:+ss/.    
 `.` yMMMMMMM/`..`s y   y  oMMMMMMM`    y    `MMMMMh                        MMMMMMMMMMMMo     /MMMy        oMMMMMm                  +s  +MMMMs```::    `.oMMMMMMMh:+/`` /:       mMMMMo -+ `-:/+oys-    
     yMMMMMMM/    s y   y  oMMMMMMM`    y    `MMMMMh                  `     MMMMMMMMMMMMo     /MMMy        oMMMMMm                  oo  +MMMMs   ::      +MMMMMMMy      /:       mMMMMo `o      ```     
:::::hMMMMMMMs::::h:h:::h::yMMMMMMM/::::h:::::MMMMMd:::::::::::::///+yhs::::dddddddddddd+`````/ddds::::::::yMMMMMN:::::::::::-------ys--sMMMMy---oo------sMMMMMMMd------oo-------mMMMMy-:h--------------
     yMMMMMMM/    ` y   y``sMMMMMMM.````:`````MMMMMh````````````:+oydNms`````````````````     `````````````sMMMMMm``````````````````so``+MMMMs```--``````oMMMMMMMh``````:+```````mMMMMs``y``````````````
     yMMMMMMM/      y   y  oMMMMMMM`         `MMMMMh          `:+ymNmds-                                   oMMMMMm                  .`  +MMMMs           +MMMMMMMy      ./       mMMMMo  y              
     yMMMMMMM/      o   .  oMMMMMMM`         `MMMMMh         .+shmNNdys-                                   oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo  s              
     yMMMMMMM/      `      oMMMMMMM`         `MMMMMh         -ohdmNmdhdyo-```                              oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo  `              
     yMMMMMMM/             oMMMMMMM`         `MMMMMh          ommhmNmssyhyo/.`.``                          oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo                 
     yMMMMMMM/             oMMMMMMM`         `hhhhho         .yNmhmNmyo/oyyysso/-                          oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo                 
     yMMMMMMM/             oMMMMMMM`                        .`:ohyydsoyyy+/ososo/                          oMMMMMm                      +MMMMs           +MMMMMMMy               mMMMMo                 
     yMMMMMMM/             oMMMMMMM`                          `.+sdmo.+dNd::+syys-``                       oMMMMMm                      +NNNNs           +MMMMMMMy               mMMMMo                 
     ommmmmmm:             oMMMMMMM`                            -yhmho:ymds:/ymmdy+:--.`                   oMMMMMm                      `----.           +MMMMMMMy               /++++-                 
     ````````              oMMMMMMM`                             -+hddhyhsoosyhs+hhsss/`                   oMMMMMm                                       +MMMMMMMy                                      
                           oMMMMMMM`                              .-ymmyo/+shmdy+sysos+                    :ssssso                                       +MMMMMMMy                                      
                           oMMMMMMM`                              ..smdo..:sdmmmmdhs+ss.                                                                 +MMMMMMMy                                      
                           oMMMMMMM`                              -+hmdo/oshhhssmmdh+so:                                                                 +MMMMMMMy                                      
                           oMMMMMMM`                              :shmms-:-oys+sdNmhsys+`                                                                +MMMMMMMy                                      
                           .:::::::                               -oydmmmsyhdhhsoyyooyhss+::-`                                                           +MMMMMMMy                                      
                                                                  -oyhysyyys+:://ohhyhysyyhhy+-`                                                         +MMMMMMMy                                      
                                                                  /ydmyydddssyyyhyhhdho-.oys++s/.-                                                       +MMMMMMMy                                      
                                                            ````-+shdh+:+hmdhhosso+oso+o//sysoooo.                                                       +MMMMMMMy                                      
                                                    `.`..-.-.-:ohdhdds++smdyo++/+++hhhoossyyyoyhs`                                                       +MMMMMMMy                                      
                                         ` ```..-/+oosoooosyyyhhy+ohhs//hdy/-///oydmhs++++ssoshho.                                                       :sssssss+                                      
                                     ``.:/+ooyhdhdyyyosyssyyyyo+++os+++/ymmdsosyddh/--//:/osyyhy/.                                                                                                      
                                   ..`-sdhysydhyys+ssssoo+oso++o//+/+o+ohhyddmdhysyoo+++/+++/smd/.                                                                                                      
";
            Console.WriteLine(vista);
        }
        public static void LenoritariumVista()
        {
            Console.Clear();
            string vista = @"

  `oy:         +s                    `-+ooo:.                                                                                                                                                           
     +y/     `./o.`             `:+ooo:.                                                                                                                                                                
       :s:+oo+/::/+oo+.    `:+oo+:`                                                                                                     `--------`                                                      
       `ss.          -ss``o+:`                                                                                                          +y::::::m-                                                      
      .d-              -h.                                                                                                              +s      d-                                                      
::::: h/                /y.//////////////////////:::::::::::---------------------...........`````````````````````                       +s      d-                                                      
----- m.                .m .....................------------:::::::::::::::::::::///////////+++++++++++oooooooooo+`                     +s      d-                                                      
      y+                +s                                                                                                              +s      d-                                                      
      `y+              +y`                          -///////                                                                            +s      d-                                                      
      .-+s/.        ./s/`                           so.....N`                              /s+++++++++++++++y                           +s      d-                                                      
     /y. `-+o++//++o+-//                            s+     N`                              os```````````````M                           +s      d-                                                      
   `so`      ``/.``   `+s-                          s+     N`                              oo               M                           +s      d-                                                      
  .y/          d-       .oo.                        s+     N`             `:::::::::::::`  oo               M                           +s      d-                                                      
 :y-           d-         -s+`                      s+     N`             -m-----------d:  oo               M                           +s      d-                                                      
os`            d-           /y:                     s+     N`             -d           h:  oo               M                           +s      d-                                                      
+              d-            `+s-                   s+     N`             -d           h:  oo               M                           +s      d-                                                      
               d-              .so.                 s+     N`             -d           h:  oo               M                           +s      d-                                                      
               h:                :y/`               s+     N`             -d           h:  oo               M   -yoooooy-               +s      d-                                                      
               y/                  /y:              s+     N`   ........../d...`       h:  oo               M   :h     y/               +s      d-                                                      
               y/                   `os.            s+   ``N````hs+++++++/////sy       h:  oo               M   :h     y/               +s      d-                                                      
               y/                     -so`          s+  os+ho+++yo++++++h.    /y   .+//do//yhssssyoooyoooooomoooshooh  y/               +s      d-                                                      
               y/                       :y/`        s+  h:              m.    /y   /h.........../d  .m              M  y/               +s      d-                        ``                            
               y/                 `.:::-.`+y-       s+  h:           ```m-````/y```/y```````    -d  .m              M  y/    sooooooooooyhooos- d-           -ssso+:.`.+sssyhs                          
               s+          `./osoydddhhys` `ss.     s+  h:         :ydyhmo++++os+++os++++++y:   -d  .m          ````M``y/````N.````          y/ d-           +s+ooyhmmMmso++:`                          
               oo        `odmho+oMNds:`      -y+`   s+  h:          :Ny-ho                -dy+++od++om+++++/   ssoooddddhhdhyMddhysyy`       y/ d-               -smNhdyyo`                             
               oo        .:`    .Md`yMmo.      :y-  s+  h:         `.m+doN:/+soso:.       os``````````````-m   d-  `ysoooohNMNmodho/-        y/ d-             :dMh/` .oydm`                            
               oo               +dm  /NMN/          s+  h:       /yo+NsyMMyysooosso`      oo              .m   d-        /dd:mdys+           y/ d-           -dMN:       -+`                            
               oo               +h:   .mMM+         s+  h:     -dmoooNy+-od.              oo              .m   d-      `hMy` :doM+           y/ d-          +MMm.                                       
               oo                      .NMMo-:::::::hs::d:           m.   +m.             oo              .m   d-     .dms    :dm+           y/ d/-.       +MMN-                                        
                `                    `-:+MNM:       .---ssoooooooooooN.    hm`            oo              .m```d-    .mhy      `h+           yyoo.``::::::/MMMs                                         
                                -:::::`  smMs                        m.    `Nd`           oo              .N+++m-    hoN`       ss...........h/           hMMM/:::.                                     
                            `+::`        /mMs                        do+++++yMd+++++++++++ho              .m   d-   -m+y        sy////////////.           dMMM.   .:/.                                  
oooooooooooooooooooooooooooyd:           .yy:                        ````````hM/``````````oo              .m   ssooodhmyooooooooy/                        /sss.     `+Nooooooooooooooooooooooooooooooooo
                           .yo-`                                             +Md`         +y++++++++++++++oh    ````m/m``````````                                  ./s+                                 
                             .:ooo+/:.`                                      /MM:          `````````````````       `mos                                     .-:/+oo+-`                                  
                                 ``.:/+oo++++//:-..``                         ..`                                   .``                       ``.--://+++ooo+:-.``         `/:`               /:-       
               `:/                       ```..--://++ooo++++++/////:::----.......`````                       `````......-----:://////+++++oooo++/::-..````              `-::``/:.`          .+. -:`     
             .::`::-`              ---                  ``````.....---::::///////+++++ooooooooooooooooooooooo+++++//////:::::---.....`````                         `..-:-``    `.--::------::`   `-:-.` 
          `.:-`   ``-::-.......--::.`::`                                                                                                                      .:::--.``                ````        ```  
   ....-::-.`          ````````.`     .:--.`                        `-:-                                                                                                                                
   `````                                 `.--:`                   `::.`.:-.               `-:-`                                                                                                         
                    ..--.           ...`                         -/`     `-:-....`````..-::. .-:-...```.`            `.-/-`                                                                             
      `....```...-::..``.::.......-:-..-:-.........-/::::::::::--:           `....----..`       `.......`        `.-:-.` .:-.        ..::/`                                                             
      `..........`         `......`      `...........                                   .-:-        -.........-::..`       `.::::::::-.` `/.                                         `.                 
                                       .-`                                  `..`````..-/-. -:.`      `..........`                          -:-..`.``````                            -/-/.        `.`    
                 `                 `.-:-./.           `````.-.               `........`      .---:::---------:--/.                           `....-----.                          ./.   -:.`  `.::-/.   
                 .-:-.```    ``.-::-.`    -:::----::::--...../.                                       ```````    -:-``    `..`                                                 `-/-       .-----    -:.`
                     `..---::--.                              -:-.`                                `.`             `-.-:::--`                                         `::::::--:.                     ..
                                                                `.--::-.::                      `.:--::.`           ``-`                         `                                                      
                                      ``-.`                           ``             ``     `.::-.     .--::::::::::--`-::.````      ```-     `.::-                                                     
                                 ``-::-- .-:-.```             ``-:/.                 ---:::::-                            .-------------. ``-::-  .:-`                --                                
                            ``::---`         .------::::::::::--`  -::``                                                              `.::--`       .::.````````````-::-/`                              
               `----:::::::::-                                        ---:-.`                                                     ``-::-               `------------`   `::.`                           
                                                                           .----------                            .-----------------`                                      .--::-.``     -::`           
                                                                                                                                                                                 `.-----:.              
                                                                                                                                                                                                        
                                                                                                                                                                                                         
";
            Console.WriteLine(vista);
        }
        public static void SpaceVista()
        {
            string vista = @"

                                                                                                                                            `                                                           
 `                `         `                `   `                                                                                          `                                                           
                                                                  `                                                                                          `                                `         
                            `ss`                                                                      `                               `                                                                 
      `                      ::                       `           `                     ``     :                                                                      `        `                        
              `                `              `                                               :d-   `                   `           ``                                        `hh`     ``               
                                                                    `                          .                                   `hh`       `      `                        `o/                       
                                                                    -:            `                               `                 ::                                                                  
                 .y/                          `           `         `-                                  `                                  `                  `                                 `       
       `         .s:                                                          `                                                                                          `                              
               `          ``                                                                                              `                                                                             
  `                                                          `                                        `            `  `.            `                 `                           ``                    
                             `             ---                                          `                              ``                                                                               
             `                            `yoy                                          `                    `                                                    :oo:             `                    
                             ``````         `                `        `    `                                                                 `                    -//.                                  
                      `.-://::----::/:-..                            :h.   `      `                `    `       `                                                       `                               
                   .:/:-.             `--/:.`              `         `:`                           .`                                                                                                   
                `:/-`                     `-/:.                                                    o:                            ``.....``                                          `          `        
              `//.                           `:/`                                                ` `                         .:++/:::::::++/-`                   `                                      
             -+.                               `/:            `                    `       `                              `:o/-`           .:++-                                       ` `              
            //                                   :+`                                               ``                   `/s-      -/:```      .+o-                             `                        
           +:                                     .o                                                                   `yyo-`     `:oo+++//+++o:-s/                       `                             
          //                                       -+                                                                 `y--oso+-.`````.-::::-:::.` o/              `                                     
         `s                                         o.             `./+//:.`                   `-////::::.`           o/  `.:++///+oo/+oo+`        h.                                                   
         /:                                         .o     ````` `+hhmmysyyy/               `:+o./smmo+/:::/-         m         `.oyyssyy/`        +o                                                   
         s`                                          y  -.-....:+yNMMNMMNNMNdy+-.-.`       :+/hM/-+sdddNmo  -+.       m  `-:::.`   `.`.`           :s                       .+o+/`                      
         y                                           y  -.-...:s+dyhddmmmNNmsd+o`.-:.     /: ydMdyo-   .-     o.      d`  .::/oo//-.````   ````.-::s/            `         +NMMMMm.                     
         o.                                          s     ``````:mmmmmmNmdhh/``.`       -o`hNo:hNmNy/:/:/ss:  s      :s      `.:/+o++oo+ooosssyys+d`                      dMMMNMM+                     
         .o                                         :/            `odNNNNNmy-            s`-N+   sMMMNMNNNNNN  +-      os-.`         ``......````.h.                       -dMMMMy`                     
          s`                                        y                 .--`               s`./  `yNNymdMdmNMNMo:s-      `+dsoo+++/:::.           /y.                          .--.             .:        
          `s                                       o.                                    -+  `:.mNm-/ymMN:.hMmdd         `os/://+++s+-       `/s:                           `                           
           .s`                                    o-                                      /oosm..:`   ``.:hMMMh:           `/o+/.`       `-/++-                  `                                      
            `o-                                 .o.                               `        :hdN+`     :hmmysmh.               `.:/++++++//-`                                           .`               
       `      :+.                             `//`                     `                    `/yNm+    oyy::/-                                              `       `                   .                
               `:/-                         .//`                                               `:+/::::/:.`                              `                                                              
                 `./:-`                 `-:/-`                   `        `                                                   `                                                                         
            ``   `  `.:/:---..````.---:/:.`                  `                                                                                                                                          
          ``            ```..-----..```                                                                              -  `       `                            `          `                               
                                                           `                                                       .sos.                          `                                        `            
    `                               `       `                                              `              `        .s+s.            -`     `                                     `         -`           
    `                         `             `                 `               `                                     `-`            :yy     - `       `                                                  
                                                     `        `               -          `  .       `       `                      `+-                    .                      :o/                    
                                          `          `                                   `          `                                  `                                 `      `y+y                    
     `       `         `                                                   `                                                                                      .-.`           `-`                    
     `                                       `                    ``       `                `             `                                          `           `sss-                                  
                           --              `                                                   `        y/   ``                           `          `                                                  
               `    -           `          .        `    `:-             `          `                   :.                             `                        `                           ``          
                        `                                                                 `       `             `                     `.     `                  `                         `             
          `                            ..                                   `                           `       `                                                                         .             
                      `               `hh     `                     `    -/-`                                         `                                       `             `       `                   
                      +`               ``                                :+:                  `        `              .`                           `                              `                     
   `                                                         `                              `                             `                                                       .                     
                                                       `                                                                                     `        `                                                 
                        `       `.             `                             `         `       `                  `                                                                                     
    `       `                                                         `                                           `                                                                                     
                                                              `                                                                                                                                         
                                                                                                                                                                                                                                                                        
";
            Console.WriteLine(vista);
        }
    }
}
