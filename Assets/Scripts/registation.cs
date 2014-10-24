using UnityEngine;
using System.Collections;

public class registation : MonoBehaviour
{
    public UILabel u, p, cp, nick, email;
 
 
    // 注册按钮,被按下.
    void OnClick()
    {

        //空值测试
        if(p.text == "" || u.text == "" || nick.text == "" || email.text == "")
        {
            showMsg("请全部填写");
            return;
        }

        if(p.text != cp.text)
        {
            showMsg("两次密码不相同");
            return;
        }

        //测试邮箱名合不合法
        if(email.text.IndexOf('@') == -1)
        {
            showMsg("邮箱不合法");
            return;
        }

        //密码长度测试
        if(p.text.Length < 6)
        {
            showMsg("密码长度要大于等于6位");
            return;
        }
        //开始注册
        string r=web.reg(u.text, p.text, email.text, nick.text);
        showMsg(r);
        if (r.IndexOf("成功")!=-1)
        {
            //成功
        } 
   

    }
    public GameObject msgbox;
    void OnSubmit()
    {
        OnClick();
    }

    void showMsg(string t)
    {
        msgbox.SendMessage("showMsg", t);
    }
}
