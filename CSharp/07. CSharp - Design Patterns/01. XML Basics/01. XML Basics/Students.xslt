<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/">
      <html>
        <title>
          Student System
        </title>
        <body>
          <h1>Students</h1>
          <ul>
            <xsl:for-each select="studentsystem/student">
              <li>
                <div>
                  Name: <xsl:value-of select="name"/>
                </div>
                <div>
                  Sex: <xsl:value-of select="sex"/>
                </div>
                <div>
                  Birthdate: <xsl:value-of select="birthdate"/>
                </div>
                <div>
                  Phone: <xsl:value-of select="phone"/>
                </div>
                <div>
                  Email: <xsl:value-of select="email"/>
                </div>
                <div>
                  Course: <xsl:value-of select="course"/>
                </div>
                <div>
                  Specialty: <xsl:value-of select="specialty"/>
                </div>
                <div>
                  Faculty number: <xsl:value-of select="facultynumber"/>
                </div>
                <ul>
                  <xsl:for-each select="exams/exam">
                    <li>
                      <div>
                        Exam: <xsl:value-of select="name"/>
                      </div>
                      <div>
                        Tutor: <xsl:value-of select="tutor"/>
                      </div>
                      <div>
                        Score: <xsl:value-of select="score"/>
                      </div>
                    </li>
                  </xsl:for-each>
                </ul>
              </li>
            </xsl:for-each>
          </ul>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
