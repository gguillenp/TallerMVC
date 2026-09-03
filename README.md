# Taller MVC en C# — Proyecto listo (tabla maestra: `curso`)

Este proyecto ya está armado según lo explicado en las dos capacitaciones y
cumple lo pedido en `Taller_MVC_2026.pdf`: tres capas (Vista, Controlador,
Modelo) referenciadas entre sí, un proyecto de biblioteca de clases por capa,
un proyecto de ejecución aparte, conexión ODBC vía DSN, y uso de una tabla
maestra de un proyecto propio (aquí, `curso` del script de asignación de
cursos que me diste).

Lo único que no puedo hacer por ti desde aquí es lo que requiere tu máquina
Windows con Visual Studio y MySQL instalados: crear el DSN, compilar/ejecutar
y grabar el video. Todo el código, los `.csproj` y el `.sln` ya están hechos
y referenciados correctamente, así que solo sigue estos pasos.

## Por qué la tabla `curso`

El script `script_asignaciones_db_completo.sql` trae ~22 tablas. Usé `curso`
porque es una tabla maestra (sin llaves foráneas, catálogo simple: código,
nombre, créditos, etc.) igual de sencilla que el ejemplo `empleados` que usó
el instructor. Si un compañero de equipo ya la está usando, cámbiala en un
solo lugar: la línea `string nombreTabla = "curso";` en
`CapaVista_MVC1/FormPrincipal.cs`. Otras tablas maestras sin dependencias en
el mismo script: `rol`, `permiso`, `facultad`, `edificio`,
`periodo_academico`.

## Estructura del proyecto

```
TallerMVC1/
├── TallerMVC1.sln                     (abre esto en Visual Studio)
├── CapaModelo_MVC1/                   (biblioteca de clases)
│   ├── Conexion.cs                    (abrir/cerrar conexión ODBC)
│   └── Sentencias.cs                  (SELECT * FROM curso)
├── CapaControlador_MVC1/              (biblioteca de clases)
│   └── Controlador.cs                 (llama al modelo, arma el DataTable)
├── CapaVista_MVC1/                    (biblioteca de clases)
│   ├── FormPrincipal.cs
│   ├── FormPrincipal.Designer.cs      (botón "Consultar datos" + DataGridView)
│   └── FormPrincipal.resx
├── EjecucionTallerMVC1/               (aplicación Windows Forms, es la que se ejecuta)
│   └── Program.cs
└── script_asignaciones_db_completo.sql
```
