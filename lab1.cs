using System;

namespace ConsoleApp1
{
    class Program
    {

        public static void St1(bool[] itemsAchievements)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tИНТРО");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-- Открой глаза. Будильник уже звонит 3 раз, а тебе в уник к 1 паре. Вставай! Меньше надо Ютуб смотреть до часа ночи!\nКогда ты уже начнёшь работать, как все?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Внутренний голос раскалывал голову своим унылым монологом на 2 части, хотелось съесть чего-то нормального, но");
            Console.WriteLine("на завтрак был один лишь творог. Отличное начало дня! Наш герой идет в ванную умыться и ненароком засматривается");
            Console.WriteLine("на своё убитое лицо в отражении зеркала. Время познакомиться!\n");
            Console.WriteLine("   Перед вами Непись - типичный студент техвуза родом из Заводского района города Ксним. Он любит хорошо проводить");
            Console.WriteLine("время с друзьями и слушать музыку в одиночестве. В нём нет ничего сверхудивительного, сверхпривлекательного и ");
            Console.WriteLine("сверхпрекрасного. Но история, произошедшая с нашим героем в этот самый заурядный день, отпечаталась в голове этого ");
            Console.WriteLine("парня на добрый десяток лет. И я очень рад поделиться ею с вами, дорогие юзеры, без преувеличений и выдумок,");
            Console.WriteLine("так, как мне её поведал сам Непись");
            Console.ReadKey(true);
            bool check = true;
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tИНТРО");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("-- Понедельник -- самый годный день");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", -- подумал про себя Непись. -- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("2 пары, из них одна - физра. Да и предки на работе.\nМожет, остаться дома?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Остаться дома почилить\n2. Взять рюкзак\n3. Пойти в уник");
            while (check)
            {
                ConsoleKey choice = Console.ReadKey(true).Key;
                itemsAchievements[0] = false;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        Ending1(itemsAchievements);
                        check = false;
                        break;
                    case ConsoleKey.D2:
                        itemsAchievements[0] = true;
                        Console.Write("-------------------------\nНепись взял рюкзак и ...");
                        while (check)
                        {
                            ConsoleKey choice2 = Console.ReadKey(true).Key;
                            switch (choice2)
                            {
                                case ConsoleKey.D1:
                                    Ending1(itemsAchievements);
                                    check = false;
                                    break;
                                case ConsoleKey.D3:
                                    St2(itemsAchievements);
                                    check = false;
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.D3:
                        St2(itemsAchievements);
                        check = false;
                        break;
                }
            }
        }
        public static void St2(bool[] itemsAchievements)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tУНИВЕРСИТЕТ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-- Первая пара - ПЗ по ММА, вот черт, я же ничерта не выучил! Эх, не надо было всё воскресенье сидеть за настолками.\nИ что теперь делать?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1. Забить *гвоздь* на этот бесполезный предмет\n2. Надеяться на помощь от одногруппов");
            if (itemsAchievements[0])
            {
                Console.WriteLine("3. Полистать учебник в трамвае");
            }
            bool check = true;
            while (check)
            {
                ConsoleKey choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        Ending2(itemsAchievements);
                        check = false;
                        break;
                    case ConsoleKey.D2:
                        Random helpmate = new Random(); // объявление переменной для генерации чисел
                        if (helpmate.Next(3) == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t\tУ КРЫЛЬЦА");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("-- Слава ПТУИРУ,  что у меня такая замечательная группа! В нужный момент всегда прикрывают)");
                            Console.ForegroundColor = ConsoleColor.White;
                            St3(itemsAchievements);
                        }
                        else
                        {
                            Ending2(itemsAchievements);
                        }
                        check = false;
                        break;
                    case ConsoleKey.D3:
                        if (itemsAchievements[0])
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t\tУ КРЫЛЬЦА");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("-- Славные парни эти Карпук и Жевняк, вечно спасают перед парой Теслы. Респект им!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" -- подумал про себя Непись.");
                            St3(itemsAchievements);
                            check = false;
                        }
                        break;
                }
            }
        }
        public static void St3(bool[] itemsAchievements)
        {
            Console.Write("\n   После пары Непись вышел в корридор, обсуждая последние новости о Короновирусе, сфере Ай-ти, отсталости \"яблочников\" \nи прочие антигуманитарные вещи.");
            Console.Write(" Как всегда, компания вышла на ступеньки у главного входа и начала обсуждать различные \nаспекты студенческой жизни.");
            Console.WriteLine("Сегодня Непись не хотел долго задерживаться в унике, но и кидать друзей было бы нехорошо.\n   Поэтому он выбрал...\n----------------------------------------------");
            Console.WriteLine("1. Попрощаться с друзьями и пойти на остановку\n2. Потрындеть ещё ~40 минут");
            bool check = true;
            while (check)
            {
                ConsoleKey choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        itemsAchievements[1] = true;
                        Console.WriteLine("\t\t\t\t\t\tТРАМВАЙ");
                        Console.WriteLine("   По всему было видно, что друзья не очень обрадовались скорому уходу Непися, но что поделать: время -- деньги.");
                        St4(itemsAchievements);
                        check = false;
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t\tТРАМВАЙ");
                        Console.WriteLine("   Наш герой приятно поболтал с товарищами, узнал решение сложнейшей задачи из 3 лабы и, по уши довольный, попрыгал\nк остановке. К сожалению, его трамвай ушел прямо из-под носа, и Неписю пришлось ждать лишний час сидеть в ожидании транспорта.");
                        St4(itemsAchievements);
                        check = false;
                        break;
                }
            }
        }
        public static void St4(bool[] itemsAchievements)
        {
            Console.WriteLine("\n   Залетев в двери трамвая и усевшись на место для инвалидов, Непись достал любимую книгу и приготовился читать.\nВдруг послышался звук блокировки валидаторов -- и перед неписем материализовался злобный контролёр средних лет:\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-- Ваш проездной, пожалуйста!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   Непись явно не был готов к такому. Хоть у него и была карточка учащегося, он не выглядел как школьник. А кровью\nи потом заработанную стипуху очень не хотелось тратить...\n   Как же быть?\n---------------------------------");
            Console.WriteLine("1. Заплатить по карте\n2. Понадеяться на карту учащегося\n3. Честно признаться");
            bool check = true;
            while (check)
            {
                ConsoleKey choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        if (itemsAchievements[1])
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t\tГОП-СТОП");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("-- Хм, не знал, что непробитая карта отобьётся как оплаченная. Что тут сказать, IT-страна!");
                            Console.ForegroundColor = ConsoleColor.White;
                            St5(itemsAchievements);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t\tКАПРЕМОНТ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("-- Хм, не знал, что непробитая карта отобьётся как оплаченная. Что тут сказать, айти страна!");
                            Console.ForegroundColor = ConsoleColor.White;
                            St6(itemsAchievements);
                        }
                        check = false;
                        break;
                    case ConsoleKey.D2:
                        Random shara = new Random(); // объявление переменной для генерации чисел
                        if (shara.Next(3) == 2)
                        {
                            if (itemsAchievements[1])
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t\t\t\tГОП-СТОП");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("-- Фух, пронесло. Неужели я всё ещё выгляжу на школьный возраст? Может, отростить бороду, как тру прогер?");
                                Console.ForegroundColor = ConsoleColor.White;
                                St5(itemsAchievements);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t\t\t\tКАПРЕМОНТ");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("-- Фух, пронесло. Неужели я всё ещё выгляжу на школьный возраст? Может, отростить бороду, как тру прогер?");
                                Console.ForegroundColor = ConsoleColor.White;
                                St6(itemsAchievements);
                            }
                        }
                        else
                        {
                            Ending3(itemsAchievements);
                        }
                        check = false;
                        break;
                    case ConsoleKey.D3:
                        if (itemsAchievements[1])
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t\tГОП-СТОП");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("-- Эх, молодежь... Тебе повезло, что я уже оштрафовал сегодня пару \"зайцев\". К тому же, ты честный малый,\n так что штрафовать я тебя не буду. Но чтобы впредь такого не было! ");
                            Console.ForegroundColor = ConsoleColor.White;
                            St5(itemsAchievements);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t\tКАПРЕМОНТ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("-- Эх, молодежь... Тебе повезло, что я уже оштрафовал сегодня пару \"зайцев\". К тому же, ты честный малый,\n так что штрафовать я тебя не буду. Но чтобы впредь такого не было!");
                            Console.ForegroundColor = ConsoleColor.White;
                            St6(itemsAchievements);
                        }
                        check = false;
                        break;
                }
            }
        }
        public static void St5(bool[] itemsAchievements)
        {
            Console.WriteLine("\n   Идёт Непись по району, идёт -- а на встречу ему гопнички славянские, наши, родненькие:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-- Эй, ёпт, братишка, стопарни.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-- Это вы мне?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-- Кому ж ещё, ёпте? Слушай сюда, малый, гони свой айфон -- мы тебя не тронем. Всё просто. Бабосики себе оставь.\nС навороченной геолокацией будем в 2 раза больше дуденев гопарить. НУ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n-- Может, лучше дать им по морде или дать дёру?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1. Поробовать убежать\n2. Дать по морде скотам!\n3. Отдать мобилку");
            bool check = true;
            while (check)
            {
                ConsoleKey choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        RunMiniGame(itemsAchievements);
                        check = false;
                        break;
                    case ConsoleKey.D2:
                        Ending4(itemsAchievements);
                        check = false;
                        break;
                    case ConsoleKey.D3:
                        itemsAchievements[2] = true;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t\tКАПРЕМОНТ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-- Это чё Самсунг? Ты не мог себе ещё более ущербную модель купить?");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("-- Мне его родители покупали!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-- Ладно, типок, аревуа! Спасибо за звонилку, если что -- звони! Ахахаха...");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("-- Ладно, не велика потеря. Лучше поскорее идти домой.");
                        Console.ForegroundColor = ConsoleColor.White;
                        St6(itemsAchievements);
                        check = false;
                        break;
                }
            }
        }

        public static void St6(bool[] itemsAchievements)
        {
            Console.WriteLine("\n   Осталось совсем ничего - пройти стройплощадку перед домом. Но сделать это не так просто: повсюду рытвины и арматура.");
            Console.WriteLine("Не дай бог ещё что-нибудь на голову свалится. Непись подходит к дому и видит замечательную картину: вся площадка у\nподъезда разрыта.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("-- И как это понимать?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" -- спрашивает Непись у рабочего-крановщика.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-- Как есть! Вечно эти газовщики рулят производством. Мне это тоже не нравится, парень. Но, кажется, я могу тебе помочь.\nВидишь, возле того синего балкона недокрашено?..");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-- Так это мой балкон!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-- Тем более! Помоги мне докрасить этот участок, а я подсажу тебя с люльки прямо на балкон. По рукам?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-- Почему я должен помогать этим халтурщикам?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. Помочь красильщикам\n2. \"Я буду жаловаться в ЖЭС!!!\"\n3. Послать крановщика на 3 веселые буквы");
            bool check = true;
            while (check)
            {
                ConsoleKey choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        itemsAchievements[itemsAchievements.Length - 6] = true;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t\tHOME SWEET HOME");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("-- Оказывается, красить стены не так уж сложно. Помню, как красили с батей гараж, и он на меня постоянно орал, мол, мазки гуще...\nа тут -- нормально. Ну и отлично. Теперь могу хвастаться, что внёс лепту в ремонт собственного дома!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------\nРазблокировано достижение!\n");
                        Console.WriteLine("   Непись постучал в балконную дверь, и его отец открыл с внутренней стороны. Он был очень удивлен столь эффектным появлением сына.");
                        EndGame(itemsAchievements);
                        check = false;
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t\tHOME SWEET HOME");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-- Ну как всегда. Строители виноваты. А то, что на ЗП прожить невозможно... Ладно, я всё равно подсажу тебя. Залезай!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("   Непись постучал в балконную дверь, и его отец открыл с внутренней стороны. Он был очень удивлен столь эффектным появлением сына.");
                        EndGame(itemsAchievements);
                        check = false;
                        break;
                    case ConsoleKey.D3:
                        itemsAchievements[itemsAchievements.Length - 7] = true;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t\tHOME SWEET HOME");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-- Ну, падла, не ожидал от тебя такого, пацанёнок! А ну быстро сдрыснул, пока шею тебе не намылил!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("   Ловко перепрыгнув через рытвину диаметром в полтора метра, Непись оказался у подъезда и поспешил подняться на свой этаж. ");
                        EndGame(itemsAchievements);
                        check = false;
                        break;
                }
            }
        }

        public static void RunMiniGame(bool[] itemsAchievements)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tRUN, NePiC, RUN!(мини-игра, управление на стрелках)");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Впереди развилка! Куда бежать?");
            bool check = true;
            while (check)
            {
                ConsoleKey choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Снова развилка! Куда на этот раз?");
                        while (check)
                        {
                            choice = Console.ReadKey(true).Key;
                            switch (choice)
                            {
                                case ConsoleKey.RightArrow:
                                    Console.WriteLine("Почти оторвался! Последний правильный выбор!");
                                    while (check)
                                    {
                                        choice = Console.ReadKey(true).Key;
                                        switch (choice)
                                        {
                                            case ConsoleKey.DownArrow:
                                                itemsAchievements[itemsAchievements.Length - 5] = true;
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("--------------------------\nРазблокировано достижение!");
                                                Console.ReadKey(true);
                                                Console.Clear();
                                                Console.WriteLine("\t\t\t\t\t\tКАПРЕМОНТ");
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\n-- Да! Я оторвался! Последний раз так спринтил в 4 классе на физре. Пригодилось, однако!");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                St6(itemsAchievements);
                                                check = false;
                                                break;
                                            case ConsoleKey.RightArrow:
                                            case ConsoleKey.LeftArrow:
                                            case ConsoleKey.UpArrow:
                                                Ending4(itemsAchievements);
                                                check = false;
                                                break;
                                        }
                                    }
                                    break;
                                case ConsoleKey.DownArrow:
                                case ConsoleKey.LeftArrow:
                                case ConsoleKey.UpArrow:
                                    Ending4(itemsAchievements);
                                    check = false;
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.RightArrow:
                        Ending4(itemsAchievements);
                        check = false;
                        break;
                }
            }
        }
        public static void Ending1(bool[] itemsAchievements)
        {
            Console.Clear();
            itemsAchievements[itemsAchievements.Length - 1] = true;
            Console.WriteLine("\t\t\t\t\t\tКИБЕРБУЛИНГ");
            Console.WriteLine("   Слишком ленивый для подобных походов Непись остался дома и целый день шпилил в КСочку.Глобала он так и взял, зато влетел \nна отчисление из института за пропуск 100-го часа лекций.");
            Console.WriteLine("\n   Впоследствии он очень жалел об упущенных возможностях и прожил до конца своих дней на попечении родителей и пособию по \nбезработице. Он пытался пробиться в киберспорт, но был никому не нужен со своим Супримом.\n\n   Так закончилась (даже не начавшись) киберкарьера Непися.");
            Console.WriteLine("--------------------------\nРазблокировано достижение!");
            Console.ReadKey(true);
        }
        public static void Ending2(bool[] itemsAchievements)
        {
            Console.Clear();
            itemsAchievements[itemsAchievements.Length - 2] = true;
            Console.WriteLine("\t\t\t\t\t\tОТЛЕТЕЛ(!ОТ_БЕРЕГА)");
            Console.WriteLine("   Теслюк был в ярости от вечного раздолбайства Непися:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-- Ну ёшкин дрын, где вас таких учат?! Всего лишь найти предел композиции - и то не можешь! Приехали! Так если б это в \nпервый раз... Автомат в руки - вот что тебя по-настоящему научит быть ответственным и вовремя исполнять свои обязанности...\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   Так и произошло. Непись не прошел экзамен по ММА даже с 3 попытки (то ли предвзятость преподавателя, то ли он и вправду\nне учился). Летом ему пришла повесточка и попал наш дружочек под осенний призывчик. После армии всю жизнь проработал \nводителем \"УАЗа\" на армейской овощебазе.\n\n   А мог бы стать таким классным прогером...");
            Console.WriteLine("--------------------------\nРазблокировано достижение!");
            Console.ReadKey(true);
        }
        public static void Ending3(bool[] itemsAchievements)
        {
            Console.Clear();
            itemsAchievements[itemsAchievements.Length - 3] = true;
            Console.WriteLine("\t\t\t\t\t\tПОТРАЧЕНО");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-- КАК ТЫ СМЕЕШЬ МНЕ ВРАТЬ, ЩЕНОК?! Держи, чтобы жизнь мёдом не казалась!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   Контролер выдал штраф на сумму в 3 стипендии. Все деньги Непися канули в лету. О покупке ноута на 3 сем пришлось забыть.\nКак и про успешную учёбу, ведь без ноута на 3 семе делать нечего. Непись забрал документы по собственному желанию и решил\nперепоступить в следующем году.\n\n   Кто знает, что произойдет с ним в новом 1 семестре?");
            Console.WriteLine("------------------------------------------------------\nРазблокировано достижение!");
            Console.ReadKey(true);
        }
        public static void Ending4(bool[] itemsAchievements)
        {
            Console.Clear();
            itemsAchievements[itemsAchievements.Length - 4] = true;
            Console.WriteLine("\t\t\t\t\t\tTRAUMA");
            Console.WriteLine("   Непись никогда не занимался боевыми искусствами, но попробовал изобразить из себя Джеки-Чана, влетев с 2 ног в грудь\nстаршего гопаря. Ожидаемого, удар получился слабым, а Непись, не сумев правильно сгруппироваться, больно шлепнулся о землю.\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-- ТЫ ЧЁ РАМСЫ ПОПУТАЛ?! ****ите ушлёпка!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   Отовсюду посыпались удары. Особенно досталось травмированной руке...Когда гопники убежали, заслышав сирену, Непись \nпосмотрел на руку: откртый перелом...\n   Непися доставили в палату в 6 вечера, как только мы пришли с ужина. За это время мы с Неписем крепко скорешились. Я пообещал другу:\nво что бы то ни стало, в 2 здоровые руки мы накостыляем этим ублюдкам!");
            Console.WriteLine("--------------------------\nРазблокировано достижение!");
            Console.ReadKey(true);
        }
        public static void EndGame(bool[] itemsAchievements)
        {
            Console.WriteLine("   Наконец, Непись был дома. Его уже ждал вкусный обед, приготовленный отцом.");
            if (itemsAchievements[2])
            {
                Console.WriteLine("   Непись рассказал отцу об утрате телефона, но батя подбодрил сына и пообещал купить новый на зарплату.");
            }
            if (itemsAchievements[1])
            {
                Console.WriteLine("   Отец разозлился, что Непись пришёл поздно, и обед успел остыть. Но после рассказа о безумном дне,\n   отец смягчил своё негодование и похвалил сына за находчивость.");
            }
            Console.WriteLine("\n   Так закончился необычный день самого обычного Заводского жителя!");
            itemsAchievements[itemsAchievements.Length - 7] = true;
            Console.WriteLine("--------------------------\nРазблокировано достижение!");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            Console.Title = "NePiC kvest V 1.2.7";

            bool isPlaying = true;
            bool[] itemsAchievements = new bool[10];
            while (isPlaying)
            {
                Console.Clear();
                Console.WriteLine("\t\t\tПРИВЕТСТВУЮ! ВЫБЕРИТЕ ПУНКТ МЕНЮ И НАЖМИТЕ СООТВЕТСТВУЮЩУЮ КЛАВИШУ");
                Console.WriteLine("1. Начать заново\n2. Концовки и айтемы\n3. О создателе\nENTER. Выйти\n--------------");
                ConsoleKey choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.Enter:
                        isPlaying = false;
                        break;
                    case ConsoleKey.D1:
                        Play(itemsAchievements);
                        break;
                    case ConsoleKey.D2:
                        Achievements(itemsAchievements);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t Game by ANDREWTHECHEESE STD");
                        Console.WriteLine("Не судите строго, моя первая адекватная игра.\n   23.02.2020 V 1.2.7 ");
                        Console.WriteLine("---------------------------------------------\nНажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey(true);
                        break;
                    default:
                        break;
                }
            }
        }

        static void Achievements(bool[] itemsAchievements)
        {
            Console.Clear();
            Console.Write("\t\t\t\t\t\t КОНЦОВКИ И АЙТЕМЫ");
            byte counter = 0;
            for (byte i = 1; itemsAchievements.Length - i >= 0; i++)
            {
                if (itemsAchievements[itemsAchievements.Length - i])
                {
                    counter++;
                }
            }

            Console.WriteLine(" (" + counter + " ИЗ 10)");

            for (byte i = 1; itemsAchievements.Length - i >= 0; i++)
            {
                Console.Write(i + ".");
                if (itemsAchievements[itemsAchievements.Length - i])
                {
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine(" Почти s1mple --> Не пройти отбор в киберспортивную команду");
                            break;
                        case 2:
                            Console.WriteLine(" Двоечник --> Отчислиться по неуспеваемости");
                            break;
                        case 3:
                            Console.WriteLine(" Черный понедельник --> Стать жертвой собственной лжи");
                            break;
                        case 4:
                            Console.WriteLine(" Fatality --> Press F to heal wounds");
                            break;
                        case 5:
                            Console.WriteLine(" Forrest Gump --> Пробежать стометровку быстрее гопников");
                            break;
                        case 6:
                            Console.WriteLine(" Боб строитель --> Схалтурить за красильщиков");
                            break;
                        case 7:
                            Console.WriteLine(" Пора возвращаться домой --> Пройти квест!");
                            break;
                        case 8:
                            Console.WriteLine(" ГДЕ ДЕТОНАТОР? --> Отдать своё средство связи");
                            break;
                        case 9:
                            Console.WriteLine(" ...а потом мне прострелили колено --> Найти приключения на свою голову");
                            break;
                        case 10:
                            Console.WriteLine(" 1 сентября --> Не забыть /*свою голову*/ рюкзак");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" ???");
                }
            }
            Console.WriteLine("---------------------------------------------\nНажмите любую клавишу, чтобы вернуться в меню");
            Console.ReadKey(true);
        }
        static void Play(bool[] itemsAchievements)
        {
            for (int i = 0; i < 4; i++)
            {
                itemsAchievements[i] = false;
            }
            St1(itemsAchievements);
        }
    }
}
