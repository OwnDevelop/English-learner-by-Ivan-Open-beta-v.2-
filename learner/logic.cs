using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learner
{
    public class logic
    {
        public bool n1, n2;
        Random rnd = new Random((int)DateTime.Now.Ticks);
        Random rnd2 = new Random((int)DateTime.Now.Ticks);
        double progress = 0.0;
        public static char[] ch = {'*' };
        string str, str2;
        static string[] words = "Condensed-сгущенный*talk over-обсуждать*request-запрос *permission-разрешение *parole board-Условно-досрочное освобождение *fuss-суета *crook-мошенник *charitable-благотворительная деятельность*soar-парить*flap into-вталкивать*skim off-снимать убирать*accomplish-достигать, выполнить*wind up-заводить *chase-гнаться *arrow-стрела *destruction of property-уничтожение имущества *obtuse-тупой *scam-мошенничество * hayfield - сенокос, скошенный луг*pry smth up-подглядывать *thamp-оттиск *thick as thieves-закодычные друзья *meticulous-тщательный *buffle-пустота *foulness-гнилость *strode-шагал *spot on match- совпадение? *redemption-выкуп *intention-намерение *confused-смущённый *sober up-протрезвиться *nary-ни капли *riddle with-загадывать *coincidence-совпадение *drag-бремя *footprint-отпечаток (ноги) *fingerprint-отпечаток пальца *merit a death sentence-Заслужить смертный приговор *condone-мириться *remorsless-беспощадный *vested in me-наделил меня *life sentence-пожизненное заключение *rehabilitated-Реабилитированный *reject-отвергать *reefer-косяк с мариванной *smuggle-контробанда *jeer-насмешка *maggot-личинка *felons-преступники *blasphemy-богохульство *tough-жёсткий *delouse-выводить вшей *blink of an eye-мнгновение ока *con-вор (на доверии) *nitwit-глупый *ankles-лодыжки *straw-солома *deprive of-лишать чего-то *malfunction-неисправность *lullaby -колыбельная *infirmary-лазарет *tier-уровень *ripe-спелый *sloppy kiss-неряшливый поцелуй *bastard-ублюдок (внебрачный сын)*mica-слюда *shale-сланец  *qualify-Квалифицировать *gem shop-Магазин драгоценных камней *shoelace-шнурок *snobby-чванливый (хвастливый, надменный) *stroll-прогулка *shield-щит  *fetch smb up-привлекать *resurface-всплывать на поверхность *sweepstake-тотализатор (пари на скачках) *pester-приставать *hamstring-подколенное сухожилие *magnanimous-великодушный *hunkered-чокнутый *soapstone-мыльный камень, стеастит *pebble-галька *crowbar-лом *rapture-восторг *salvation-спасение *".Split(ch , StringSplitOptions.RemoveEmptyEntries);
        static string[] words2 = words;
        int[] list = new int[words.Length];
        int[] list2 = new int[words2.Length];

        public void showOne(Label lab)
        {
            lab.Text = W(1);
        }
        public void showTwo(Label lab)
        {
            lab.Text = W(2);
        }
        public void showThree(Label lab)
        {
            lab.Text = W2(3);
        }
        public void showFour(Label lab)
        {
            lab.Text = W2(4);
        }

        public bool Next()
        {
            bool check = true;
            while (check)
            {
                int tmp = rnd.Next(0, words.Length);
                if (Cont(tmp, list))
                {
                    if (isFull(list))
                    {
                        n1 = true;
                        return true;    
                    }

                    continue;
                }
                list[tmp] = 1;
                if (tmp == 0)
                    list[tmp] = 1;
                check = false;
                str = words[tmp];
            }
            return false;
        }

        public bool Next2()
        {
            while (true)
            {
                int tmp = rnd2.Next(0, words2.Length);
                if (Cont(tmp, list2))
                {
                    if (isFull(list2))
                    {
                        n2 = true;
                        return true;
                    }
                    continue;
                }
                list2[tmp] = 1;
                if (tmp == 0)
                    list2[tmp] = 1;

                str2 = words2[tmp];
                return false;
            }
        }
        internal string W(int n)
        {
            if (n == 1)
            {
                return str.Split('-')[0];
            }
            else if ( n == 2)
            {
                return str.Split('-')[1];
            }
            return " ";
        }

        internal string W2(int n)
        {
            if (n == 3)
            {
                return str2.Split('-')[1];
            }
            else if (n == 4)
            {
                return str2.Split('-')[0];
            }
            return " ";
        }

        internal bool Cont(int n, int[] arr)
        {
            return arr[n] == 1;
        }

        internal void N()
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = -1;
            }
            for (int i = 0; i < list2.Length; i++)
            {
                list2[i] = -1;
            }
        }
        internal bool isFull(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1)
                    return false;
            }
            return true;
        }
        public double CapasityOne()
        {
            double cap = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != -1)
                    cap++;
            }
            return cap;
        }
        public double CapasityTwo()
        {
            double cap = 0;
            for (int i = 0; i < list2.Length; i++)
            {
                if (list2[i] != -1)
                    cap++;
            }
            return cap;
        }

    }
}
