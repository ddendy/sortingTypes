1. arr = {1, 0, -6, 2, 5, 3, 2}
2. берем правый элемент и считаем за точку опоры
arr[6] - pivot(опорный элемент)
3. все элементы меньше pivot встают слева от него, а элементы больше встают справа:
{1, 0, -6, 2, 2, 5, 3}
4. Вызвать шаги 2-3 для подмассива слева от pivot и справа от него
{1,0,-6,2}
pivot = 2
{1,0,-6}
pivot = -6
{-6,1,0}
{1,0}
{0,1}