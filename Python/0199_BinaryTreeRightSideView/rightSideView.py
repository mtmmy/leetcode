class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def rightSideView(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        if not root:
            return []
        rightSideNodes = []
        def rightSideView(nodes):
            if not nodes:
                return
            children = []
            val = []
            for node in nodes:
                if node:
                    val.append(node.val)
                    children.append(node.left)
                    children.append(node.right)
            if val:
                rightSideNodes.append(val[-1])
            rightSideView(children)
        
        rightSideView([root])
        
        return rightSideNodes