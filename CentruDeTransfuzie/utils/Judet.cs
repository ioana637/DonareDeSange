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
                "Transilvania",
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
                "Transilvania",
                "Abrud",
                "Acmariu",
                "Aiud",
                "Alba-Iulia",
                "Albac"
            };
            judet.Add("Alba", alba);
            List<string> arad = new List<string>
            {
                "Crisana",
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
                "Muntenia",
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
                "Moldova",
                "Asău",
                "Balcani",
                "Blaga",
                "Buciumi",
            };
            judet.Add("Bacau", bacau);
            List<string> bihor = new List<string>
            {
                "Crisana",
                "Abram",
                "Abrămuț",
                "Albiș",
                "Borșa",
                "Bălnaca-Groși",
            };
            judet.Add("Bihor", bihor);
            List<string> bistrita = new List<string>
            {
                "Transilvania",
                "Agrieș",
                "Bața",
                "Budacu de Sus",
                "Budești",
                "Chiraleș",
            };
            judet.Add("Bistrița Năsăud", bistrita);
            List<string> botosani = new List<string>
            {
                "Moldova",
                "Alba",
                "Albești",
                "Bucecea",
                "Buda",
                "Călărași",
            };
            judet.Add("Botoșani", botosani);
            List<string> braila = new List<string>
            {
                "Muntenia",
                "Dudești",
                "Lacu Sărat",
                "Măxineni",
                "Mihail Kogălniceanu",
                "Sătuc",
            };
            judet.Add("Brăila", braila);
            List<string> brasov = new List<string>
            {
                "Transilvania",
                "Bărcuț",
                "Bogata Olteană",
                "Brașov",
                "Cincșor",
                "Corbi",
            };
            judet.Add("Brașov", brasov);
            List<string> bucuresti = new List<string>
            {
                "Muntenia",
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
                "Muntenia",
                "Bisoca",
                "Blăjani",
                "Budești",
                "Buzău",
                "Coca-Niculești"
            };
            judet.Add("Buzău", buzau);
            List<string> calarasi = new List<string>
            {
                "Muntenia",
                "Arțari",
                "Bogata",
                "Crivăț",
                "Curcani",
                "Jegălia"
            };
            judet.Add("Călărași", calarasi);
            List<string> caras_severin = new List<string>
            {
                "Banat",
                "Brebu",
                "Cornea",
                "Copăcele",
                "Grădinari",
                "Moceriș"
            };
            judet.Add("Caraș-Severin", caras_severin);
            List<string> constanta = new List<string>
            {
                "Dobrogea",
                "Constanța",
                "Costinești",
                "Lipnița",
                "Mangalia",
                "Murfatlar"
            };
            judet.Add("Constanța", constanta);
            List<string> covasna = new List<string>
            {
                "Transilvania",
                "Albiș",
                "Băcel",
                "Brețcu",
                "Catalina",
                "Floroaia"
            };
            judet.Add("Covasna", covasna);
            List<string> dambovita = new List<string>
            {
                "Muntenia",
                "Râncăciov",
                "Samurcași",
                "Săcueni",
                "Săteni",
                "Bărăceni"
            };
            judet.Add("Dâmbovița", dambovita);
            List<string> dolj = new List<string>
            {
                "Oltenia",
                "Afumați",
                "Almăj",
                "Dobrotești",
                "Foișor",
                "Florești"
            };
            judet.Add("Dolj", dolj);
            List<string> galati = new List<string>
            {
                "Moldova",
                "Adam",
                "Corcioveni",
                "Cudalbi",
                "Galați",
                "Ivești"
            };
            judet.Add("Galați", galati);
            List<string> giurgiu = new List<string>
            {
                "Muntenia",
                "Bila",
                "Clejani",
                "Comana",
                "Coteni",
                "Crânguri"
            };
            judet.Add("Giurgiu", giurgiu);
            List<string> gorj = new List<string>
            {
                "Oltenia",
                "Aluniș",
                "Aninoasa",
                "Barza",
                "Bădești",
                "Bârcaciu"
            };
            judet.Add("Gorj", gorj);
            List<string> harghita = new List<string>
            {
                "Transilvania",
                "Alexandrița",
                "Barațcoș",
                "Căpâlnița",
                "Corund",
                "Duda"
            };
            judet.Add("Harghita", harghita);
            List<string> hunedoara = new List<string>
            {
                "Transilvania",
                "Ardeu",
                "Bacea",
                "Banpotoc",
                "Băcâia",
                "Blăjeni"
            };
            judet.Add("Hunedoara", hunedoara);
            List<string> ialomita = new List<string>
            {
                "Muntenia",
                "Bordușelu",
                "Cotorca",
                "Țăndărei",
                "Amara",
                "Căzănești"
            };
            judet.Add("Ialomița", ialomita);
            List<string> iasi = new List<string>
            {
                "Moldova",
                "Albești",
                "Hârlău",
                "Podu Iloaiei",
                "Forăști",
                "Goruni"
            };
            judet.Add("Iași", iasi);
            List<string> ilfov = new List<string>
            {
                "Calarasi",
                "Balotești",
                "Bălteni",
                "Buda",
                "Buftea",
                "Gagu"
            };
            judet.Add("Ilfov", ilfov);
            List<string> maramures = new List<string>
            {
                "Maramures",
                "Ardusat",
                "Borșa",
                "Cavnic",
                "Săliștea de Sus",
                "Vișeu de Sus"
            };
            judet.Add("Maramureș", maramures);
            List<string> mehedinti = new List<string>
            {
                "Oltenia",
                "Balta",
                "Batoți",
                "Brateșul",
                "Cracu Muntelui",
                "Dobra"
            };
            judet.Add("Mehedinți", mehedinti);
            List<string> mures = new List<string>
            {
                "Transilvania",
                "Abuș",
                "Blidireasa",
                "Bozed",
                "Băgaciu",
                "Ciobotani"
            };
            judet.Add("Mureș", mures);
            List<string> neamt = new List<string>
            {
                "Moldova",
                "Bețești",
                "Bicaz",
                "Dobreni",
                "Hârțești",
                "Horia"
            };
            judet.Add("Neamț", neamt);
            List<string> olt = new List<string>
            {
                "Oltenia",
                "Alunișu",
                "Curtișoara",
                "Frunzaru",
                "Lisa",
                "Lunca"
            };
            judet.Add("Olt", olt);
            List<string> prahova = new List<string>
            {
                "Muntenia",
                "Antofiloaia",
                "Băltița",
                "Bighilin",
                "Breaza",
                "Călinești"
            };
            judet.Add("Prahova", prahova);
            List<string> salaj = new List<string>
            {
                "Crisana",
                "Aleuș",
                "Ban",
                "Bârsa",
                "Bocșa",
                "Bozna"
            };
            judet.Add("Sălaj", salaj);
            List<string> satuMare = new List<string>
            {
                "Maramures",
                "Agriș",
                "Baba Novac",
                "Hodișa",
                "Lazuri",
                "Lelei"
            };
            judet.Add("Satu Mare", satuMare);
            List<string> sibiu = new List<string>
            {
                "Transilvania",
                "Alma",
                "Armeni",
                "Bradu",
                "Cârța",
                "Sibiu"
            };
            judet.Add("Sibiu", sibiu);
            List<string> suceava = new List<string>
            {
                "Bucovina",
                "Arbore",
                "Brașca",
                "Catrinari",
                "Dragoșa",
                "Suceava"
            };
            judet.Add("Suceava", suceava);
            List<string> teleorman = new List<string>
            {
                "Muntenia",
                "Teleormanu",
                "Udeni",
                "Vitănești",
                "Zâmbreasca",
                "Zlata"
            };
            judet.Add("Teleorman", teleorman);
            List<string> timis = new List<string>
            {
                "Banat",
                "Bacova",
                "Bârna",
                "Bobda",
                "Căpăt",
                "Chișoda"
            };
            judet.Add("Timiș", timis);
            List<string> tulcea = new List<string>
            {
                "Dobrogea",
                "Babadag",
                "Baia",
                "Isaccea",
                "Măcin",
                "Sulina"
            };
            judet.Add("Tulcea", tulcea);
            List<string> valcea = new List<string>
            {
                "Oltenia",
                "Aurești",
                "Balota",
                "Becșani",
                "Bodești",
                "Bonciu"
            };
            judet.Add("Vâlcea", valcea);
            List<string> vaslui = new List<string>
            {
                "Moldova",
                "Armășeni",
                "Bogdana",
                "Bârlad",
                "Cioatele",
                "Cotic"
            };
            judet.Add("Vaslui", vaslui);
            List<string> vrancea = new List<string>
            {
                "Moldova",
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
