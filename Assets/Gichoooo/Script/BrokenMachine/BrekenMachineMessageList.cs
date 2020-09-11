using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrekenMachineMessageList : MonoBehaviour
{
    [SerializeField] AudioSource machineAudio;
    [SerializeField] int machineNum;
    string[] message = new string[20];

    private void Awake()
    {
        message[0] = "「上方より落石、回避不可能。\n探査失敗の報告を送信します。」";
        message[1] = "「送信失敗。再度メッセージを送信します。」";
        message[2] = "「噴火により衝撃が発生\n探査を続行できません」";
        message[3] = "「監察結果より、\n年中活動していると推定されます。」";
        message[4] = "「回路の破損を確認。自己修復不可能。」";
        message[5] = "「機体の姿勢が不安定です。\n人的サポートを要求します。」";
        message[6] = "「磁場センサーの不具合発生、\n方角が不明です。」";
        message[7] = "電力が切れているようだ...";
        message[8] = "「頂上付近に異常な力場を感知、\n機体のコントロールが不可能です。」";
        message[9] = "「土壌検査の結果、\n一般的な火山と変わりありません」";
        message[10] = "「重力に以上を検知、操作不可能です」";
        message[11] = "「落石による破損の影響で\n高度の維持は不可能です」";
        message[12] = "「送信失敗。送信失敗。送信失敗。\n送信失敗。送信失敗。」";
        message[13] = "熱により大破している...";
        message[14] = "回路が機能していないようだ...";
        message[15] = "「頂上付近に力場の原因となる因子を発見。\n高エネルギーのため接近不可能です。」";
        message[16] = "「機体操作システムに異常発生。\n探査を続行できません。」";
        message[17] = "「探査を開始します。探査失敗。\n探査を開始します。」";
        message[18] = "「金属反応を検知。座標はここ。」";
        message[19] = "記憶回路が故障している...";
    }

    public string GetMessage()
    {
        //Debug.Log(machineNum);
        //Debug.Log(message[machineNum]);
        machineAudio.Play();

        return message[machineNum];
    }

    public void Close()
    {
        machineAudio.Stop();
    }
}
