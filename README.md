# SpartaTown

### 목차

1. 게임 설명
2. 구현 목록
3. 플레이 화면
4. 문제점

---

# 1. 게임 설명

- **게임명: `SpartaTown`**
- **설명:** [내일 배움 캠프 8기 Unity] Unity 게임개발 입문 개인과제.
- **개요:**
    - Gather 를 복제.

---

# 2. 구현 목록

아래의 필수 요구 사항 및 선택 요구사항은 모두 구현 완료한 상태이다.

🔽 **필수 요구 사항 목록**

- 캐릭터 만들기
- 캐릭터 이동
- 방 만들기
- 카메라 따라가기

🔽 **선택 요구사항 목록**

- 캐릭터 애니메이션 추가 (난이도 - ★★☆☆☆)
- 이름 입력 시스템 (난이도 - ★★★☆☆)
- 캐릭터 선택 시스템 (난이도 - ★★★★☆)

---

# 3. 플레이 화면

## 0️⃣ 캐릭터 선택 및 생성 화면

**🔽 캐릭터 선택 화면**

캐릭터의 이미지를 눌러 선택할 수 있다.

![StartScene1](/StartScene1.png)

캐릭터를 고를 수 있다.

![StartScene2](/StartScene2.png)

캐릭터의 이름을 입력할 수 있다.

![StartScene3](/StartScene3.png)

## 1️⃣ 게임 시작 화면

**🔽 게임 시작 화면**

입장 시 이름이 캐릭터 위에 나타난다.

![MainScene1](/MainScene1.png)

![MainScene3](/MainScene2.png)

## 전체 타일 맵

![Map](/Map.png)

---

# 4. 문제점

- StartScene 에서 캐릭터를 고를 때 GameDataScene에 데이터를 저장한다.
- MainScene 에서 캐릭터를 움직일 때 TopDownMovement 와 TopDownAimRotation 에서 플레이어 타입을 GameDataManger에서 가지고 온다.
- 플레이어 타입으로 플레이어 오브젝트 밑에 캐릭터 오브젝트를 골라서 SpriteRenderer 컴포넌트와 Animator 컴포넌트 를 가져와서 움직이게 한다.
- GameDataManger에서 플레이어 타입을 가져오는건 잘 되는데 GameDataManger에서 GameManager로 플레이어 타입을 가져오고 GameManager에서 TopDown~ 들에게 보내는 경우 에러가 생긴다.
- GameManager 가 먼저 생성되서 잘 될것같았는데 NullReferenceException 에러가 생긴다.
- 이유를 알고 싶습니다...
