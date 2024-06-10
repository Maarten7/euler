triangle = """75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23"""

triangle = """03
04 05
06 07 08
12 11 10 09
44 92 57 18 22"""


class Triangle(object):
    def __init__(self, striangle):

        if type(striangle) == str:
            rows = striangle.split("\n")
            self.coloms = [x.split(' ') for x in rows]
            self.coloms = [[int(y) for y in x] for x in self.coloms]
        elif type(striangle) == list:
            self.coloms = striangle

    def __repr__(self):
        k = ""
        for x in self.coloms:
            k += '\n'
            for y in x:
                k += str(y) + ' ' 
        return k

    def sub_triangle(self, right=False):

        if right:
            return Triangle([x[1:] for x in self.coloms][1:])
        else:
            return Triangle([x[:-1] for x in self.coloms][1:])

    def max_sum_path(self):

        if len(self.coloms) == 1:
            return self.coloms[0][0]
            
        max_left  = self.sub_triangle().max_sum_path()
        max_right = self.sub_triangle(right=True).max_sum_path()

        return max(max_left, max_right) + self.coloms[0][0]

t = Triangle(triangle)
print(t.max_sum_path())
