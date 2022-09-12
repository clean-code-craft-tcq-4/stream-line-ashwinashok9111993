This is a simple project to print the values of a sensor from a given file

The file has a fixed format(.csv)
In the below pattern, which can be easily observed from code
"{sensorData.Timestamp},{sensorData.Temperature},{sensorData.StateOfCharge},{sensorData.ChargeRate}"

path to the binary:-
stream-line-ashwinashok9111993_1\BMSStreamSenderApp\SenderCLI\bin\Debug\netcoreapp3.1\SenderCLI.exe

The input to this program is a file present at the below location
stream-line-ashwinashok9111993_1\BMSStreamSenderApp\SenderCLI\bin\Debug\netcoreapp3.1\SampleTestData.txt

An example execution:

PS>.\SenderCLI.exe
0,0,23,0
1,0,20,0.004
2,0,20,0.008
3,0,20,0.012
4,0,21,0.016
5,1,21,0.02
6,1,21,0.024
7,1,22,0.027999999
8,1,22,0.032
9,1,22,0.036000002
10,2,23,0.04
11,2,23,0.044
12,2,23,0.048
13,2,23,0.052
14,2,24,0.055999998
15,3,24,0.06
