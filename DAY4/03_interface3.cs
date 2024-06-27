using static System.Console;


// 카메라와 카메라 사용자 코드를 먼저 만들지 말고
// 지켜야 하는 규칙을 먼저 설계 합니다.

// 규칙 : 모든 카메라는 아래 인터페이스로 부터 파생되어야 한다.

interface ICamera
{
    void Take();
}

// 이제 카메라 사용자는 "구체적인 제품이름을 알필요 없고,
// "제품이름을 직접 사용하는 것은 좋지도 않습니다."
// "규칙대로만 사용하는 것이 좋습니다.
class People
{
    public void Use(? c) { c.Take(); }
}













class Camera
{
    public void Take() => WriteLine("Take a picture");
}

class HDCamera
{
    public void Take() => WriteLine("Take a HD picture");
}

class People
{
    public void Use(Camera c) => c.Take();
    public void Use(HDCamera c) => c.Take();
}

class Program
{
    public static void Main()
    {
        People p = new People();
        Camera c = new Camera();
        p.Use(c);

        HDCamera hc = new HDCamera();
        p.Use(hc);

    }
}
