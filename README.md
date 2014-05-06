# „Наслов на проектот“

###### Антонио Ивановски
###### Петар Папалевски
###### Трајче Шопоски

# За игрите
Во овај проект се споени 3 игри

## X-O-ception
Добродојдовте во X-O-ception!

### Основни работи за играта
Играта зодржи една главна X-O табла, но во секоја нејзина келија се наоѓа уште една стандарна (мини) X-O табла.
![Слика со имиња за објектите на екранот](/readme_images/xoception_intro_1.png)

Играта започнува со сите мини табли отворени за игра. Следната мини табла која ќе се отвори, се одлучува според келијата која е кликната во минатото движење во мини таблата.
![Слика со концепт на кој се менува отворената табла](/readme_images/xoception_intro_2.png)

Пример: Ако играчот со X изигра во горно-левата келија, играчот со O „мора“ да игра во горно-левата мини табла.
Ако мини таблата е веќе освоена од некој играч, тогаш играчот на ред може да игра во сите табли.

Ако една мини табла е нерешена, тогаш таа мини табла се преигрува одново од почеток.
![Слика со имиња за објектите на екранот](/readme_images/xoception_draw_1.png) ![Слика со имиња за објектите на екранот](/readme_images/xoception_draw_2.png)

### Како до победа:
Да се победи една мини табла, треба да имате 3 исти во редица, колона или дијагонала.
Да се победи играта, треба да имате 3 победени мини табли во една редица, колона или дијагонала.
![Слика со имиња за објектите на екранот](/readme_images/xoception_win_1.png) ![Слика со имиња за објектите на екранот](/readme_images/xoception_win_2.png)


## Знамиња на држави
Добродојдовте во играта Знамиња на држави

### Основни работи за играта
Играта се состои од една почетна форма во која во средината во еден TextBox се испишува името на една случајно генерирана држава. Под случајно генерираната држава се одбираат 4 случајни знамиња кои се прикажуваат во PicturesBox.
Кога корисникот ќе одбере една од четирите случајно избрани држави се проверува дали избраното знаме е точно. Доколку корисникот го погоди знамето се прикажува следната слика.

![Слика со точен одговор](/readme_images/flags_true.png)

Доколку се избере погрешно на корисникот му се прикажува кое знаме е точното при што играта продолжува со следна генерирана држава.

![Слика со точен одговор](/readme_images/flags_false.PNG)

Во играта постои тајмер кој е конфигуриран на 1 минута при што на корисникот со еден ProgressBar му се прикажува преостанатото време. Откако ќе истече тајмерот со помош на MessageBox се прикажува колу знамиња корисникот има погодено при што има опција за започнување на нова игра или крај на играњето.

![Слика со точен одговор](/readme_images/flags_finish.PNG)

### Имплементација
Имплементацијата на играта е едноставна. Се состои само од една класа Game. Во класата Game во една листа се вчитуваат сите имиња на знамињата кои што се наоѓаат во папката Flags_Pictures. При стартување на играта генерираната листа се меша по случаен редослед со функцијата shuffle. На секое генерирање на ново прашање се прикажива едно точно знаменце и три неточни. Подолу се прикажани некој од поважните функции на класата Game.
```javascript

/* метод за генерирање на наредно прашање
од листата со држави ја зема следната држава
при што избира 4 случајни знаменца како одговори 
од кој едното е точниот одговор
*/ 
void generateNextQuestion()

// метод кој ги превзема сите слики од фолдерот Flags_Pictures
private void getListOfCountry()
{
  DirectoryInfo MyRoot = new DirectoryInfo("Flags_Pictures");
  FileInfo[] fileList = MyRoot.GetFiles();
  foreach (FileInfo file in fileList)
  countryList.Add(file.Name);
}

// метод кој прима листа од String со држави и ги меша во случаен редослед
private List<String> shuffle(List<String> input)
{
  List<String> output = new List<String>();
  Random rnd = new Random();

  int FIndex;
  while (input.Count > 0)
  {
    FIndex = rnd.Next(0, input.Count);
    output.Add(input[FIndex]);
    input.RemoveAt(FIndex);
  }

  input.Clear();
  input = null;
  rnd = null;

  return output;
}
```


