using UnityEngine;

public class VectorExample : MonoBehaviour {

    //点积
    private void TestDot(Vector3 a, Vector3 b)
    {
        // 计算 a、b 点积结果
        float result = Vector3.Dot(a, b);

        // 通过向量直接获取两个向量的夹角（默认为 角度）， 此方法范围 [0 - 180]
        float angle = Vector3.Angle(a, b);

        // 计算 a、b 单位向量的点积,得到夹角余弦值,|a.normalized|*|b.normalized|=1;
        result = Vector3.Dot(a.normalized, b.normalized);
        // 通过反余弦函数获取 向量 a、b 夹角（默认为 弧度）
        float radians = Mathf.Acos(result);
        // 将弧度转换为 角度
        angle = radians * Mathf.Rad2Deg;
    }

    //叉乘
    private void TestCross(Vector3 a, Vector3 b)
    {
        //计算向量 a、b 的叉积，结果为 向量 
        Vector3 c = Vector3.Cross(a, b);

        // 通过反正弦函数获取向量 a、b 夹角（默认为弧度）
        float radians = Mathf.Asin(Vector3.Distance(Vector3.zero, Vector3.Cross(a.normalized, b.normalized)));
        float angle = radians * Mathf.Rad2Deg;

        // 判断顺时针、逆时针方向，是在 2D 平面内的，所以需指定一个平面，
        //下面以X、Z轴组成的平面为例 , (Y 轴为纵轴),
        // 在 X、Z 轴平面上，判断 b 在 a 的顺时针或者逆时针方向,
        if (c.y > 0)
        {
            // b 在 a 的顺时针方向
        }
        else if (c.y == 0)
        {
            // b 和 a 方向相同（平行）
        }
        else
        {
            // b 在 a 的逆时针方向
        }
    }

    // 获取两个向量的夹角  Vector3.Angle 只能返回 [0, 180] 的值
    // 如真实情况下向量 a 到 b 的夹角（80 度）则 b 到 a 的夹角是（-80）
    // 通过 Dot、Cross 结合获取到 a 到 b， b 到 a 的不同夹角
    private void GetAngle(Vector3 a, Vector3 b)
    {
        Vector3 c = Vector3.Cross(a, b);
        float angle = Vector3.Angle(a, b);

        // b 到 a 的夹角
        float sign = Mathf.Sign(Vector3.Dot(c.normalized, Vector3.Cross(a.normalized, b.normalized)));
        float signed_angle = angle * sign;

        Debug.Log("b -> a :" + signed_angle);

        // a 到 b 的夹角
        sign = Mathf.Sign(Vector3.Dot(c.normalized, Vector3.Cross(b.normalized, a.normalized)));
        signed_angle = angle * sign;

        Debug.Log("a -> b :" + signed_angle);
    }
}
