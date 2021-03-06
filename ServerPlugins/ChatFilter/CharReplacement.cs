﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatFilter
{
    class CharReplacement
    {
        public static char[] BaseReplacementText = "abcedfghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
        public static string[][] DerivedReplacementTexts = new string[][]
        {
new string[]{"ⓐ","ⓑ","ⓒ","ⓔ","ⓓ","ⓕ","ⓖ","ⓗ","ⓘ","ⓙ","ⓚ","ⓛ","ⓜ","ⓝ","ⓞ","ⓟ","ⓠ","ⓡ","ⓢ","ⓣ","ⓤ","ⓥ","ⓦ","ⓧ","ⓨ","ⓩ","Ⓐ","Ⓑ","Ⓒ","Ⓓ","Ⓔ","Ⓕ","Ⓖ","Ⓗ","Ⓘ","Ⓙ","Ⓚ","Ⓛ","Ⓜ","Ⓝ","Ⓞ","Ⓟ","Ⓠ","Ⓡ","Ⓢ","Ⓣ","Ⓤ","Ⓥ","Ⓦ","Ⓧ","Ⓨ","Ⓩ","①","②","③","④","⑤","⑥","⑦","⑧","⑨","0"},
new string[]{"🅐","🅑","🅒","🅔","🅓","🅕","🅖","🅗","🅘","🅙","🅚","🅛","🅜","🅝","🅞","🅟","🅠","🅡","🅢","🅣","🅤","🅥","🅦","🅧","🅨","🅩","🅐","🅑","🅒","🅓","🅔","🅕","🅖","🅗","🅘","🅙","🅚","🅛","🅜","🅝","🅞","🅟","🅠","🅡","🅢","🅣","🅤","🅥","🅦","🅧","🅨","🅩","1","2","3","4","5","6","7","8","9","⓿"},
new string[]{"ａ","ｂ","ｃ","ｅ","ｄ","ｆ","ｇ","ｈ","ｉ","ｊ","ｋ","ｌ","ｍ","ｎ","ｏ","ｐ","ｑ","ｒ","ｓ","ｔ","ｕ","ｖ","ｗ","ｘ","ｙ","ｚ","Ａ","Ｂ","Ｃ","Ｄ","Ｅ","Ｆ","Ｇ","Ｈ","Ｉ","Ｊ","Ｋ","Ｌ","Ｍ","Ｎ","Ｏ","Ｐ","Ｑ","Ｒ","Ｓ","Ｔ","Ｕ","Ｖ","Ｗ","Ｘ","Ｙ","Ｚ","１","２","３","４","５","６","７","８","９","０"},
new string[]{"𝐚","𝐛","𝐜","𝐞","𝐝","𝐟","𝐠","𝐡","𝐢","𝐣","𝐤","𝐥","𝐦","𝐧","𝐨","𝐩","𝐪","𝐫","𝐬","𝐭","𝐮","𝐯","𝐰","𝐱","𝐲","𝐳","𝐀","𝐁","𝐂","𝐃","𝐄","𝐅","𝐆","𝐇","𝐈","𝐉","𝐊","𝐋","𝐌","𝐍","𝐎","𝐏","𝐐","𝐑","𝐒","𝐓","𝐔","𝐕","𝐖","𝐗","𝐘","𝐙","𝟏","𝟐","𝟑","𝟒","𝟓","𝟔","𝟕","𝟖","𝟗","𝟎"},
new string[]{"𝖆","𝖇","𝖈","𝖊","𝖉","𝖋","𝖌","𝖍","𝖎","𝖏","𝖐","𝖑","𝖒","𝖓","𝖔","𝖕","𝖖","𝖗","𝖘","𝖙","𝖚","𝖛","𝖜","𝖝","𝖞","𝖟","𝕬","𝕭","𝕮","𝕯","𝕰","𝕱","𝕲","𝕳","𝕴","𝕵","𝕶","𝕷","𝕸","𝕹","𝕺","𝕻","𝕼","𝕽","𝕾","𝕿","𝖀","𝖁","𝖂","𝖃","𝖄","𝖅","1","2","3","4","5","6","7","8","9","0"},
new string[]{"𝒂","𝒃","𝒄","𝒆","𝒅","𝒇","𝒈","𝒉","𝒊","𝒋","𝒌","𝒍","𝒎","𝒏","𝒐","𝒑","𝒒","𝒓","𝒔","𝒕","𝒖","𝒗","𝒘","𝒙","𝒚","𝒛","𝑨","𝑩","𝑪","𝑫","𝑬","𝑭","𝑮","𝑯","𝑰","𝑱","𝑲","𝑳","𝑴","𝑵","𝑶","𝑷","𝑸","𝑹","𝑺","𝑻","𝑼","𝑽","𝑾","𝑿","𝒀","𝒁","1","2","3","4","5","6","7","8","9","0"},
new string[]{"𝓪","𝓫","𝓬","𝓮","𝓭","𝓯","𝓰","𝓱","𝓲","𝓳","𝓴","𝓵","𝓶","𝓷","𝓸","𝓹","𝓺","𝓻","𝓼","𝓽","𝓾","𝓿","𝔀","𝔁","𝔂","𝔃","𝓐","𝓑","𝓒","𝓓","𝓔","𝓕","𝓖","𝓗","𝓘","𝓙","𝓚","𝓛","𝓜","𝓝","𝓞","𝓟","𝓠","𝓡","𝓢","𝓣","𝓤","𝓥","𝓦","𝓧","𝓨","𝓩","1","2","3","4","5","6","7","8","9","0"},
new string[]{"𝕒","𝕓","𝕔","𝕖","𝕕","𝕗","𝕘","𝕙","𝕚","𝕛","𝕜","𝕝","𝕞","𝕟","𝕠","𝕡","𝕢","𝕣","𝕤","𝕥","𝕦","𝕧","𝕨","𝕩","𝕪","𝕫","𝔸","𝔹","ℂ","𝔻","𝔼","𝔽","𝔾","ℍ","𝕀","𝕁","𝕂","𝕃","𝕄","ℕ","𝕆","ℙ","ℚ","ℝ","𝕊","𝕋","𝕌","𝕍","𝕎","𝕏","𝕐","ℤ","𝟙","𝟚","𝟛","𝟜","𝟝","𝟞","𝟟","𝟠","𝟡","𝟘"},
new string[]{"𝚊","𝚋","𝚌","𝚎","𝚍","𝚏","𝚐","𝚑","𝚒","𝚓","𝚔","𝚕","𝚖","𝚗","𝚘","𝚙","𝚚","𝚛","𝚜","𝚝","𝚞","𝚟","𝚠","𝚡","𝚢","𝚣","𝙰","𝙱","𝙲","𝙳","𝙴","𝙵","𝙶","𝙷","𝙸","𝙹","𝙺","𝙻","𝙼","𝙽","𝙾","𝙿","𝚀","𝚁","𝚂","𝚃","𝚄","𝚅","𝚆","𝚇","𝚈","𝚉","𝟷","𝟸","𝟹","𝟺","𝟻","𝟼","𝟽","𝟾","𝟿","𝟶"},
new string[]{"𝖺","𝖻","𝖼","𝖾","𝖽","𝖿","𝗀","𝗁","𝗂","𝗃","𝗄","𝗅","𝗆","𝗇","𝗈","𝗉","𝗊","𝗋","𝗌","𝗍","𝗎","𝗏","𝗐","𝗑","𝗒","𝗓","𝖠","𝖡","𝖢","𝖣","𝖤","𝖥","𝖦","𝖧","𝖨","𝖩","𝖪","𝖫","𝖬","𝖭","𝖮","𝖯","𝖰","𝖱","𝖲","𝖳","𝖴","𝖵","𝖶","𝖷","𝖸","𝖹","𝟣","𝟤","𝟥","𝟦","𝟧","𝟨","𝟩","𝟪","𝟫","𝟢"},
new string[]{"𝗮","𝗯","𝗰","𝗲","𝗱","𝗳","𝗴","𝗵","𝗶","𝗷","𝗸","𝗹","𝗺","𝗻","𝗼","𝗽","𝗾","𝗿","𝘀","𝘁","𝘂","𝘃","𝘄","𝘅","𝘆","𝘇","𝗔","𝗕","𝗖","𝗗","𝗘","𝗙","𝗚","𝗛","𝗜","𝗝","𝗞","𝗟","𝗠","𝗡","𝗢","𝗣","𝗤","𝗥","𝗦","𝗧","𝗨","𝗩","𝗪","𝗫","𝗬","𝗭","𝟭","𝟮","𝟯","𝟰","𝟱","𝟲","𝟳","𝟴","𝟵","𝟬"},
new string[]{"𝙖","𝙗","𝙘","𝙚","𝙙","𝙛","𝙜","𝙝","𝙞","𝙟","𝙠","𝙡","𝙢","𝙣","𝙤","𝙥","𝙦","𝙧","𝙨","𝙩","𝙪","𝙫","𝙬","𝙭","𝙮","𝙯","𝘼","𝘽","𝘾","𝘿","𝙀","𝙁","𝙂","𝙃","𝙄","𝙅","𝙆","𝙇","𝙈","𝙉","𝙊","𝙋","𝙌","𝙍","𝙎","𝙏","𝙐","𝙑","𝙒","𝙓","𝙔","𝙕","1","2","3","4","5","6","7","8","9","0"},
new string[]{"𝘢","𝘣","𝘤","𝘦","𝘥","𝘧","𝘨","𝘩","𝘪","𝘫","𝘬","𝘭","𝘮","𝘯","𝘰","𝘱","𝘲","𝘳","𝘴","𝘵","𝘶","𝘷","𝘸","𝘹","𝘺","𝘻","𝘈","𝘉","𝘊","𝘋","𝘌","𝘍","𝘎","𝘏","𝘐","𝘑","𝘒","𝘓","𝘔","𝘕","𝘖","𝘗","𝘘","𝘙","𝘚","𝘛","𝘜","𝘝","𝘞","𝘟","𝘠","𝘡","1","2","3","4","5","6","7","8","9","0"},
new string[]{"⒜","⒝","⒞","⒠","⒟","⒡","⒢","⒣","⒤","⒥","⒦","⒧","⒨","⒩","⒪","⒫","⒬","⒭","⒮","⒯","⒰","⒱","⒲","⒳","⒴","⒵","⒜","⒝","⒞","⒟","⒠","⒡","⒢","⒣","⒤","⒥","⒦","⒧","⒨","⒩","⒪","⒫","⒬","⒭","⒮","⒯","⒰","⒱","⒲","⒳","⒴","⒵","⑴","⑵","⑶","⑷","⑸","⑹","⑺","⑻","⑼","0"},
new string[]{"🇦","🇧","🇨","🇪","🇩","🇫","🇬","🇭","🇮","🇯","🇰","🇱","🇲","🇳","🇴","🇵","🇶","🇷","🇸","🇹","🇺","🇻","🇼","🇽","🇾","🇿","🇦","🇧","🇨","🇩","🇪","🇫","🇬","🇭","🇮","🇯","🇰","🇱","🇲","🇳","🇴","🇵","🇶","🇷","🇸","🇹","🇺","🇻","🇼","🇽","🇾","🇿","1","2","3","4","5","6","7","8","9","0"},
new string[]{"🄰","🄱","🄲","🄴","🄳","🄵","🄶","🄷","🄸","🄹","🄺","🄻","🄼","🄽","🄾","🄿","🅀","🅁","🅂","🅃","🅄","🅅","🅆","🅇","🅈","🅉","🄰","🄱","🄲","🄳","🄴","🄵","🄶","🄷","🄸","🄹","🄺","🄻","🄼","🄽","🄾","🄿","🅀","🅁","🅂","🅃","🅄","🅅","🅆","🅇","🅈","🅉","1","2","3","4","5","6","7","8","9","0"},
new string[]{"🅰","🅱","🅲","🅴","🅳","🅵","🅶","🅷","🅸","🅹","🅺","🅻","🅼","🅽","🅾","🅿","🆀","🆁","🆂","🆃","🆄","🆅","🆆","🆇","🆈","🆉","🅰","🅱","🅲","🅳","🅴","🅵","🅶","🅷","🅸","🅹","🅺","🅻","🅼","🅽","🅾","🅿","🆀","🆁","🆂","🆃","🆄","🆅","🆆","🆇","🆈","🆉","1","2","3","4","5","6","7","8","9","0"},
new string[]{"󠁡","󠁢","󠁣","󠁥","󠁤","󠁦","󠁧","󠁨","󠁩","󠁪","󠁫","󠁬","󠁭","󠁮","󠁯","󠁰","󠁱","󠁲","󠁳","󠁴","󠁵","󠁶","󠁷","󠁸","󠁹","󠁺","󠁁","󠁂","󠁃","󠁄","󠁅","󠁆","󠁇","󠁈","󠁉","󠁊","󠁋","󠁌","󠁍","󠁎","󠁏","󠁐","󠁑","󠁒","󠁓","󠁔","󠁕","󠁖","󠁗","󠁘","󠁙","󠁚","󠀱","󠀲","󠀳","󠀴","󠀵","󠀶","󠀷","󠀸","󠀹","󠀰"},
new string[]{"á","b","ć","é","d","f","ǵ","h","í","j","ḱ","ĺ","ḿ","ń","ő","ṕ","q","ŕ","ś","t","ú","v","ẃ","x","ӳ","ź","Á","B","Ć","D","É","F","Ǵ","H","í","J","Ḱ","Ĺ","Ḿ","Ń","Ő","Ṕ","Q","Ŕ","ś","T","Ű","V","Ẃ","X","Ӳ","Ź","1","2","3","4","5","6","7","8","9","0"},
new string[]{"ﾑ","乃","c","乇","d","ｷ","g","ん","ﾉ","ﾌ","ズ","ﾚ","ﾶ","刀","o","ｱ","q","尺","丂","ｲ","u","√","w","ﾒ","ﾘ","乙","ﾑ","乃","c","d","乇","ｷ","g","ん","ﾉ","ﾌ","ズ","ﾚ","ﾶ","刀","o","ｱ","q","尺","丂","ｲ","u","√","w","ﾒ","ﾘ","乙","1","2","3","4","5","6","7","8","9","0"},
new string[]{"ค","๒","ƈ","ﻉ","ɗ","ि","ﻭ","ɦ","ٱ","ﻝ","ᛕ","ɭ","๓","ก","ѻ","ρ","۹","ɼ","ร","Շ","પ","۷","ฝ","ซ","ץ","չ","ค","๒","ƈ","ɗ","ﻉ","ि","ﻭ","ɦ","ٱ","ﻝ","ᛕ","ɭ","๓","ก","ѻ","ρ","۹","ɼ","ร","Շ","પ","۷","ฝ","ซ","ץ","չ","1","2","3","4","5","6","7","8","9","0"},
new string[]{"α","в","¢","є","∂","ƒ","ﻭ","н","ι","נ","к","ℓ","м","η","σ","ρ","۹","я","ѕ","т","υ","ν","ω","χ","у","չ","α","в","¢","∂","є","ƒ","ﻭ","н","ι","נ","к","ℓ","м","η","σ","ρ","۹","я","ѕ","т","υ","ν","ω","χ","у","չ","1","2","3","4","5","6","7","8","9","0"},
new string[]{"ค","๒","ς","є","๔","Ŧ","ﻮ","ђ","เ","ן","к","ɭ","๓","ภ","๏","ק","ợ","г","ร","Շ","ย","ש","ฬ","א","ץ","չ","ค","๒","ς","๔","є","Ŧ","ﻮ","ђ","เ","ן","к","ɭ","๓","ภ","๏","ק","ợ","г","ร","Շ","ย","ש","ฬ","א","ץ","չ","1","2","3","4","5","6","7","8","9","0"},
new string[]{"а","ъ","с","э","ↁ","f","Б","Ђ","і","ј","к","l","м","и","о","р","q","ѓ","ѕ","т","ц","v","ш","х","Ў","z","Д","Б","Ҁ","ↁ","Є","F","Б","Н","І","Ј","Ќ","L","М","И","Ф","Р","Q","Я","Ѕ","Г","Ц","V","Щ","Ж","Ч","Z","1","2","3","4","5","6","7","8","9","0"},
new string[]{"ል","ጌ","ር","ቿ","ዕ","ቻ","ኗ","ዘ","ጎ","ጋ","ጕ","ረ","ጠ","ክ","ዐ","የ","ዒ","ዪ","ነ","ፕ","ሁ","ሀ","ሠ","ሸ","ሃ","ጊ","ል","ጌ","ር","ዕ","ቿ","ቻ","ኗ","ዘ","ጎ","ጋ","ጕ","ረ","ጠ","ክ","ዐ","የ","ዒ","ዪ","ነ","ፕ","ሁ","ሀ","ሠ","ሸ","ሃ","ጊ","1","2","3","4","5","6","7","8","9","0"},
new string[]{"𝔞","𝔟","𝔠","𝔢","𝔡","𝔣","𝔤","𝔥","𝔦","𝔧","𝔨","𝔩","𝔪","𝔫","𝔬","𝔭","𝔮","𝔯","𝔰","𝔱","𝔲","𝔳","𝔴","𝔵","𝔶","𝔷","𝔄","𝔅","ℭ","𝔇","𝔈","𝔉","𝔊","ℌ","ℑ","𝔍","𝔎","𝔏","𝔐","𝔑","𝔒","𝔓","𝔔","ℜ","𝔖","𝔗","𝔘","𝔙","𝔚","𝔛","𝔜","ℨ","1","2","3","4","5","6","7","8","9","0"},
new string[]{"ä","ḅ","ċ","ë","ḋ","ḟ","ġ","ḧ","ï","j","ḳ","ḷ","ṁ","ṅ","ö","ṗ","q","ṛ","ṡ","ẗ","ü","ṿ","ẅ","ẍ","ÿ","ż","Ä","Ḅ","Ċ","Ḋ","Ё","Ḟ","Ġ","Ḧ","Ї","J","Ḳ","Ḷ","Ṁ","Ṅ","Ö","Ṗ","Q","Ṛ","Ṡ","Ṫ","Ü","Ṿ","Ẅ","Ẍ","Ÿ","Ż","1","2","ӟ","4","5","6","7","8","9","0"},
new string[]{"ᴀ","ʙ","ᴄ","ᴇ","ᴅ","ꜰ","ɢ","ʜ","ɪ","ᴊ","ᴋ","ʟ","ᴍ","ɴ","ᴏ","ᴩ","q","ʀ","ꜱ","ᴛ","ᴜ","ᴠ","ᴡ","x","y","ᴢ","ᴀ","ʙ","ᴄ","ᴅ","ᴇ","ꜰ","ɢ","ʜ","ɪ","ᴊ","ᴋ","ʟ","ᴍ","ɴ","ᴏ","ᴩ","Q","ʀ","ꜱ","ᴛ","ᴜ","ᴠ","ᴡ","x","Y","ᴢ","1","2","3","4","5","6","7","8","9","0"},
new string[]{"Ⱥ","ƀ","ȼ","ɇ","đ","f","ǥ","ħ","ɨ","ɉ","ꝁ","ł","m","n","ø","ᵽ","ꝗ","ɍ","s","ŧ","ᵾ","v","w","x","ɏ","ƶ","Ⱥ","Ƀ","Ȼ","Đ","Ɇ","F","Ǥ","Ħ","Ɨ","Ɉ","Ꝁ","Ł","M","N","Ø","Ᵽ","Ꝗ","Ɍ","S","Ŧ","ᵾ","V","W","X","Ɏ","Ƶ","1","ƻ","3","4","5","6","7","8","9","0"},
new string[]{"ₐ","b","c","ₑ","d","f","g","ₕ","ᵢ","ⱼ","ₖ","ₗ","ₘ","ₙ","ₒ","ₚ","q","ᵣ","ₛ","ₜ","ᵤ","ᵥ","w","ₓ","y","z","ₐ","B","C","D","ₑ","F","G","ₕ","ᵢ","ⱼ","ₖ","ₗ","ₘ","ₙ","ₒ","ₚ","Q","ᵣ","ₛ","ₜ","ᵤ","ᵥ","W","ₓ","Y","Z","₁","₂","₃","₄","₅","₆","₇","₈","₉","₀"},
new string[]{"ᵃ","ᵇ","ᶜ","ᵉ","ᵈ","ᶠ","ᵍ","ʰ","ⁱ","ʲ","ᵏ","ˡ","ᵐ","ⁿ","ᵒ","ᵖ","q","ʳ","ˢ","ᵗ","ᵘ","ᵛ","ʷ","ˣ","ʸ","ᶻ","ᴬ","ᴮ","ᶜ","ᴰ","ᴱ","ᶠ","ᴳ","ᴴ","ᴵ","ᴶ","ᴷ","ᴸ","ᴹ","ᴺ","ᴼ","ᴾ","Q","ᴿ","ˢ","ᵀ","ᵁ","ⱽ","ᵂ","ˣ","ʸ","ᶻ","¹","²","³","⁴","⁵","⁶","⁷","⁸","⁹","⁰"},
new string[]{"ɐ","q","ɔ","ǝ","p","ɟ","ƃ","ɥ","ı","ɾ","ʞ","ן","ɯ","u","o","d","b","ɹ","s","ʇ","n","ʌ","ʍ","x","ʎ","z","ɐ","q","ɔ","p","ǝ","ɟ","ƃ","ɥ","ı","ɾ","ʞ","ן","ɯ","u","o","d","b","ɹ","s","ʇ","n","𐌡","ʍ","x","ʎ","z","1","2","3","4","5","6","7","8","9","0"},
new string[]{"A","d","ↄ","ɘ","b","ꟻ","g","H","i","j","k","l","m","ᴎ","o","q","p","ᴙ","ꙅ","T","U","v","w","x","Y","z","A","d","Ↄ","b","Ǝ","ꟻ","G","H","I","J","K","⅃","M","ᴎ","O","ꟼ","p","ᴙ","Ꙅ","T","U","V","W","X","Y","Z","߁","2","3","4","5","6","7","8","9","0"}
        };

        public static string ConvertTextToBase(string text)
        {
            for (int i = 0; i < BaseReplacementText.Length; i++)
            {
                foreach (var array in DerivedReplacementTexts)
                {
                    text = text.Replace(array[i], BaseReplacementText[i].ToString());
                }
            }
            return text;
        }
    }
}
