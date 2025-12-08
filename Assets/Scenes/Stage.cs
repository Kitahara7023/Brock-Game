using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField] GameObject Ballprehub;
    [SerializeField] GameObject Blockprehub;

    private Ball _ball;
    private Block _block;
    private List<Block> _blocks = new List<Block>();

    void Start()
    {
        var ballObject = Instantiate(Ballprehub);
        var ball = ballObject.GetComponent<Ball>();
        ball.OnStart();
        _ball = ball;

        const int blockCount = 15;
        const int columnMax = 5;
        const float blockWidth = 0.5f;
        const float blockHeight = 0.25f;

        var offsetX = (columnMax / 2f * blockWidth) - blockWidth / 2;

        for (int i = 0; i < blockCount; i++)
        {
            var blockObject = Instantiate(Blockprehub);
            var block = blockObject.GetComponent<Block>();
            _blocks.Add(block);

            block.OnStart();
            var x = i % columnMax * blockWidth;
            var y = i / columnMax * blockHeight;
            block.gameObject.transform.localPosition = new Vector2(x - offsetX, y);
        }

        Debug.Log("_block.Count"+ _blocks.Count);

    }

    void Update()
    {
        _ball.OnUpdate();
    }
}
