SELECT     B.Sec, A.dcode, A.sname + ', ' + A.fname + ' ' + A.mname AS Donor_Name, B.StudNo, A.studname
FROM         dinfo AS A INNER JOIN
                      SInfo AS B ON A.studno = B.StudNo
WHERE     (A.remarksID = 4) AND (B.Typ = 'Student') AND (B.LCode = 'G11')
ORDER BY B.Sec, B.sname