/*
    Math.round(1.5) -> 1.6 : 반올림
    Math.ceil(1.0001) -> 2 : 올림
    Math.floor(1.9999) -> 1 : 내림
*/
const quotes = [
    {
        quote: "꿈을 이루고자 하는 용기만 있다면 모든 꿈을 이룰 수 있다.",
        author: "윌트 디즈니"
    },
    {
        quote: "비록 해가 진다고 해도, 내게는 전기불이 있다.",
        author: "로커 커트 코베인"
    },
    {
        quote: "웃음이 없는 하루는 버린 하루다.",
        author: "찰리 채플린"
    },
    {
        quote: "우리는 한 번도 존재하지 않았던 것을 꿈꿀 수 있는 사람들이 필요하다.",
        author: "존 F.케네디"
    },
    {
        quote: `변화는 우리가 누군가나 무엇, 혹은 후일을 기다린다고 찾아오지 않는다.
        우리 자신이 우리가 기다리던 사람이고 우리가 바로 우리가 추구하는 변화이다.`,
        author: "오바마 대통령"
    },
    {
        quote: "무슨 일을 하기 전에는 그 일에 대한 기대를 가져야 한다.",
        author: "마이클 조던"
    },
    {
        quote: "도전하는 젊음, 아름답지 않니?",
        author: "오프라 윈프리"
    },
    {
        quote: "남들이 할 수 있거나 하려는 일을 하지 말고 남들이 할 수 없거나 하지 않으려는 일을 하라",
        author: "아멜리아 에어하트"
    },
    {
        quote: `새로운 일에 도전하다 보면 가끔 실수를 저지를 수 있다. 
        자신의 실수를 빨리 인정하고 다른 시도에 집중하는 것이 최선이다.`,
        author: "스티브 잡스"
    },
    {
        quote: "행동은 모든 성공의 가장 기초적인 핵심이다.",
        author: "파블로 피카소"
    },
    {
        quote: "용기란 죽을만큼 두려워도 무언가 해보는 것이다.",
        author: "존 웨인"
    },
    {
        quote: "절대로 고개를 떨구지 말라. 고개를 꼿꼿이 치켜 들고 두 눈으로 똑똑히 세상을 보라.",
        author: "헬렌 켈러"
    },
    {
        quote: "무언가를 위해 죽을 각오가 없다면, 인생을 살게 해줄 무언가도 가질 수 없을 것이다.",
        author: "체게바라"
    },
    {
        quote: "승리는 가장 끈기 있는 사람에게 돌아간다.",
        author: "보나파르트 나폴레옹"
    },
    {
        quote: "인생에서 실패한 사람의 대부분은 성공이 눈앞에 왔는데도 모르고 포기한 사람들이다.",
        author: "토마슨 에디슨"
    },
    {
        quote: "노력하는 사람에게 불가능이란 없다.",
        author: "알렉산더 대왕"
    },
    {
        quote: "오늘 나무 그늘에서 쉴 수 있는 이유는 예전에 나무를 심었기 때문이다.",
        author: "워렌 버핏"
    },
    {
        quote: "너는 머뭇거릴 수 있지만, 시간은 그렇지 않다.",
        author: "벤자민 플랭클린"
    },
    {
        quote: "가장 용감한 행동은 자신에 대해 생각하고 그것을 큰 소리로 외치는 일이다.",
        author: "코코 샤넬"
    },
    {
        quote: "네가 누구인지, 무엇인지 말해 줄 사람은 필요 없다. 너는 그냥 너 자신일 뿐이다.",
        author: "존 레논"
    },
    {
        quote: "성공의 비결은 모르겠다. 하지만 실패의 비결은 알고 있다. 모든 사람들을 기쁘게 하려는 것이다.",
        author: "빌 코스비"
    },
    {
        quote: "나약한 태도는 그 사람 자체도 나약하게 만든다.",
        author: "알버트 아인슈타인"
    },
    {
        quote: "태도는 사소한 것이지만 그것이 만드는 차이는 엄청나다.",
        author: "윈스턴 처칠"
    },
    {
        quote: "작은 일에 헌신하라. 그 안에 당신이 가진 힘이 있다.",
        author: "테레사 수녀"
    },
    {
        quote: "인생이란 공평하지 않다는 사실에 익숙해져라.",
        author: "빌 게이츠"
    },
];

const quote = document.querySelector("#quote span:first-child");
const author = document.querySelector("#quote span:last-child");
const todaysQuote = quotes[Math.floor(Math.random() * quotes.length)];

quote.innerText = todaysQuote.quote;
author.innerText = todaysQuote.author;
