<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/">
      <html>
        <head>
          <title>Music Catalogue</title>
        </head>
        <body>
          <h1>Music Albums Catalogue</h1>
          <ul>
            <xsl:for-each select="catalogue/album">
              <li>
                <div>
                  Name: <xsl:value-of select="name"/>
                </div>
                <div>
                  artist: <xsl:value-of select="artist"/>
                </div>
                <div>
                  year: <xsl:value-of select="year"/>
                </div>
                <div>
                  producer: <xsl:value-of select="producer"/>
                </div>
                <div>
                  price: <xsl:value-of select="price"/>
                </div>
                <ul>
                  <xsl:for-each select="songs/song">
                    <li>
                      <div>
                        title: <xsl:value-of select="title"/>
                      </div>
                      <div>
                        tduration: <xsl:value-of select="duration"/>
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
