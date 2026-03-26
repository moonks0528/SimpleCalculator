## (C# 코딩) 
심플 사칙연산기

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자 입력을 받아 사칙연산 결과를 계산하고 화면에 출력하는 C# Windows Forms 계산기 프로그램
- 사용한 플랫폼:
	- C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
	- Label → 계산기 제목 표시
	- TextBox → 입력 숫자 및 계산 결과 표시 (inputNumBox, outputNumBox)
	- Button → 숫자 입력 및 연산 기능 수행
	
- 사용한 기술과 구현한 기능:
	- Visual Studio를 이용하여 UI 디자인함
	- ToString() 메서드를 사용하여 계산 결과를 문자열로 변환 후 TextBox에 출력
	- int.Parse()를 사용하여 TextBox의 문자열 데이터를 정수형(int)으로 변환하여 계산 수행

- 수업 중에 배우고 사용했던 클래스들 관련된 설명
	- 

- 실습 중에 구현한 기능들 설명
	-  


## 실행 화면 (과제1)
![과제1 실행화면](img/ScreenShot1.png)
- 과제1 코드의 실행 스크린샷
	- 숫자 누르면 (여러 개를 눌러도) 입력값이 표시됨

![과제1 실행화면2](img/ScreenShot2.png)
- 과제1 코드의 실행 스크린샷2
	- 연산자 버튼 누르면 inPutNumBox에 표시
	- Operand(피연산자)가 하나씩 표시됨

![과제1 실행화면3](img/ScreenShot3.png)
- 과제1 코드의 실행 스크린샷3
	- Operand(피연산자)가 하나씩 표시됨

![과제1 실행화면4](img/ScreenShot4.png)
- 과제1 코드의 실행 스크린샷4
	- = 버튼 누르면 계산 결과가 outputNumBox에 최종적으로결과값만표시 표시됨
	
- 과제 내용
	- Label, TextBox, Button 컨트롤을 활용하여 계산기 UI를 구성
	- 숫자 버튼 클릭 시 TextBox(inputNumBox)에 입력값이 표시되도록 구현.
	- +(btnPlus) 버튼 클릭 시 첫 번째 피연산자와 연산자를 저장.
	- 등호 버튼(btnEqual) 클릭 시 두 번째 피연산자를 입력받아 사칙연산 결과를 계산.
	- 계산 결과를 TextBox(outputNumBox)에 출력하여 사용자에게 표시.

- 구현 내용과 기능 설명
	- 입력창에 숫자 버튼을 클릭하면 해당 숫자가 inputNumBox에 표시됨
	- 사칙연산중 + 기능 구현
	- inputNumBox는 모든 내용을 표시하며 종이에 식을 풀어나가는것과 유사함
	- outputNumBox는 계산 결과만 표시되고 전자 계산기의 결과창과 유사.


##실행 화면 (과제2)

![과제2 실행화면1](img/ScreenShot5.png)
- 과제2 코드의 실행 스크린샷
	- 빼기 기능 구현

![과제2 실행화면2](img/ScreenShot6.png)
- 과제2 코드의 실행 스크린샷2
	- 곱하기 기능 구현

![과제2 실행화면3](img/ScreenShot7.png)
- 과제2 코드의 실행 스크린샷3
	- 나누기 기능 구현

![과제1 실행화면4](img/ScreenShot100.png)
- 과제2 코드의 실행 스크린샷4
	- 0으로 나누기 시 outputNumBox에 오류 메시지 출력
	- CE 버튼으로 초기화 후 다시 계산 가능

## 과제 내용
- 뺄셈(-), 곱셈(X), 나눗셈(÷) 연산 버튼을 추가하여 사칙연산 기능을 확장합니다.
- 각 연산 버튼 클릭 시 첫 번째 피연산자와 선택된 연산자를 저장합니다.
- 등호(=) 버튼 클릭 시 두 번째 피연산자를 입력받아 연산 결과를 계산하고 TextBox(outputNumBox)에 표시.

## 구현 내용과 기능 설명
- 사칙연산 기능 구현
- 곱셈과 나눗셈 연산은 화면에 X와 ÷ 기호로 표시되도록 구현하여 사용자에게 직관적으로 보여지도록 설정


## 실행 화면 (과제3)
![과제3 실행화면1](img/ScreenShot9.png)
![과제3 실행화면2](img/ScreenShot10.png)
- 과제3 코드의 실행 스크린샷
	- CE(Clear Entry) 버튼 클릭 시  현재 입력만 삭제 outputNumBox에서도 삭제됨
	
![과제3 실행화면3](img/ScreenShot12.png)
![과제3 실행화면4](img/ScreenShot11.png)
- 과제3 코드의 실행 스크린샷2
	- C(Clear) 버튼 클릭 시 모든 입력과 계산 결과 삭제 inputNumBox와 outputNumBox 모두 초기화됨


![과제3 실행화면5](img/ScreenShot13.png)
![과제3 실행화면6](img/ScreenShot14.png)
- 과제3 코드의 실행 스크린샷3
	- Del(Backspace) 버튼 클릭 시 마지막 입력 삭제 inputNumBox에서 마지막 입력이 삭제되고 outputNumBox에서도 반영됨

- 구현 내용과 기능 설명
	- C, CE, Del 버튼 기능을 구현.
	- CE는 현재 입력값만 초기화하고, C는 전체 계산 상태를 초기화하도록 구현.
	- Del은 입력값의 마지막 한 글자를 삭제하여 사용자가 쉽게 수정할 수 있도록 구현.

## 실행 화면 (과제4)
![과제4 실행화면1](img/ScreenShot15.png)
![과제4 실행화면2](img/ScreenShot15-1.png)

- 과제4 코드의 실행 스크린샷
	- 양수 음수 변환기능 구현(btnPlusMinus) 
		- 양수는 음수로, 음수는 양수로 변환하여 inputNumBox에 표시됨

![과제4 실행화면3](img/ScreenShot17.png)
- 공란에서 -버튼을 눌러 음수로 시작 불가능하기에 btnPlusMinus 버튼 구현 필수

![과제4 실행화면4](img/ScreenShot18.png)
- listBox에 계산 기록 표시
		- 계산식과 결과가 listBox(lstHistory)에 추가되어 이전 계산 기록을 확인가능

![과제4 실행화면5](img/ScreenShot19.png)
- btnHistoryReset(계산 기록 초기화) Reset History버튼 클릭 시 listBox(lstHistory)의 모든 항목이 삭제되어 계산 기록이 초기화됨

- 과제 내용
	- +/- 버튼을 추가하여 입력된 숫자의 부호를 변경할 수 있도록 구현합니다.
	- 계산 기록과 결과를 ListBox(lstHistory)에 표시하여 사용자가 이전 계산 내역을 확인할 수 있도록 구현.
	- Reset History 버튼을 추가하여 계산 기록을 초기화할 수 있도록 구현.
	- 키보드를 통한 입력 기능을 추가하여 사용자가 키보드로 숫자와 연산자를 입력할 수 있도록 구현.