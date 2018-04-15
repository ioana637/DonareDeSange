using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentruDeTransfuzie.utils
{
    public class Judet
    {
        public Dictionary<string, List<string>> judet = new Dictionary<string, List<string>>();

        public Judet()
        {
            List<string> cluj = new List<string> {
                "Agârbiciu",
                "Aghireș",
                "Apahida",
                "Baciu",
                "Băișoara",
                "Beliș",
                "Turda",
                "Cluj-Napoca"
            };
            judet.Add("Cluj", cluj);

            List<string> alba = new List<string> {
                "Abrud",
                "Acmariu",
                "Aiud",
                "Alba-Iulia",
                "Albac"
            };
            judet.Add("Alba", alba);
            List<string> arad = new List<string>
            {
                "Adea",
                "Almaș",
                "Arad",
                "Avram Iancu",
                "Baia",
                "Tauț"
            };
            judet.Add("Arad", arad);
            List<string> arges = new List<string>
            {
                "Adunați",
                "Albești",
                "Bascov",
                "Băcești",
                "Bogați",
                "Boțești"
            };
            judet.Add("Arges", arges);
            List<string> bacau = new List<string>
            {
                "Asău",
                "Balcani",
                "Blaga",
                "Buciumi",
            };
            judet.Add("Bacau", bacau);
            List<string> bihor = new List<string>
            {
                "Abram",
                "Abrămuț",
                "Albiș",
                "Borșa",
                "Bălnaca-Groși",
            };
            judet.Add("Bihor", bihor);
            List<string> bistrita = new List<string>
            {
                "Agrieș",
                "Bața",
                "Budacu de Sus",
                "Budești",
                "Chiraleș",
            };
            judet.Add("Bistrița Năsăud", bistrita);
            List<string> botosani = new List<string>
            {
                "Alba",
                "Albești",
                "Bucecea",
                "Buda",
                "Călărași",
            };
            judet.Add("Botoșani", botosani);
            List<string> braila = new List<string>
            {
                "Dudești",
                "Lacu Sărat",
                "Măxineni",
                "Mihail Kogălniceanu",
                "Sătuc",
            };
            judet.Add("Brăila", braila);
            List<string> brasov = new List<string>
            {
                "Bărcuț",
                "Bogata Olteană",
                "Brașov",
                "Cincșor",
                "Corbi",
            };
            judet.Add("Brașov", brasov);
            List<string> bucuresti = new List<string>
            {
                "Sector 1",
                "Sector 2",
                "Sector 3",
                "Sector 4",
                "Sector 5",
                "Sector 6"
            };
            judet.Add("București", bucuresti);
            List<string> buzau = new List<string>
            {
                "Bisoca",
                "Blăjani",
                "Budești",
                "Buzău",
                "Coca-Niculești"
            };
            judet.Add("Buzău", buzau);
            List<string> calarasi = new List<string>
            {
                "Arțari",
                "Bogata",
                "Crivăț",
                "Curcani",
                "Jegălia"
            };
            judet.Add("Călărași", calarasi);
            List<string> caras_severin = new List<string>
            {
                "Brebu",
                "Cornea",
                "Copăcele",
                "Grădinari",
                "Moceriș"
            };
            judet.Add("Caraș-Severin", caras_severin);
            List<string> constanta = new List<string>
            {
                "Constanța",
                "Costinești",
                "Lipnița",
                "Mangalia",
                "Murfatlar"
            };
            judet.Add("Constanța", constanta);
            List<string> covasna = new List<string>
            {
                "Albiș",
                "Băcel",
                "Brețcu",
                "Catalina",
                "Floroaia"
            };
            judet.Add("Covasna", covasna);
            List<string> dambovita = new List<string>
            {
                "Râncăciov",
                "Samurcași",
                "Săcueni",
                "Săteni",
                "Bărăceni"
            };
            judet.Add("Dâmbovița", dambovita);
            List<string> dolj = new List<string>
            {
                "Afumați",
                "Almăj",
                "Dobrotești",
                "Foișor",
                "Florești"
            };
            judet.Add("Dolj", dolj);
            List<string> galati = new List<string>
            {
                "Adam",
                "Corcioveni",
                "Cudalbi",
                "Galați",
                "Ivești"
            };
            judet.Add("Galați", galati);
            List<string> giurgiu = new List<string>
            {
                "Bila",
                "Clejani",
                "Comana",
                "Coteni",
                "Crânguri"
            };
            judet.Add("Giurgiu", giurgiu);
            List<string> gorj = new List<string>
            {
                "Aluniș",
                "Aninoasa",
                "Barza",
                "Bădești",
                "Bârcaciu"
            };
            judet.Add("Gorj", gorj);
            List<string> harghita = new List<string>
            {
                "Alexandrița",
                "Barațcoș",
                "Căpâlnița",
                "Corund",
                "Duda"
            };
            judet.Add("Harghita", harghita);
            List<string> hunedoara = new List<string>
            {
                "Ardeu",
                "Bacea",
                "Banpotoc",
                "Băcâia",
                "Blăjeni"
            };
            judet.Add("Hunedoara", hunedoara);
            List<string> ialomita = new List<string>
            {
                "Bordușelu",
                "Cotorca",
                "Țăndărei",
                "Amara",
                "Căzănești"
            };
            judet.Add("Ialomița", ialomita);
            List<string> iasi = new List<string>
            {
                "Albești",
                "Hârlău",
                "Podu Iloaiei",
                "Forăști",
                "Goruni"
            };
            judet.Add("Iași", iasi);
            List<string> ilfov = new List<string>
            {
                "Balotești",
                "Bălteni",
                "Buda",
                "Buftea",
                "Gagu"
            };
            judet.Add("Ilfov", ilfov);
            List<string> maramures = new List<string>
            {
                "Ardusat",
                "Borșa",
                "Cavnic",
                "Săliștea de Sus",
                "Vișeu de Sus"
            };
            judet.Add("Maramureș", maramures);
            List<string> mehedinti = new List<string>
            {
                "Balta",
                "Batoți",
                "Brateșul",
                "Cracu Muntelui",
                "Dobra"
            };
            judet.Add("Mehedinți", mehedinti);
            List<string> mures = new List<string>
            {
                "Abuș",
                "Blidireasa",
                "Bozed",
                "Băgaciu",
                "Ciobotani"
            };
            judet.Add("Mureș", mures);
            List<string> neamt = new List<string>
            {
                "Bețești",
                "Bicaz",
                "Dobreni",
                "Hârțești",
                "Horia"
            };
            judet.Add("Neamț", neamt);
            List<string> olt = new List<string>
            {
                "Alunișu",
                "Curtișoara",
                "Frunzaru",
                "Lisa",
                "Lunca"
            };
            judet.Add("Olt", olt);
            List<string> prahova = new List<string>
            {
                "Antofiloaia",
                "Băltița",
                "Bighilin",
                "Breaza",
                "Călinești"
            };
            judet.Add("Prahova", prahova);
            List<string> salaj = new List<string>
            {
                "Aleuș",
                "Ban",
                "Bârsa",
                "Bocșa",
                "Bozna"
            };
            judet.Add("Sălaj", salaj);
            List<string> satuMare = new List<string>
            {
                "Agriș",
                "Baba Novac",
                "Hodișa",
                "Lazuri",
                "Lelei"
            };
            judet.Add("Satu Mare", satuMare);
            List<string> sibiu = new List<string>
            {
                "Alma",
                "Armeni",
                "Bradu",
                "Cârța",
                "Sibiu"
            };
            judet.Add("Sibiu", sibiu);
            List<string> suceava = new List<string>
            {
                "Arbore",
                "Brașca",
                "Catrinari",
                "Dragoșa",
                "Suceava"
            };
            judet.Add("Suceava", suceava);
            List<string> teleorman = new List<string>
            {
                "Teleormanu",
                "Udeni",
                "Vitănești",
                "Zâmbreasca",
                "Zlata"
            };
            judet.Add("Teleorman", teleorman);
            List<string> timis = new List<string>
            {
                "Bacova",
                "Bârna",
                "Bobda",
                "Căpăt",
                "Chișoda"
            };
            judet.Add("Timiș", timis);
            List<string> tulcea = new List<string>
            {
                "Babadag",
                "Baia",
                "Isaccea",
                "Măcin",
                "Sulina"
            };
            judet.Add("Tulcea", tulcea);
            List<string> valcea = new List<string>
            {
                "Aurești",
                "Balota",
                "Becșani",
                "Bodești",
                "Bonciu"
            };
            judet.Add("Vâlcea", valcea);
            List<string> vaslui = new List<string>
            {
                "Armășeni",
                "Bogdana",
                "Bârlad",
                "Cioatele",
                "Cotic"
            };
            judet.Add("Vaslui", vaslui);
            List<string> vrancea = new List<string>
            {
                "Bizighești",
                "Bordești",
                "Cârligele",
                "Corbița",
                "Doaga"
            };
            judet.Add("Vrancea", vrancea);

        }
    }
}
