using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    [SerializeField] GameObject TitleIcon;
    IconCotroller _tiIocn;
    [SerializeField] Animator stageIcon;
    [SerializeField] StageIcon _stIcon;
    // Start is called before the first frame update
    void Start()
    {
        _stIcon = _stIcon.GetComponent<StageIcon>();
        _tiIocn = TitleIcon.GetComponent<IconCotroller>();
        stageIcon = stageIcon.GetComponent<Animator>();
        _stIcon.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_tiIocn.STAGE) {
            _stIcon.enabled = true;
            stageIcon.SetBool("stage", true);
            
        }
        if(Input.GetKeyDown(KeyCode.A)) {
            stageIcon.SetBool("stage", false);
            _tiIocn.STAGE = false;
            _stIcon.YESFLAG = false;
            _stIcon.enabled = false;
        }
    }
}
