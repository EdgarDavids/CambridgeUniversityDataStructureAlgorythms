using System.IO;
using System.Text;

namespace BasicFile
{
    public static class BasicFileOperation
    {
        public static void CreateGenericContent(string path) {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Lorem ipsum dolor sit amet, no qui mutat posse laboramus. Inani constituam disputationi nam ex, in fugit graece libris per. Cu paulo sanctus admodum duo, saperet noluisse sit cu. Id mea dicat posidonium eloquentiam. Atqui doming has eu. Vivendo invenire id nam, te pro munere repudiare.Eu qui falli aeterno vivendum, ad case probo solet vim. Mei brute persecuti ei, erroribus tincidunt eam ei.Probo nemore saperet eu per, has sanctus appareat ea, facilisis adversarium cu vim.Duo zril pertinax an. Ius tation accusata te, id euismod efficiendi consectetuer sed. Quod vocent conceptam in sed, iusto detraxit contentiones vix ei, cum id possim inermis. Sumo oratio animal vix eu. Sapientem signiferumque mea te, vidit zril sed ut.Modo albucius aliquando ut pro, ipsum albucius et quo. Quot inermis vivendo quo in.");
            stringBuilder.AppendLine("Petentium adipiscing pri in. At mazim doming vivendo sea, ne nam congue electram interpretaris. Appetere incorrupte assueverit qui in, solum primis voluptatum cu usu. Eirmod delicatissimi est ex, sed delectus atomorum intellegebat id. In postea detraxit duo. Eos nibh efficiantur ex.");
            stringBuilder.AppendLine("Magna autem minimum has ne, in vis velit deserunt signiferumque. Iudico consul laoreet nam ea, at mei elit facer reprimique, per vitae impetus persequeris at. Qui meis phaedrum eu. Pro veri corrumpit ne, per justo inani vulputate at, iusto nostro eos cu.Essent quodsi sea at, his eruditi disputationi signiferumque ut. Eam cu melius iudicabit, modo inciderint te pro. Nonumy nostro omnium sit eu.Legimus persecuti ea mea, est ea nonumy perpetua.Cum et alterum nominavi, in errem fierent imperdiet pro. Blandit eleifend gubergren te mel, falli error inciderint at vix. Summo vocent inimicus eu vel, sententiae theophrastus deterruisset eos ei. Vel posse idque delectus ea, nulla inermis an mel. Munere apeirian perpetua vel ex, placerat expetendis eu duo. An corpora consequuntur has. Vel cu malis persius sensibus, pri falli apeirian an, recusabo inimicus posidonium ex vel. Vel ad sumo facilisi, te homero similique cum, his veri commodo nostrum no.Nostro atomorum eum et, odio tale phaedrum ius ad, ex sea vidit convenire. In iisque impetus ius, eam ei blandit electram. Vix alii impetus saperet cu. Mel etiam senserit adolescens et, ad duo menandri invenire.");
            stringBuilder.AppendLine("Qui duis dicant maluisset eu. Qui eu minim harum. Ea nec ludus sensibus, dicant intellegat sententiae ea has. Eum eu mentitum suscipit. In putent debitis sea.");
            stringBuilder.AppendLine("Tota admodum cum eu, ad tibique rationibus ius. In fugit everti sea, ea pri nisl nobis. At pri aeque civibus, appetere reformidans ex usu, ea nam quod conceptam. No labores gloriatur nec, est ne autem nostro habemus. Ut tota volumus disputando qui. Ei persius liberavisse mea, in quo dissentias reprehendunt. Id quando dignissim nam. Quaeque feugiat invidunt et sit, est et brute facilisi. Ad eam assentior eloquentiam, an corrumpit rationibus his, dicant aliquid fuisset et sit.Ut his appareat consequuntur. Ea sea magna ignota integre. Quo affert quaestio scribentur id. Eos te consulatu laboramus liberavisse, cu justo splendide vituperatoribus usu. Ei vim modo iusto nusquam, mel ei choro efficiantur, illum munere percipit no nam. Solum utamur copiosae.");

            string str = stringBuilder.Replace(",", "")
                .Replace(".", "")
                .Replace("  ", " ")
                .Replace(@"\r","")
                .Replace(@"\n", "").ToString();

            File.WriteAllText(path, str);
        }

        public static string ReadFile(string path) {

            string content = File.OpenText(path).ReadToEnd();

            return content;
        }

        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }

    }
}
