using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class TestDoTween : MonoBehaviour {

    public GameObject cube;
    //public Image image;
    void Start()
    {
        //    //让TimeScale = 0  
        //    Time.timeScale = 0;
        //调用DOmove方法来让图片移动  
        //Tweener tweener = image.rectTransform.DOMove(Vector3.zero, 1f);
        ////设置这个Tween不受Time.scale影响  
        ////tweener.SetUpdate(true);
        ////设置移动类型  
        //tweener.SetEase(Ease.Linear);
        //tweener.OnComplete(delegate () {
        //    Debug.Log("移动完毕事件");
        //});
        //image.material.DOFade(0, 1f).OnComplete(delegate () {
        //    Debug.Log("褪色完毕事件");
        //});

        Tweener anim1 = cube.transform.DOMoveX(100, 3f);
        Tweener anim2 = cube.transform.DOScale(100, 3f);
        Tweener anim3 = cube.transform.DORotate(new Vector3(100,0,0), 3f);
        Tweener anim4 = cube.transform.DOScale(20, 3f);

        //anim2.OnComplete(new TweenCallback(myComplete));
        //anim2.OnComplete(myComplete);
        //anim2.OnComplete(delegate(){ Debug.Log("匿名函数"); });
        //anim2.OnComplete(()=>{ Debug.Log("Lambda"); });

        Sequence seq = DOTween.Sequence();
        seq.Append(anim1);
        seq.Join(anim2);
        seq.Append(anim3);
        seq.Insert(3, anim4);
    }

    void myComplete()
    {

    }
}
