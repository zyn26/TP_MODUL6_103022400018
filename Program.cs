using TP_MODUL6_103022400018;

// TEST NORMAL
SayaMusicTrack lagu = new SayaMusicTrack("Lagu Aman");
lagu.IncreasePlayCount(100);
lagu.PrintTrackDetails();

// TEST PRECONDITION (judul null)
SayaMusicTrack error1 = new SayaMusicTrack(null);

// TEST PRECONDITION (lebih dari 100 karakter)
SayaMusicTrack error2 = new SayaMusicTrack(new string('A', 101));

// TEST OVERFLOW
SayaMusicTrack overflowTest = new SayaMusicTrack("Overflow Test");

for (int i = 0; i < 1000; i++)
{
    overflowTest.IncreasePlayCount(10000000);
}

overflowTest.PrintTrackDetails();